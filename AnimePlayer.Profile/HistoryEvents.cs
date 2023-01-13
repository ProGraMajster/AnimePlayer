using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Profile
{
    [Serializable]
    public class HistoryEvents
    {
        public string EventType { get; set; }
        public DateTime EventDateTime { get; set; }
        public string Descryption { get; set; }
        public string ClickEvent { get; set; }
    }
}