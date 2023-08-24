using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public  class Definition
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Guid { get; set; }
        public string FileCrator { get; set; }
    }
}
