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
        public DateTime duration = DateTime.Now;

        public MusicElement() { }
        public MusicElement(string url, string trackName, DateTime duration)
        {
            URL = url;
            this.trackName = trackName;
            this.duration = duration;
        }
    }
}
