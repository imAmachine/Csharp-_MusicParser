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
        public string url = string.Empty;
        WindowsMediaPlayer wmp;
        int volume = 3;
        
        public Player()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            wmp.URL = url;
            wmp.controls.play();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            wmp = new WindowsMediaPlayer();
            wmp.settings.volume = volume;
        }
    }
}
