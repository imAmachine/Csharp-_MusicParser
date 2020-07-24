using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_OnlineMusicPlayer
{
    public partial class MusicPanel : UserControl
    {
        private string url = string.Empty;
        public string URL
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
                label2.Text = value;
            }
        }
        public string trackName
        {
            get
            {
                return trackName;
            }
            set
            {
                label1.Text = value;
            }
        }
        public DateTime dt = DateTime.Now;

        public MusicPanel()
        {
            InitializeComponent();
        }

        private void MusicPanel_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Top;
            Height = 65;
        }

        private void MusicPanel_Enter(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void MusicPanel_Leave(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }
    }
}
