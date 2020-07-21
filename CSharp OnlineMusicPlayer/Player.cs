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

        private List<string> listURLS = new List<string>();

        public List<string> URLS
        {
            get
            {
                return listURLS;
            }
            set
            {
                listURLS = value;
                listbox.DataSource = new BindingSource(listURLS, null);
            }
        }
        
        public Player()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            wmp.URL = listbox.SelectedItem.ToString();
            wmp.controls.play();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            wmp = new WindowsMediaPlayer();
            wmp.settings.volume = volume;
        }
    }
}
