using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using AnimePlayer.Core;
using AnimePlayer.Class;

namespace AnimePlayer
{
    public static class ContentManager
    {
        public static List<MainItemClass> mainItemClasses;
        static bool normalFolder = false;
        static bool updateFolder = false;
        public static Control TartgetLoadingInfo;
        public static void Initalize()
        {
            if(!CheckingIfTheContentExists())
            {
                Updater.ContentUpdate.DownloadContent();
            }
            UpdateLoadingInfo("ContentManager>Initalize");
        }

        public static List<PreviewTitleClass> GetAllFromFolder()
        {
            List<PreviewTitleClass> list = new List<PreviewTitleClass>();
            Task.Run(() =>
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.PreviewItems);
                foreach(var item in directoryInfo.GetFiles())
                {
                    if(!item.FullName.EndsWith(".dat"))
                    {
                        break;
                    }
                    list.Add((PreviewTitleClass)SerializationAndDeserialization.Deserialization(item.FullName));
                }
            });
            return list;
        }

        private static void UpdateLoadingInfo(string text)
        {
            try
            {
                TartgetLoadingInfo.BeginInvoke(new Action(() => {
                    TartgetLoadingInfo.Text = text;
                }));
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private static bool CheckingIfTheContentExists()
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.PreviewItems);
                if(directoryInfo.Exists)
                {
                    var items = directoryInfo.GetFiles();
                    if(items.Length < 1)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
