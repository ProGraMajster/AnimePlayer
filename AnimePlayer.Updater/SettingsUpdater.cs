using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Updater
{
    [Serializable]
    public class SettingsUpdater
    {
        public bool CheckingForUpdates { get; set; }
        public bool CheckingForUpdatesTimer { get; set; }
        public bool ReadFileSettingTimer { get; set; }
        public List<string> SourceUpdate { get; set; }
        public int CheckingForUpdatesTimerInterval { get; set; }
        public int ReadFileSettingsTimerInterval { get; set; } 
        public SettingsUpdater()
        {
            CheckingForUpdates = true;
            CheckingForUpdatesTimer = true;
            ReadFileSettingTimer = true;
            SourceUpdate = new List<string>();
            CheckingForUpdatesTimerInterval = 3600000;
            ReadFileSettingsTimerInterval = 300000;
        }
    }
}
