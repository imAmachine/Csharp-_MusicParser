using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace CSharp_OnlineMusicPlayer
{
    public static class WWW
    {
        public static string GetPage(string link)
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(link);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                        return sr.ReadToEnd();

                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static List<MusicElement> GetMusicListFromWebPage(string webPage, string rgxPattern)
        {
            string pattern = rgxPattern;
            Regex rgx = new Regex(pattern);

            List<Match> matches = rgx.Matches(GetPage(webPage)).OfType<Match>().Where(x => x.Groups.Count > 0).ToList();

            List<MusicElement> musicList = new List<MusicElement>();
            
            foreach (Match i in matches)
                musicList.Add(new MusicElement(i.Groups[1].Value, "Test", DateTime.Now));

            return musicList;
        }
    }
}
