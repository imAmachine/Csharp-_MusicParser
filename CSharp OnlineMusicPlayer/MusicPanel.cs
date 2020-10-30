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
                lbl_Compositor.Text = value;
            }
        }
        private string trackName = string.Empty;
        private string author = string.Empty;
        private string dt = string.Empty;
        public string TrackName
        {
            get
            {
                return trackName;
            }
            set
            {
                trackName = value;
                lbl_Title.Text = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
                lbl_Compositor.Text = value;
            }
        }

        public string Duration
        {
            get
            {
                return dt;
            }
            set
            {
                dt = value;
                lbl_Time.Text = value;
            }
        }

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
                BackColor = SystemColors.ControlLightLight;
        }
    }
}
