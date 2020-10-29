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
        //private string startPageUrl = @"https://muzofond.fm/";
        private string startPageUrl = @"https://ruq.hotmo.org/";
        private Sites startPage = Sites.hotmo;
        
        //private string rgxPattern = @" < ul.*data-type=""tracks"".*|\s*<li class=""item active played"".*|\s*<li class=""play"".*data-url=""(.*)""";
        private string rgxPattern = @"<div\sclass=""track__info"".*[\n|\s]*.*[\n|\s]*.*.*[\n|\s]*(.*).*[\n|\s]*.*[\n|\s]*<div class=""track__desc"">(.*)<\/div>[\n|\s]*.*.*[\n|\s]*.*.*[\n|\s]*.*[\n|\s]*<div class=""track__fulltime"">([\d|:]*).*[\n|\s]*.*[\n|\s]*.*[\n|\s]*<a.*href=""(.*\.mp3)"""; // hitmo.org
        
        public Form1()
        {
            InitializeComponent();
        }
        private async void SetMusicList(string pageURL)
        {
            btn_Search.Enabled = false;
            List<MusicElement> musicList = new List<MusicElement>();

            await Task.Run(() =>
            {
                musicList = WWW.GetMusicListFromWebPage(pageURL, rgxPattern);
            });

            player1.Music = musicList;
            btn_Search.Enabled = true;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Sites s = 0;
            MessageBox.Show(s.ToString());
            //string link = Properties.Settings.Default.SelectedWebPage + (tb_Search.Text.Length > 0 ? LinksBySite.SearchQueryPattern + tb_Search.Text.Trim() : "");
            //SetMusicList(link);
        }

        private void player1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SelectedWebPage == null)

            SetMusicList(startPageUrl);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tb_Search.Clear();
        }

        private void hitmomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
