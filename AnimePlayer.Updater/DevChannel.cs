using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using AnimePlayerLibrary;
using AnimePlayer.Class;

namespace AnimePlayer.Updater
{
    public static class DevChannel
    {
        static readonly string link = @"https://github.com/ProGraMajster/AnimePlayer/archive/refs/heads/master.zip";
        public static void Start()
        {
            try
            {
                Download.File(link, AppFolders.Temp+"libs.zip");
                if (!Directory.Exists(AppFolders.Updater+"Downloaded_repo"))
                {
                    Directory.CreateDirectory(AppFolders.Updater+"Downloaded_repo");
                }
                ZipFile.ExtractToDirectory(AppFolders.Temp+"libs.zip", AppFolders.Updater+"Downloaded_repo");
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
