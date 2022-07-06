using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    internal class GroupClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> ItemNames { get; set; }
        public List<Guid> ItemIds { get; set; }
    }
}
