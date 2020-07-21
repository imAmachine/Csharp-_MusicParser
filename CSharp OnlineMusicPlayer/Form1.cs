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
        private string startPageUrl = @"https://muzofond.fm/";
        private string rgxPattern = @"<ul.*data-type=""tracks"".*|\s*<li class=""item active played"".*|\s*<li class=""play"".*data-url=""(.*)""";
        public Form1()
        {
            InitializeComponent();
        }
        private async void SetMusicList(string pageURL)
        {
            btn_Search.Enabled = false;
            List<string> musicList = new List<string>();

            await Task.Run(() =>
            {
                musicList = WWW.GetMusicListFromWebPage(pageURL, rgxPattern).Select(x => x.Groups[1].Value).ToList(); ;
            });

            player1.URLS = musicList;
            btn_Search.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetMusicList($@"https://muzofond.fm/search/{textBox1.Text.Trim()}");
        }

        private void player1_Load(object sender, EventArgs e)
        {
            SetMusicList(startPageUrl);
        }
    }
}
