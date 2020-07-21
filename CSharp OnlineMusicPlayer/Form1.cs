using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_OnlineMusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rgxPattern = @"<ul.*data-type=""tracks"".*|\s*<li class=""item active played"".*|\s*<li class=""play"".*data-url=""(.*)""";
            WWW.GetMusicListFromWebPage(@"https://muzofond.fm/search/ram%20%D0%BF%D0%BE%D1%82", rgxPattern);
        }
    }
}
