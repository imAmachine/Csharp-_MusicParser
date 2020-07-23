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

namespace CSharp_OnlineMusicPlayer
{
    public partial class Player : UserControl
    {
        private string url = string.Empty;
        private WindowsMediaPlayer wmp;
        private int volume = 3;
        
        private List<MusicElement> URLS = new List<MusicElement>();

        public List<MusicElement> Music
        {
            set
            {
                URLS = value;
                foreach (var i in URLS)
                {
                    MusicPanel mp = new MusicPanel()
                    {
                        url = i.URL,
                        trackName = i.trackName
                    };
                    panel2.Controls.Add(mp);
                }
            }
        }

        public Player()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            //wmp.URL = listbox.SelectedItem.ToString();
            wmp.controls.play();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            //listbox.SelectedIndex = (listbox.SelectedIndex + ((Button)sender == btn_Next ? 1 : -1) + listbox.Items.Count) % listbox.Items.Count;
        }

        private void Player_Load(object sender, EventArgs e)
        {
            wmp = new WindowsMediaPlayer();
            wmp.PositionChange += Wmp_PositionChange;

            tb_Volume.Value = volume;
        }

        private void Wmp_PositionChange(double oldPosition, double newPosition)
        {
            progressBar1.Value++;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            wmp.settings.volume = tb_Volume.Value;
        }
    }
}
