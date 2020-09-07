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

namespace CSharp_OnlineMusicPlayer
{
    public partial class Player : UserControl
    {
        private MusicPanel curPanel = null;
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
                MusicPanel panel = new MusicPanel() { URL = i.URL, trackName = i.trackName, Margin = new Padding(0, 20, 0, 0) };
                
                panel2.Controls.Add(panel);

                await Task.Delay(1);
            }

            panel2.Controls.OfType<MusicPanel>().AsParallel().ForAll(x => x.Click += Panel_Click);
            pb.Dispose();
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            if (curPanel != null)
                curPanel.BackColor = SystemColors.Control;
            curPanel = (MusicPanel)sender;
            curPanel.BackColor = Color.Green;

            index = panel2.Controls.IndexOf(curPanel);
        }

        public Player()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            wmp.URL = curPanel.URL;
            wmp.controls.play();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            index = (index + ((Button)sender == btn_Next ? -1 : 1) + panel2.Controls.Count) % panel2.Controls.Count;
            curPanel = (MusicPanel)panel2.Controls[index];
            curPanel.Focus();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            wmp = new WindowsMediaPlayer();

            tb_Volume.Value = volume;

            Timer tmr = new Timer()
            {
                Interval = 1000
            };

            tmr.Tick += Tmr_Tick;
            tmr.Start();

            wmp.StatusChange += Wmp_StatusChange;
        }

        private void Wmp_StatusChange()
        {
            if (wmp.playState == WMPPlayState.wmppsMediaEnded)
            {
                btn_Next.PerformClick();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(wmp.controls.currentPositionString);
        }

        private void progressBar1_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickPoint = progressBar1.PointToClient(Cursor.Position);
            trackPercent = (int)Math.Round(clickPoint.X / (double)progressBar1.Width * 100);
            wmp.controls.currentPosition = wmp.currentMedia.duration / 100 * trackPercent;
        }
    }
}
