using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class ContentIndex
    {
        public List<MainItemClass> MainItemClasses{ get; set; }

        //public List<EpisodeInforamion> EpisodeInforamions{ get; set; }
        public Dictionary<string, string> IconTitles{ get; set; }
        public Dictionary<string, MainItemClass> FindItemFormName{ get; set; }
    }
}
