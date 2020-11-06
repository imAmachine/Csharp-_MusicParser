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
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest request = WebRequest.CreateHttp(link);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                        return sr.ReadToEnd();

                return string.Empty;
            }
            catch(WebException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return string.Empty;
            }
        }

        public static List<Match> GetMatches(string rgxPattern, string page)
        {
            Regex rgx = new Regex(rgxPattern);

            List<Match> matches = rgx.Matches(GetPage(page)).OfType<Match>().ToList();

            return matches;
        }

        public static List<MusicElement> GetMusicListFromWebPage(string webPage, string rgxPattern)
        {
            List<Match> matches = GetMatches(rgxPattern, webPage);
            List<MusicElement> musicList = new List<MusicElement>();

            foreach (Match i in matches)
            {
                switch (Global.webPage)
                {
                    case Sites.hotmo:
                        musicList.Add(new MusicElement(i.Groups[1].Value, i.Groups[2].Value, i.Groups[3].Value, i.Groups[4].Value));
                        break;
                    case Sites.sefon:
                        musicList.Add(new MusicElement(i.Groups[3].Value, i.Groups[2].Value, "", i.Groups[1].Value));
                        break;
                }
            }
            return musicList;
        }
    }
}
