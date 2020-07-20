using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace CSharp_OnlineMusicPlayer
{
    public static class WWW
    {
        public static string GetPage(string link)
        {
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    return sr.ReadToEnd();

            return string.Empty;
        }

        //public static List<MusicElement> GetMusicList(string webPage)
        //{

        //}
    }
}
