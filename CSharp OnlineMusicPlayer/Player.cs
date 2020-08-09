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
        private string url = string.Empty;
        private WindowsMediaPlayer wmp;
        private int volume = 3;

        private int index = 0;
        private MusicPanel curPanel = null; 
        
        private List<MusicElement> URLS = new List<MusicElement>();

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
            panel2.SuspendLayout();

            foreach (var i in URLS.Reverse<MusicElement>()) 
            {
                MusicPanel panel = new MusicPanel() { URL = i.URL, trackName = i.trackName };
                panel.Click += Panel_Click;
                
                panel2.Controls.Add(panel);

                await Task.Delay(1);
            }

            panel2.ResumeLayout();
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            curPanel = (MusicPanel)sender;
            index = panel2.Controls.IndexOf(curPanel);
            curPanel.Focus();
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
                label4.Text = $"{ wmp.controls.currentPositionString } / { wmp.currentMedia.durationString }";
                progressBar1.Value = trackPercent;
                trackBar1.Value = trackPercent;
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

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            trackPercent = trackBar1.Value;
            wmp.controls.currentPosition = wmp.currentMedia.duration / 100 * trackBar1.Value;
        }
    }
}
