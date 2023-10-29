using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class RelatedTitle
    {
        public string Title { get; set; }
        public string SID { get; set; }
        public TypeRelatedTitle TypeRelatedTitle { get; set; }
        public Guid Guid { get; set; }
    }
}
