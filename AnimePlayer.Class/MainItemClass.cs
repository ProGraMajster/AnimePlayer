using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class MainItemClass
    {
        public string Name { get; set; }
        public string S_ID { get; set; }
        public PageItemData PageItemData { get; set; }
        public PreviewTitleClass PreviewTitleClass { get; set; }
    }
}
