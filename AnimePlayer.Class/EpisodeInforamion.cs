using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class EpisodeInforamion
    {
        public string Name { get; set; }
        public string TitleEpisode { get; set; }
        public string Description { get; set; }
        public int NumberEpisode { get; set; }

        public string TranslationGroup { get; set; }
        public string AdditionalInformation { get; set; }
    }
}
