using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class RootRelatedTitle
    {
        public string RootTitle { get; set; }

        public List<RelatedTitle> RelatedTitles { get; set; }
    }
}
