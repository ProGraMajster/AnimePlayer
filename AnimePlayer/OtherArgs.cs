using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AnimePlayer
{
    public static class OtherArgs
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public static void Start()
        {
            foreach (string arg in Environment.GetCommandLineArgs())
            {
                if(arg == "-DataIndexer")
                {
                    
                }
                if(arg == "-Console")
                {
                    AllocConsole();
                }
                if(arg == "-AnimePlayerStatisticsData")
                {
                    Application.Run(new AnimePlayer.StatisticsData.FormWebsite());
                    return;
                }
            }
        }
    }
}
