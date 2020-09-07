using System;
using System.Drawing;
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

        private void MusicPanel_MouseEnter(object sender, EventArgs e)
        {
            if (BackColor != Color.Green && BackColor != Color.Beige)
                BackColor = Color.Bisque;
        }

        private void MusicPanel_MouseLeave(object sender, EventArgs e)
        {
            if (BackColor != Color.Green && BackColor != Color.Beige)
                BackColor = SystemColors.Control;
        }
    }
}
