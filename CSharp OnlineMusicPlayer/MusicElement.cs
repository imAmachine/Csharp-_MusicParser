using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OnlineMusicPlayer
{
    public class MusicElement
    {
        public string URL = string.Empty;
        public string trackName = string.Empty;
        public string author = string.Empty;
        public string duration = string.Empty;

        public MusicElement() { }
        public MusicElement(string trackName, string author, string duration, string url)
        {
            URL = url;
            this.trackName = trackName;
            this.author = author;
            this.duration = duration;
        }
    }
}
