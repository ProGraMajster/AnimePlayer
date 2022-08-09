using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using AnimePlayer.Core;
using AnimePlayer.Class;
using AnimePlayerLibrary.UI;
using System.Windows.Forms;

namespace AnimePlayer
{
    public static class ContentManager
    {
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
                Console.Error.WriteLine(ex.ToString());
            }
            List<PreviewTitleClass> previewTitleClasses = GetAllPreviewTitleClassFromFolder();
            foreach (PreviewTitleClass item in previewTitleClasses)
            {
                Panel panel = CreatePreviewPanelFromData(item);
                _formMainPlayer.flowLayoutPanelPolecane.Controls.Add(panel);
            }
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
            DirectoryInfo directoryInfo = new(pathSource);
            DirectoryInfo directoryInfo2 = new(pathnewloocation);
            if(!directoryInfo.Exists)
            {
                return;
            }
            if(!directoryInfo2.Exists)
            {
                return;
            }
            foreach (var item in directoryInfo.GetFiles())
            {
                item.MoveTo(pathnewloocation+item.Name, true);
            }
        }

        public static PageItemData GetPageItemDataWithContentFolderFromTitle(string title)
        {
            if(title == null)
            {
                return null;
            }
            try
            {
                DirectoryInfo directoryInfo = new(AppFolders.UpdatedPagesItems);
                foreach(var item in directoryInfo.GetFiles())
                {
                    if(item.Name.EndsWith(".dat"))
                    {
                        if(title.ToLower() == item.Name.ToLower())
                        {
                            return (PageItemData)SerializationAndDeserialization.Deserialization(item.FullName);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
            return null;
        }

        public static Panel CreatePreviewPanelFromData(PreviewTitleClass previewTitleClass)
        {
            try
            {
                PanelItem panelItem = new(previewTitleClass);
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
            List<PreviewTitleClass> list = new();
            //Task.Run(() =>
           // {
            try
            {
                Console.WriteLine("GetAllPreviewTitleClassFromFolder()");
                Console.WriteLine("Files:");
                DirectoryInfo directoryInfo = new(AppFolders.PreviewItems.TrimEnd('\\'));
                foreach (var item in directoryInfo.GetFiles())
                {
                    if (item.FullName.EndsWith(".dat"))
                    {
                        Console.WriteLine(item.FullName);
                        PreviewTitleClass previewTitleClass = (PreviewTitleClass)SerializationAndDeserialization.Deserialization(item.FullName);
                       list.Add(previewTitleClass);
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
    }
}
