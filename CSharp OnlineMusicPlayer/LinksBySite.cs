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
        public static string SearchQueryPattern = "search?q=";
        //public static void GetTracksFrom(Sites website, string query)
        //{
        //    switch (website)
        //    {
        //        case Sites.hotmo:
        //            string link = @"https://ruv.hotmo.org/" + (query != "" ? SearchQueryPattern + query : query);
        //            SetMusicList(link);
        //            break;
        //    }
        //}

        public static void SetWebSite(Sites website)
        {
            switch (website)
            {
                case Sites.hotmo:
                    Properties.Settings.Default.SelectedWebPage = @"https://ruv.hotmo.org/";
                    Properties.Settings.Default.Save();
                    SearchQueryPattern = "search?q=";
                    break;
            }
        }

        //public static void ZaycevNetMusicLinks(List<MusicElement> music)
        //{
        //    music.ForEach(x =>
        //    {
        //        List<Match> matches = WWW.GetMatches(@"""url"":""(.*)""", x.URL.Insert(0, @"https://zaycev.net"));
        //        x.URL = matches.First().Groups[1].Value;
        //    });
        //}

        public static void HotmoMusicLinks(List<MusicElement> music)
        {
            music.ForEach(x =>
            {
                List<Match> matches = WWW.GetMatches(@"""url"":""(.*)""", x.URL.Insert(0, @"https://zaycev.net"));
                x.URL = matches.First().Groups[1].Value;
            });
        }
    }
}
