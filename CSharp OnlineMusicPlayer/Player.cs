using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using WMPLib;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;

namespace CSharp_OnlineMusicPlayer
{
    public partial class Player : UserControl
    {
        private MusicPanel curPanel = null;
        private MusicPanel playingPanel = null;
        private List<MusicElement> URLS = new List<MusicElement>();
        private WindowsMediaPlayer wmp;

        private string url = string.Empty;
        private int volume = 3;
        private int index = 0;
        

        public List<MusicElement> Music
        {
            set
            {
                URLS = value;
                LoadMusicPanels(URLS);
            }
        }

        private async void LoadMusicPanels(List<MusicElement> URLS)
        {
            panel2.Controls.Clear();

            PictureBox pb = new PictureBox()
            {
                Size = new Size(Parent.Width, Parent.Height),
                Location = new Point(0, 0),
                Padding = new Padding(Width / 2 - 32 - SystemInformation.VerticalScrollBarWidth, (Height - this.VerticalScroll.Value) / 4, 0, 0),
                Image = Properties.Resources._5,
                Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom)
            };
            panel2.Controls.Add(pb);

            foreach (var i in URLS.Reverse<MusicElement>()) 
            {
                MusicPanel panel = new MusicPanel() { URL = i.URL, trackName = i.trackName, dt = i.duration };
                
                panel2.Controls.Add(panel);

                await Task.Delay(1);
            }

            panel2.Controls.OfType<MusicPanel>().AsParallel().ForAll(x => 
            {
                x.Click += Panel_Click;
                x.DoubleClick += btn_Play_Click;
                x.Controls.OfType<Control>().AsParallel().ForAll(y => { y.Click += Panel_Click; y.DoubleClick += btn_Play_Click; });
            });
            pb.Dispose();
        }

        private void X_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SelectPanel(MusicPanel panel)
        {
            if (curPanel != null && curPanel != playingPanel)
                curPanel.BackColor = SystemColors.Control;

            curPanel = panel;

            if (curPanel != playingPanel)
                curPanel.BackColor = Color.Green;

            index = panel2.Controls.IndexOf(curPanel);
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            MusicPanel panel = sender.GetType() != typeof(MusicPanel) ? (MusicPanel)((Control)sender).Parent : (MusicPanel)sender;
            SelectPanel(panel);
        }

        public Player()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (curPanel != null)
            {
                if (playingPanel != null)
                    playingPanel.BackColor = SystemColors.Control;
                playingPanel = curPanel;
                playingPanel.BackColor = Color.Beige;
                wmp.URL = curPanel.URL;
                wmp.controls.play();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (panel2.Controls.Count > 0)
            {
                index = (index + ((Button)sender == btn_Next ? -1 : 1) + panel2.Controls.Count) % panel2.Controls.Count;
                SelectPanel((MusicPanel)panel2.Controls[index]);
            }
        }

        private void Player_Load(object sender, EventArgs e)
        {
            panel2.Padding = new Padding(0, 0, 20, 0);
            
            wmp = new WindowsMediaPlayer();

            tb_Volume.Value = volume;

            Timer tmr = new Timer() { Interval = 1000 };

            tmr.Tick += Tmr_Tick;
            tmr.Start();

            wmp.PlayStateChange += Wmp_PlayStateChange;
        }

        private async void Wmp_PlayStateChange(int NewState)
        {
            if (wmp.playState == WMPPlayState.wmppsMediaEnded)
            {
                btn_Next.PerformClick();
                await Task.Delay(50);
                btn_Play.PerformClick();
            }
        }

        int trackPercent = 0;
        private void Tmr_Tick(object sender, EventArgs e)
        {
            if (wmp.currentMedia != null && wmp.currentMedia.duration > 0)
            {
                trackPercent = (int)(wmp.controls.currentPosition / wmp.currentMedia.duration * 100);
                label4.Text = $"{ (wmp.controls.currentPositionString != string.Empty ? wmp.controls.currentPositionString : "00:00") } / { wmp.currentMedia.durationString }";
                progressBar1.Value = trackPercent;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            wmp.settings.volume = tb_Volume.Value;
        }

        private void progressBar1_MouseClick(object sender, MouseEventArgs e)
        {
            if (wmp.URL != string.Empty)
            {
                Point clickPoint = progressBar1.PointToClient(Cursor.Position);
                trackPercent = (int)Math.Round(clickPoint.X / (double)progressBar1.Width * 100);
                wmp.controls.currentPosition = wmp.currentMedia.duration / 100 * trackPercent;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (wmp.playState == WMPPlayState.wmppsPaused)
            {
                button1.Text = "Pause";
                wmp.controls.play();
            }
            else if (wmp.playState == WMPPlayState.wmppsPlaying)
            {
                button1.Text = "Continue";
                wmp.controls.pause();
            }

        }
    }
}
