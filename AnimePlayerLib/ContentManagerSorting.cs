using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AnimePlayer.Class;
using AnimePlayer.Core;
using AnimePlayerLibrary.UI;

namespace AnimePlayerLibrary
{
    public static class ContentManagerSorting
    {
        public static PanelItem[] GetPanelSortByDate(bool revarse)
        {
            try
            {
                List<PreviewTitleClass> previews = ContentManagerLibary.GetAllPreviewTitleClassFromFolder();
                List<PanelItem> panelItems = new List<PanelItem>();
                foreach (PreviewTitleClass item in previews)
                {
                    panelItems.Add(new PanelItem(item));
                }

                panelItems.Sort((x, y) =>
                {
                    return DateTime.Compare(DateTime.Parse(new PageItem(x).pageItemData.TitleInformation.DateOfIssue)
                                        , DateTime.Parse(new PageItem(x).pageItemData.TitleInformation.DateOfIssue));
                });

                if(revarse)
                {
                    panelItems.Reverse();
                    return panelItems.ToArray();
                }
                else
                {
                    return panelItems.ToArray();
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
            return null;
        }

        public static PanelItem[] GetPanelSortByCountEpisode(bool revarse)
        {
            try
            {
                List<PreviewTitleClass> previews = ContentManagerLibary.GetAllPreviewTitleClassFromFolder();
                List<PanelItem> panelItems = new List<PanelItem>();

                foreach (PreviewTitleClass item in previews)
                {
                    panelItems.Add(new PanelItem(item));
                }

                if (revarse)
                {
                    panelItems.Reverse();
                    return panelItems.ToArray();
                }
                else
                {
                    return panelItems.ToArray();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        public static PreviewTitleClass[] GetAllWithContains(string text)
        {
            List<PreviewTitleClass> previewTitleClasses= new List<PreviewTitleClass>();
            string pathToDir = AppFolders.PreviewItems.TrimEnd('\\');
            if (!Directory.Exists(pathToDir))
            {
                Console.WriteLine($"{pathToDir} does not exist.");
                return null;
            }

            DirectoryInfo directory= new DirectoryInfo(pathToDir);
            foreach(FileInfo fileInfo in directory.GetFiles())
            {
                if(fileInfo.Exists)
                {
                    PreviewTitleClass previewTitleClass = (PreviewTitleClass)SerializationAndDeserialization
                        .Deserialization(fileInfo.FullName);
                    if(previewTitleClass.Title.Contains(text))
                    {
                        previewTitleClasses.Add(previewTitleClass);
                    }
                }
            }
            return previewTitleClasses.ToArray();
        }
    }
}
