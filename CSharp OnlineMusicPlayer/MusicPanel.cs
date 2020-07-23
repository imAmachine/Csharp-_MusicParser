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
        public string url
        {
            get
            {
                return url;
            }
            set
            {
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
    }
}
