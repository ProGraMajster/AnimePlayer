using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Profile
{
    [Serializable]
    public class ProfileIAnimeList
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ItemToList> itemToLists { get; set; }
    }
}
