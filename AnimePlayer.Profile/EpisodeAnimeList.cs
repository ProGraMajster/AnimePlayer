using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Profile
{
    [Serializable]
    public class EpisodeAnimeList
    {
        public string NameAnime { get; set; }
        public string NameEpisode { get; set;}
        public int NumberEpisode { get; set;}
        public DateTime DateTimeWatched { get; set;}    
    }
}
