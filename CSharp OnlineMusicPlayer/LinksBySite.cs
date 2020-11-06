using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp_OnlineMusicPlayer
{
    public static class LinksBySite
    {
        public static void SetWebSite(Sites website)
        {
            switch (website)
            {
                case Sites.hotmo:
                    Properties.Settings.Default.SelectedWebPage = 0;
                    Properties.Settings.Default.Save();
                    break;
                case Sites.sefon:
                    Properties.Settings.Default.SelectedWebPage = 1;
                    Properties.Settings.Default.Save();
                    break;
            }
        }
    }
}
