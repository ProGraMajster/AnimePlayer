using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class DataContentManifest
    {
        public string VersionLibClass { get; set; }
        public string DataVersion { get; set; }
        public List<string> LinksToFile { get; set; }
    }
}
