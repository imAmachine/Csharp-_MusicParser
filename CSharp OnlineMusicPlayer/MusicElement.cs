using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OnlineMusicPlayer
{
    public class MusicElement
    {
        public string URL { get; set; }
        public string MusicName { get; set; }
        public DateTime MusicDuration { get; set; }

        /// <summary>
        /// Данный класс позволяет хранить всю необходимую информацию о музыкальном треке
        /// </summary>
        /// <param name="url">Прямая ссылка на музыкальный трек</param>
        /// <param name="musicName">Название музыкального трека</param>
        /// <param name="musicDuration">Продолжительность музыкального трека</param>
        public MusicElement(string url, string musicName, DateTime musicDuration)
        {
            URL = url;
            MusicName = musicName;
            MusicDuration = musicDuration;
        }
    }
}
