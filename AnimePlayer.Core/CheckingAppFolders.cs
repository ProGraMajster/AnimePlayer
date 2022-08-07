using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimePlayer.Class;

namespace AnimePlayer.Core
{
    public static class CheckingAppFolders
    {
        public static void CheckMainFolder()
        {
            if(!Directory.Exists(AppFolders.AppFolder))
            {
                CreateFolders();
            }
        }

        public static void CreateFolders()
        {
            try
            {
                Directory.CreateDirectory(AppFolders.AppFolder);
                Directory.CreateDirectory(AppFolders.Temp);
                Directory.CreateDirectory(AppFolders.PreviewItems);
                Directory.CreateDirectory(AppFolders.Community);
                Directory.CreateDirectory(AppFolders.Logs);
                Directory.CreateDirectory(AppFolders.News);
                Directory.CreateDirectory(AppFolders.Web);
                Directory.CreateDirectory(AppFolders.PagesItems);
                Directory.CreateDirectory(AppFolders.VideosItems);
                Directory.CreateDirectory(AppFolders.Icons);
                Directory.CreateDirectory(AppFolders.IconsBackup);
                Directory.CreateDirectory(AppFolders.Updater);
                Directory.CreateDirectory(AppFolders.Settings);
                Directory.CreateDirectory(AppFolders.ItemGroups);
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}