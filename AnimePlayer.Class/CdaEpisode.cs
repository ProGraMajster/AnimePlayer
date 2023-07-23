using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class CdaEpisode
    {
        public Episode Episode { get; set; }

        public string Link360p { get; set; }
        public string Link480p { get; set; }
        public string Link720p { get; set; }
        public string Link1080p { get; set; }
    }
}
