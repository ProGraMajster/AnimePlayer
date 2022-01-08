using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace AnimePlayerLibrary
{
    //New Super class WebContentv2
    public static class WebContentV2
    {
        [Serializable]
        public class StartItemValues
        {
            public string Title { get; set; }
            public string LinkPage { get; set; }
            public string PathPage { get; set; }
            public string LinkIcon { get; set; }
            public string[] AlternativeLinkPage { get; set; }
            public string[] AlternativeLinkIcon { get; set; }
        }
        [Serializable]
        public class SkipOpAndEd
        {
            public string ShowdylsssOpButtonTime { get; set; }
            public string HideOpButtonTime { get; set; }
            public string SkipOpTime { get; set; }

            public string ShowEdButtonTime { get; set; }
            public string HideEdButtonTime { get; set; }
            public string SkipEdTime { get; set; }

        }

        public static class V2_Download
        {
            public  static (bool, string) Download(string link, string pathSaveFile)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(link, pathSaveFile);
                    webClient.Dispose();
                    return (true, pathSaveFile);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{ERROR}downloadPage > \n" + link + "\n" + pathSaveFile);
                    Console.WriteLine(ex.ToString() + Environment.NewLine);
                    return (false, ex.Message);
                }
            }
        }

        public static class MovieFile
        {

        }
    }
}
