using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayerLibrary
{
    public static class Download
    {
        public static bool File(string link, string path)
        {
            try
            {
                WebClient webClient = new();
                webClient.DownloadFile(link, path);
                webClient.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
