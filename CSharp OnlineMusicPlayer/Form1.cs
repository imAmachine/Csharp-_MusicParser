using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

        private void button1_Click(object sender, EventArgs e)
        {
            player1.URLS = WWW.GetMusicListFromWebPage($@"https://muzofond.fm/search/{textBox1.Text.Trim()}", rgxPattern).Select(x => x.Groups[1].Value).ToList();
        }

        private void player1_Load(object sender, EventArgs e)
        {
            player1.URLS = WWW.GetMusicListFromWebPage(@"https://muzofond.fm/", rgxPattern).Select(x => x.Groups[1].Value).ToList();
        }
    }
}
