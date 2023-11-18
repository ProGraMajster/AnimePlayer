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
using System.Diagnostics;

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

        public static void CreateBackupicon()
        {
            try
            {
                DirectoryInfo directoryInfo = new("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon");
                foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                {
                    File.Copy(fileInfo.FullName, "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\IconBackup\\" + fileInfo.Name, true);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }
        public static List<ItemCommunity> GetAllItemCommunities()
        {
            List<ItemCommunity> items = new();
            try
            {
                DirectoryInfo directoryInfo = new(AppFolders.Community);
                foreach(var item in directoryInfo.GetFiles())
                {
                    if(item.FullName.EndsWith(".json"))
                    {
                        /*ItemCommunity itemCommunity =
                            (ItemCommunity)SerializationAndDeserialization.Deserialization(item.FullName);*/
                        ItemCommunity itemCommunity =
                            (ItemCommunity)SerializationAndDeserialization
                            .DeserializationJsonEx(item.FullName, typeof(ItemCommunity));
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
                    /*
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
                    else */
                    if(item.Name.EndsWith(".json"))
                    {
                        PageItemData pageItemData = (PageItemData)SerializationAndDeserialization.DeserializationJsonEx(item.FullName, typeof(PageItemData));
                        if (pageItemData != null)
                        {
                            if (title == pageItemData.TitleInformation.Title)
                            {
                                return pageItemData;
                            }
                        }
                    }
                }
                directoryInfo = new DirectoryInfo(AppFolders.PagesItems);
                foreach (var item in directoryInfo.GetFiles())
                {
                    /*
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
                    else */
                    if(item.Name.EndsWith(".json"))
                    {
                        PageItemData pageItemData = (PageItemData)SerializationAndDeserialization.DeserializationJsonEx(item.FullName, typeof(PageItemData));
                        if (pageItemData != null)
                        {
                            if (title == pageItemData.TitleInformation.Title)
                            {
                                return pageItemData;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
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
                    if (item.FullName.EndsWith(".json"))
                    {
                        Console.WriteLine(item.FullName);
                        PreviewTitleClass previewTitleClass = (PreviewTitleClass)SerializationAndDeserialization
                            .DeserializationJsonEx(item.FullName, typeof(PreviewTitleClass));
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
                    Episode episode = null;
                    /*
                    if (item.FullName.EndsWith(".dat"))
                    {
                        try
                        {
                            episode = (Episode)SerializationAndDeserialization.Deserialization(item.FullName);
                        }
                        catch(Exception exDat)
                        {
                            Debug.WriteLine(exDat.ToString());
                            Console.Error.WriteLine(exDat.ToString());
                        }
                    }
                    else 
                    */if(item.FullName.EndsWith(".json"))
                    {
                        try
                        {
                            episode = (Episode)SerializationAndDeserialization.DeserializationJsonEx(item.FullName, typeof(Episode));
                        }
                        catch(Exception exJson)
                        {
                            Debug.WriteLine(exJson.ToString());
                            Console.Error.WriteLine(exJson.ToString());
                        }
                    }
                    else
                    {
                        break;
                    }
                    if(episode != null)
                    {
                        if (episode.NumberEpisode == number.ToString() &&
                        Replacer.Names(episode.Title) == Replacer.Names(title))
                        {
                            list.Add(episode);
                        }
                    }
                }
                return list;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                Debug.WriteLine(ex.ToString());
            }
            return null;
        }

        public static List<string> GetLinkToIcon(string title)
        {
            try
            {
                DirectoryInfo dirInfo = new(AppFolders.PreviewItems);
                foreach(var item in dirInfo.GetFiles())
                {
                    if(item.Exists)
                    {
                        PreviewTitleClass previewTitleClass = null;
                        /*if (item.FullName.EndsWith(".dat"))
                        {
                            previewTitleClass = (PreviewTitleClass)SerializationAndDeserialization.Deserialization(
                            item.FullName);
                        }
                        else 
                        */if(item.FullName.EndsWith(".json"))
                        {
                            previewTitleClass= (PreviewTitleClass)SerializationAndDeserialization.DeserializationJsonEx(
                            item.FullName, typeof(PreviewTitleClass));
                        }
                        if(previewTitleClass != null&& title == previewTitleClass.Title)
                        {
                            return previewTitleClass.LinkToIcon;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return null;
            }
            return null;
        }   
        public static PreviewTitleClass GetPreviewTitleClassFromTitle(string title)
        {
            try
            {
                DirectoryInfo dirInfo = new(AppFolders.PreviewItems);
                foreach(var item in dirInfo.GetFiles())
                {
                    if(item.Exists)
                    {
                        PreviewTitleClass previewTitleClass = null;
                        /*if (item.FullName.EndsWith(".dat"))
                        {
                            previewTitleClass = (PreviewTitleClass)SerializationAndDeserialization.Deserialization(
                            item.FullName);
                        }
                        else
                        */if(item.FullName.EndsWith(".json"))
                        {
                            previewTitleClass= (PreviewTitleClass)SerializationAndDeserialization.DeserializationJsonEx(
                            item.FullName, typeof(PreviewTitleClass));
                        }
                        if(previewTitleClass != null&& title == previewTitleClass.Title)
                        {
                            return previewTitleClass;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return null;
            }
            return null;
        }

        public static List<TitleCommentsData> GetAllTitleCommentsData()
        {
            try
            {
                List<TitleCommentsData> titleCommentsDatas = new();
                DirectoryInfo directoryInfo = new(AppFolders.TitleComments);
                foreach(var item in directoryInfo.GetFiles())
                {
                    if(item.Exists)
                    {
                        TitleCommentsData titleCommentsData =
                            (TitleCommentsData)SerializationAndDeserialization
                            .DeserializationJsonEx(item.FullName, typeof(TitleCommentsData));
                        if(titleCommentsData!= null)
                        {
                            titleCommentsDatas.Add(titleCommentsData);
                        }
                    }
                }
                return titleCommentsDatas;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
                return null;
            }
        }

        public static TitleCommentsData GetTitleComments(string title)
        {
            try
            {
                var list = GetAllTitleCommentsData();
                if(list == null)
                {
                    return null;
                }
                foreach(var item in list)
                {
                    if(item.Title == title)
                    {
                        return item;
                    }
                }
                return null;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
                return null;
            }
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

        public static List<ScrapedOffClass> GetLatestEpisodesS(int limit)
        {
            try
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                List<ScrapedOffClass> scrapeds = new List<ScrapedOffClass>();
                string folderPath = AppFolders.ScrapedOff;
                var sortedFiles = new DirectoryInfo(folderPath).GetFiles()
                                                  .OrderBy(f => f.LastWriteTime)
                                                  .ToList();
                int x = 0;
                foreach (FileInfo file in sortedFiles)
                {
                    if (x == limit)
                    {
                        watch.Stop();
                        //LogManager.Log("Ładowanie najnowszych odcinków: " + watch.ElapsedMilliseconds.ToString() + "ms", "", "INFO", "M_0");
                        return scrapeds;
                    }
                    ScrapedOffClass scrapedOffClass = (ScrapedOffClass)
                        SerializationAndDeserialization.DeserializationJsonEx(file.FullName, typeof(ScrapedOffClass));
                    if (scrapedOffClass != null)
                    {
                        if (scrapeds.Count > 0)
                        {
                            List<string> strings = new List<string>();
                            foreach (var i in scrapeds)
                            {
                                strings.Add(i.TitleAnime);
                            }
                            if (!strings.Contains(scrapedOffClass.TitleAnime))
                            {
                                scrapeds.Add(scrapedOffClass);
                                x++;
                            }
                            strings = null;
                        }
                        else
                        {
                            scrapeds.Add(scrapedOffClass);
                            x++;
                        }
                    }
                }
                watch.Stop();
                //LogManager.Log("Ładowanie najnowszych odcinków: " + watch.ElapsedMilliseconds.ToString() + "ms", "", "INFO", "M_0");
                return scrapeds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }


        public static RootRelatedTitle GetRootRelatedTitleFromName(string name)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.RelatedTitle);
                foreach (var item in directoryInfo.GetFiles())
                {
                    if (item.FullName.EndsWith(".json"))
                    {
                        RootRelatedTitle rootRelatedTitle = (RootRelatedTitle)AnimePlayer.Core.SerializationAndDeserialization
                            .DeserializationJsonEx(item.FullName, typeof(RootRelatedTitle));
                        if (rootRelatedTitle != null)
                        {
                            if (rootRelatedTitle.RootTitle.ToUpper() == name.ToUpper())
                            {
                                return rootRelatedTitle;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }


        public static List<ScrapedOffClass> GetScrapedOffClass(int number, string title)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.ScrapedOff);
                List<ScrapedOffClass> list = new();

                title = Replacer.Names(title);
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    if (file == null)
                    {
                        Console.WriteLine("item is null");
                        break;
                    }
                    ScrapedOffClass s = null;
                    if (file.FullName.EndsWith(".json"))
                    {
                        Console.WriteLine("Json type file");
                        s = (ScrapedOffClass)AnimePlayer.Core.SerializationAndDeserialization.DeserializationJsonEx(file.FullName, typeof(ScrapedOffClass));
                    }

                    if (s != null)
                    {
                        if (s.Number.Replace("'", "") == number.ToString() &&
                            Replacer.Names(s.TitleAnime) == Replacer.Names(title))
                        {
                            Console.WriteLine("Add");
                            list.Add(s);
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetEpisode >");
                Console.WriteLine(ex.ToString());
                Debug.WriteLine(ex.ToString());
            }
            return null;
        }
    }
}
