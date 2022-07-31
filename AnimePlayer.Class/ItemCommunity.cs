using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class ItemCommunity
    {
        public string Name { get; set; }
        public string[] IconLinks { get; set; }
        public string[] banners { get; set; }
        public Dictionary<string, string> URLs { get; set; }
    }
}
