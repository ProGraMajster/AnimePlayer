using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    [Serializable]
    public class IpcMessage
    {
        public string AppName { get; set; }
        public bool Server { get; set; }
        public int FromThePort { get; set; }
        public int ToThePort { get; set; }
        public string RequestType { get; set; }
        public string MessageString { get; set; }
        public string MessageTypeClass { get; set; }
        public object MessageObject { get; set; }
    }
}
