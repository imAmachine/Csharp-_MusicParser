using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OnlineMusicPlayer
{
    public static class Global
    {
        public static Sites curWebSite;
        public static string[] sites = new string[] { @"https://ruq.hotmo.org/" };

        public static Dictionary<Sites, string> QueryPatterns = new Dictionary<Sites, string>()
        {
            { Sites.hotmo, "search?q=" }
        };
    }
}
