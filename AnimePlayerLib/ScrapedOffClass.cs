using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayerLibrary
{
    [Serializable]
    public class ScrapedOffClass
    {
        public string LinkToIFrame { get; set; }
        public string TitleAnime { get; set; }
        public string TitleEpisode { get; set; }
        public string Number { get; set; }
        public string Translator { get; set; }
        public string A { get; set; }
        public string S { get; set; }
    }
}
