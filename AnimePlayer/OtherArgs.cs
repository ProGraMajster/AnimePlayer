using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer
{
    public static class OtherArgs
    {
        public static void Start()
        {
            foreach (string arg in Environment.GetCommandLineArgs())
            {
                if(arg == "-DataIndexer")
                {
                    
                }
            }
        }
    }
}
