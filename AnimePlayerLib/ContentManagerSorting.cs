using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AnimePlayer.Class;
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
    }
}
