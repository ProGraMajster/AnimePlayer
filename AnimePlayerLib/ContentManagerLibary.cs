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

namespace AnimePlayerLibrary
{
    public static class ContentManagerLibary
    {
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

        public static List<ItemCommunity> GetAllItemCommunities()
        {
            List<ItemCommunity> items = new List<ItemCommunity>();
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.Community);
                foreach(var item in directoryInfo.GetFiles())
                {
                    if(item.FullName.EndsWith(".dat"))
                    {
                        ItemCommunity itemCommunity =
                            (ItemCommunity)SerializationAndDeserialization.Deserialization(item.FullName);
                        items.Add(itemCommunity);
                    }
                }
                return items;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return null;
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
                DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.UpdatedPagesItems);
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
                directoryInfo = new DirectoryInfo(AppFolders.PagesItems);
                foreach (var item in directoryInfo.GetFiles())
                {
                    if (item.Name.EndsWith(".dat"))
                    {
                        if (title.ToLower() == item.Name.ToLower().Replace(".dat",""))
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
                Console.WriteLine("GetAllPreviewTitleClassFromFolder()");
                Console.WriteLine("Files:");
                DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.PreviewItems.TrimEnd('\\'));
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
