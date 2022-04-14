using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    public class NewsClass
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Control> Controls { get; set; }

        //public List<string> ControlEvents
        public string NewsSource { get; set; }
    }
}
