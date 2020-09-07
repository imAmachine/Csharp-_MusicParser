﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp_OnlineMusicPlayer
{
    public static class LinksBySite
    {
        public static void ZaycevNetMusicLinks(List<MusicElement> music)
        {
            music.ForEach(x =>
            {
                List<Match> matches = WWW.GetMatches(@"""url"":""(.*)""", x.URL.Insert(0, @"https://zaycev.net"));
                x.URL = matches.First().Groups[1].Value;
            });
        }
    }
}