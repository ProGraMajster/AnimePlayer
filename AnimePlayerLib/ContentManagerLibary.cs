﻿using System;
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
        /*
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
        */

        public static List<ItemCommunity> GetAllItemCommunities()
        {
            List<ItemCommunity> items = new();
            try
            {
                DirectoryInfo directoryInfo = new(AppFolders.Community);
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
                DirectoryInfo directoryInfo = new(AppFolders.UpdatedPagesItems);
                foreach(var item in directoryInfo.GetFiles())
                {
                    if(item.Name.EndsWith(".dat"))
                    {
                        PageItemData pageItemData = (PageItemData)SerializationAndDeserialization.Deserialization(item.FullName);
                        if(pageItemData != null)
                        {
                            if(title == pageItemData.TitleInformation.Title)
                            {
                                return pageItemData;
                            }
                        }
                    }
                }
                directoryInfo = new DirectoryInfo(AppFolders.PagesItems);
                foreach (var item in directoryInfo.GetFiles())
                {
                    if (item.Name.EndsWith(".dat"))
                    {
                        PageItemData pageItemData = (PageItemData)SerializationAndDeserialization.Deserialization(item.FullName);
                        if(pageItemData != null)
                        {
                            if(title == pageItemData.TitleInformation.Title)
                            {
                                return pageItemData;
                            }
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

        public static List<Episode> GetEpisode(int number, string title)
        {
            List<Episode> list = new();
            title = Replacer.Names(title);
            try
            {
                DirectoryInfo directoryInfo = new(AppFolders.VideosItems);
                foreach(var item in directoryInfo.GetFiles())
                {
                    Episode episode = (Episode)SerializationAndDeserialization.Deserialization(item.FullName);
                    if(episode.NumberEpisode == number.ToString() && episode.Title == title)
                    {
                        list.Add(episode);
                    }
                }
                return list;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
            return null;
        }

        /*
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
        */
    }
}
