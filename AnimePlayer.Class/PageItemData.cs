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
        public TitleInformation titleInformation { get; set; }
        public List<string> RelatedSeries_SID { get; set; }
        public string S_ID { get; set; }
    }
}
