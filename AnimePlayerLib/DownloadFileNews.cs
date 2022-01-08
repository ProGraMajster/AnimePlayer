using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimePlayerLibrary
{
    public static class DownloadFileNews
    {
        public static string GetPathListNews()
        {
            return @"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\News\listNews.txt";
        }

        public static bool DownloadWithOneDrive()
        {
            string link = "https://onedrive.live.com/download?cid=EA5053D1DC80D557&resid=EA5053D1DC80D557%21564&authkey=ABKI4J-thwvx6nI";
            try
            {
                if (!Directory.Exists(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\News"))
                {
                    Directory.CreateDirectory(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\News");
                }

                WebClient webClient = new WebClient();
                webClient.DownloadFile(link, @"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\News\listNews.txt");
                webClient.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static bool DownloadWithGdrive()
        {
            try
            {
                if(!Directory.Exists(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\News"))
                {
                    Directory.CreateDirectory(@"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\News");
                }

                WebClient webClient = new WebClient();
                webClient.DownloadFile(Download.GoogleDrive.dUri("1izvflPLxIWyW4doIdY160Swd0ehxHcxB"), @"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\News\listNews.txt");
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
