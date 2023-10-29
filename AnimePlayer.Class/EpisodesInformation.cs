using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class EpisodesInformation
    {
        public string Title { get; set; }
        List<EpisodeInfo> EpisodeInfos { get; set; }
    }
}
