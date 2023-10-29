using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    public class EpisodeInfo
    {
        public bool Aired { get; set; }
        public string AnimeTitle { get; set; }
        public string EpisodeTitle { get; set; }
        public string EpisodeDescription { get; set; }
        public double Duration { get; set; }
        public int Number {  get; set; }
        public DateTime DateTimeAired { get; set; }
        public List<string> LinksToImage { get; set; }
    }
}
