using AnimePlayer.Class;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayerLibrary
{
    public static class SearchingForContent
    {
        public class Filters
        {
            /// <summary>
            /// If there is a phrase in the title of the anime
            /// </summary>
            public string IfItContains { get; set; }
            public string OnlyText { get; set; }
            public string MayNotContainText { get; set; }
            public string Sorting { get; set; }
            public List<string> OtherItMustContain { get; set; }
            public List<string> Exclude { get; set; }
        }
        public static List<PreviewTitleClass> Search(Filters filters)
        {
            List<PreviewTitleClass> list = new List<PreviewTitleClass>();
            try
            {
                list = ContentManagerLibary.GetAllPreviewTitleClassFromFolder();
                if(filters == null)
                {
                    return list;
                }
                list = Filter(list, filters);
                return list;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
                Console.WriteLine(ex.ToString());
            }
            return null;
        }
        private static List<PreviewTitleClass> Filter(List<PreviewTitleClass> previewTitleClasses, Filters filters)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        private static List<PreviewTitleClass> Sorting(List<PreviewTitleClass> previewTitleClasses)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        
    }
}
