using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace CSharp_OnlineMusicPlayer
{
    public partial class Form1 : Form
    {
        private Sites webPage = (Sites)Properties.Settings.Default.SelectedWebPage;
        private string[] pageData;
        public Form1()
        {
            InitializeComponent();
        }
        private async void SetMusicList()
        {
            string link = pageData[2] + (tb_Search.Text.Length > 0 ? pageData[0] + tb_Search.Text.Trim() : "");

            btn_Search.Enabled = false;
            List<MusicElement> musicList = new List<MusicElement>();

            await Task.Run(() =>
            {
                musicList = WWW.GetMusicListFromWebPage(link, pageData[1]);
            });

            player1.Music = musicList;
            btn_Search.Enabled = true;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SetMusicList();
        }

        private void player1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SelectedWebPage < 0)
            {
                Properties.Settings.Default.SelectedWebPage = 0;
                Properties.Settings.Default.Save();
            }
            pageData = Global.QueryPatterns[webPage];
            SetMusicList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tb_Search.Clear();
        }

        private void hitmomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinksBySite.SetWebSite(Sites.hotmo);
            pageData = Global.QueryPatterns[(Sites)Properties.Settings.Default.SelectedWebPage];
        }
    }
}
