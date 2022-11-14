using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Profile
{
    [Serializable]
    public class ItemToList
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public bool IsEpisodes { get; set; }
        public int NumberOfEpisodes { get; set; }
        public int WatchedEpisodes { get; set; }
        public int YourScore { get; set; }
        public int ReWatch { get; set; }
    }
}
