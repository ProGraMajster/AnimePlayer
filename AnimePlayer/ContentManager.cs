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
            try
            {
                Updater.ContentUpdate.DownloadContent();
                ContentMove();
            }
            catch(Exception ex)
            {

            }
            UpdateLoadingInfo("ContentManager>Initalize");
            foreach(PreviewTitleClass item in GetAllPreviewTitleClassFromFolder().ToArray())
            {
                Panel panel = CreatePreviewPanelFromData(item);
                _formMainPlayer.flowLayoutPanelPolecane.Controls.Add(panel);
            }
            //Kurwa to jest zbugowane
        }


        public static void ContentMove()
        {
            DirFilesMoveToDir(AppFolders.UpdatedPreviewItems, AppFolders.PreviewItems);
            DirFilesMoveToDir(AppFolders.UpdatedPagesItems, AppFolders.PagesItems);
            DirFilesMoveToDir(AppFolders.UpdatedVideosItems, AppFolders.VideosItems);
            DirFilesMoveToDir(AppFolders.UpdatedWeb, AppFolders.Web);
            DirFilesMoveToDir(AppFolders.UpdatedCommunity, AppFolders.Community);
        }

        private static void DirFilesMoveToDir(string pathSource, string pathnewloocation)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(pathSource);
            DirectoryInfo directoryInfo2 = new DirectoryInfo(pathnewloocation);
            if(!directoryInfo.Exists)
            {
                return;
            }
            foreach (var item in directoryInfo.GetFiles())
            {
                item.MoveTo(pathnewloocation+item.Name, true);
            }
        }

        public static Panel CreatePreviewPanelFromData(PreviewTitleClass previewTitleClass)
        {
            try
            {
                PanelItem panelItem = new PanelItem(previewTitleClass);
                return panelItem.panelItem;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return null;
            }
        }

        public static List<PreviewTitleClass> GetAllPreviewTitleClassFromFolder()
        {
            List<PreviewTitleClass> list = new List<PreviewTitleClass>();
            //Task.Run(() =>
           // {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.PreviewItems.TrimEnd('\\'));
                foreach (var item in directoryInfo.GetFiles())
                {
                    if (item.FullName.EndsWith(".dat"))
                    {
                       list.Add((PreviewTitleClass)SerializationAndDeserialization.Deserialization(item.FullName));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
          //  });
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
