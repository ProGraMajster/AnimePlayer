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
using System.Threading;
using AnimePlayerLibrary;

namespace AnimePlayer
{
    public static class ContentManager
    {
        private static FormMainPlayer _formMainPlayer;
        public static void Start()
        {
            try
            {
                Updater.ContentUpdate.DownloadContent();
                ContentMove();
                Thread threadflowLayoutPanelAll = new(() =>
                {
                    foreach (PreviewTitleClass item in GetAllPreviewTitleClassFromFolder())
                    {
                        Panel panel = CreatePreviewPanelFromData(item);
                        _formMainPlayer.Invoke(() =>
                        {
                            _formMainPlayer.flowLayoutPanelAll.Controls.Add(panel);
                        });
                    }
                });
                threadflowLayoutPanelAll.Name = "threadflowLayoutPanelAll";
                threadflowLayoutPanelAll.Start();
                List<GroupClass> groups = GetGroups();
                foreach (GroupClass group in groups)
                {
                    Thread thread = new(() =>
                    {
                        CreateGroup(_formMainPlayer, group);
                    })
                    {
                        Name = "Thread_CreateGroup"
                    };
                    thread.Start();
                }

                Thread threadAllTitle = new(() =>
                {
                    GroupClass groupClass = new GroupClass();
                    groupClass.Name = "Wszystkie tytuły";
                    CreateGroup(_formMainPlayer, groupClass);
                });
                threadAllTitle.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
        public static void Initalize(FormMainPlayer formMainPlayer)
        {
            _formMainPlayer =formMainPlayer;
        }

        public static void LoadContentToForm()
        {
            try
            {
                Thread threadLoadContentToForm = new(() =>
                {
                    List<GroupClass> groups = GetGroups();
                    foreach (GroupClass group in groups)
                    {
                        Thread thread = new(() =>
                        {
                            CreateGroup(_formMainPlayer, group);
                        })
                        {
                            Name = "Thread_CreateGroup"
                        };
                        thread.Start();
                    }
                });
                threadLoadContentToForm.Name = "threadLoadContentToForm";
                threadLoadContentToForm.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public static bool CheckingItemSortFromString(string sortingtype, object obj)
        {
            try
            {
                if(obj == null)
                {
                    return false;
                }
                if(string.IsNullOrEmpty(sortingtype))
                {
                    return false;
                }
                if(sortingtype.StartsWith("DateOfIssue"))
                {
                    if(sortingtype.Contains(";"))
                    {
                        string s = sortingtype.Split(";")[1];
                        int val;
                        bool res = int.TryParse(s, out val);
                        if(res)
                        {
                            if(obj.GetType() == typeof(PageItemData))
                            {
                                PageItemData item = (PageItemData)obj;
                                if(!string.IsNullOrEmpty(item.TitleInformation.DateOfIssue))
                                {
                                    DateTime dateTime = DateTime.Parse(item.TitleInformation.DateOfIssue);
                                    if(dateTime.Year == val)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
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
            return false;
        }

        public static void CreateGroup(FormMainPlayer formMainPlayer, GroupClass groupClass)
        {
            try
            {
                List<PreviewTitleClass> previewTitlesInGroup = new List<PreviewTitleClass>();
                List<PreviewTitleClass> previewTitleClassesAll = GetAllPreviewTitleClassFromFolder();

                bool IN = false;
                if (groupClass.ItemNames != null)
                {
                    IN = true;
                    foreach (PreviewTitleClass item in previewTitleClassesAll)
                    {
                        if (groupClass.ItemNames.Contains(item.Title))
                        {
                            previewTitlesInGroup.Add(item);
                        }
                    }
                }

                foreach (PreviewTitleClass item in previewTitleClassesAll)
                {
                    PageItemData pageItemData = GetPageItemDataWithContentFolderFromTitle(item.Title);
                    if (string.IsNullOrEmpty(groupClass.GetFromSortingContent) && IN == false)
                    {
                        previewTitlesInGroup.Add(item);
                    }
                    else
                    {
                        if (CheckingItemSortFromString(groupClass.GetFromSortingContent, pageItemData))
                        {
                            previewTitlesInGroup.Add(item);
                        }
                    }
                }
/*
                foreach (PreviewTitleClass item in previewTitleClassesAll)
                {
                    PageItemData pageItemData = AnimePlayerLibrary.ContentManagerLibary.GetPageItemDataWithContentFolderFromTitle(item.Title);
                    if(string.IsNullOrEmpty(groupClass.GetFromSortingContent))
                    {
                        previewTitlesInGroup.Add(item);
                    }
                    else
                    {
                        if (CheckingItemSortFromString(groupClass.GetFromSortingContent, pageItemData))
                        {
                            previewTitlesInGroup.Add(item);
                        }
                    }
                }*/
                AnimePlayerLibrary.ItemsGroup itemsGroup = new AnimePlayerLibrary.ItemsGroup(groupClass);
                foreach(var item in previewTitlesInGroup)
                {
                    PanelItem panelItem = new PanelItem(item);
                    itemsGroup.layoutPanel.Controls.Add(panelItem.panelItem);
                }
                formMainPlayer.Invoke(() =>
                {
                    itemsGroup.Dock = DockStyle.Top;
                    itemsGroup.Show();
                    formMainPlayer.panelStartPage.Controls.Add(itemsGroup);
                    formMainPlayer.panelStartPage.Controls.SetChildIndex(itemsGroup, 0);
                });
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
            
        public static void ContentMove()
        {
            DirFilesMoveToDir(AppFolders.UpdatedPreviewItems, AppFolders.PreviewItems);
            DirFilesMoveToDir(AppFolders.UpdatedPagesItems, AppFolders.PagesItems);
            DirFilesMoveToDir(AppFolders.UpdatedVideosItems, AppFolders.VideosItems);
            DirFilesMoveToDir(AppFolders.UpdatedWeb, AppFolders.Web);
            DirFilesMoveToDir(AppFolders.UpdatedCommunity, AppFolders.Community);
            DirFilesMoveToDir(AppFolders.UpdatedTitleComments, AppFolders.TitleComments);
            DirFilesMoveToDir(AppFolders.UpdatedScrapedOff, AppFolders.ScrapedOff);
            DirFilesMoveToDir(AppFolders.UpdatedRelatedTitle, AppFolders.RelatedTitle);
            DirFilesMoveToDir(AppFolders.UpdatedEpisodesInformation, AppFolders.EpisodesInformation);
        }
         
        private static void DirFilesMoveToDir(string pathSource, string pathnewloocation)
        {
            if(Directory.Exists(pathnewloocation))
            {
                Directory.Delete(pathnewloocation, true);
                Directory.CreateDirectory(pathnewloocation);
            }
            else
            {
                Directory.CreateDirectory(pathnewloocation);
            }
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
            return AnimePlayerLibrary.ContentManagerLibary.GetPageItemDataWithContentFolderFromTitle(title);
            /*if(title == null)
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
                        if(Replacer.Names(title.ToLower()) == Replacer.Names(item.Name.ToLower()))
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
            return null;*/
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
                        Console.WriteLine(item.FullName);/*
                        PreviewTitleClass previewTitleClass = (PreviewTitleClass)SerializationAndDeserialization.Deserialization(item.FullName);
                       list.Add(previewTitleClass);*/
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

        public static List<GroupClass> GetGroups()
        {
            try
            {
                List<GroupClass> list = new();
                DirectoryInfo directoryInfo = new(AppFolders.UpdatedItemGroups);
                foreach(FileInfo fileInfo in directoryInfo.GetFiles())
                {
                    if (fileInfo.FullName.EndsWith(".json"))
                    {
                        /*GroupClass groupClass = (GroupClass)Core.SerializationAndDeserialization
                            .Deserialization(fileInfo.FullName);*/
                        GroupClass groupClass = (GroupClass)SerializationAndDeserialization
                            .DeserializationJsonEx(fileInfo.FullName, typeof(GroupClass));
                        list.Add(groupClass);
                    }
                }
                return list;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
            return null;
        }

        public static EpisodesInformation GetEpisodesInformationFormTitle(string title)
        {
            try
            {
                if (string.IsNullOrEmpty(title))
                {
                    return null;
                }
                title = Replacer.Names(title);
                DirectoryInfo directoryInfo = new(AppFolders.EpisodesInformation);
                foreach (var item in directoryInfo.GetFiles())
                {
                    EpisodesInformation episodesInformation = null;
                    if (item.FullName.EndsWith(".json"))
                    {
                        episodesInformation = (EpisodesInformation)
                            SerializationAndDeserialization
                            .DeserializationJsonEx(item.FullName, typeof(EpisodesInformation));
                    }
                    if (episodesInformation != null)
                    {
                        if (Replacer.Names(title) == Replacer.Names(episodesInformation.AnimeTitle))
                        {
                            return episodesInformation;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            return null;
        }

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
                foreach (FileInfo file in directoryInfo.GetFiles().ToList())
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
