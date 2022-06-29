using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using AnimePlayer.Core;
using AnimePlayer.Class;
using AnimePlayerLibrary.UI;

namespace AnimePlayer
{
    public static class ContentManager
    {
        public static List<MainItemClass> mainItemClasses;
        static bool normalFolder = false;
        static bool updateFolder = false;
        public static Control TartgetLoadingInfo;
        private static FormMainPlayer _formMainPlayer;
        public static void Initalize(FormMainPlayer formMainPlayer)
        {
            _formMainPlayer =formMainPlayer;
            if(!CheckingIfTheContentExists())
            {
                Updater.ContentUpdate.DownloadContent();
            }
            UpdateLoadingInfo("ContentManager>Initalize");
            foreach(var item in GetAllFromFolder())
            {
                formMainPlayer.flowLayoutPanelPolecane.Controls.Add(
                    CreatePreviewPanelFromData(item));
            }
            //Kurwa to jest zbugowane
        }

        public static Panel CreatePreviewPanelFromData(PreviewTitleClass previewTitleClass)
        {
            try
            {
                return new PanelItem(previewTitleClass).panelItem;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return null;
            }
        }

        public static List<PreviewTitleClass> GetAllFromFolder()
        {
            List<PreviewTitleClass> list = new List<PreviewTitleClass>();
            //Task.Run(() =>
          //  {
                DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.PreviewItems);
                foreach(var item in directoryInfo.GetFiles())
                {
                    if(!item.FullName.EndsWith(".dat"))
                    {
                        break;
                    }
                    list.Add((PreviewTitleClass)SerializationAndDeserialization.Deserialization(item.FullName));
                }
            //});
            return list;
        }

        private static void UpdateLoadingInfo(string text)
        {
            try
            {
                _formMainPlayer.labelLoadingDetails.BeginInvoke(new Action(() => {
                    _formMainPlayer.labelLoadingDetails.Text = text;
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
