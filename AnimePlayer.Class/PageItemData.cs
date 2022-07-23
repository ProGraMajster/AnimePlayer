using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class PageItemData
    {
        public TitleInformation TitleInformation { get; set; }
        public List<RelatedTitle> RelatedTitles { get; set; }
        public string S_ID { get; set; }
    }
}
