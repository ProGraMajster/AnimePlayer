using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class Episode
    {
        public string Title { get; set; }
        public string NumberEpisode { get; set; }
        public string TitleOfEpisode { get; set; }
        public string Type { get; set; }
        public string AudioLanguage { get; set; }
        public string SubtitleLanguage { get; set; }
        public string LinkToEpisode { get; set; }
        public string TranslationCreator { get; set; }
        public string TranslationCreatorAdditionalInformation { get; set; }
    }
}
