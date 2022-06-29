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
                Download.File(link, @"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\News\listNews.txt");
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
                Download.File(Download.GoogleDrive.dUri("1izvflPLxIWyW4doIdY160Swd0ehxHcxB"), @"C:\ContentLibrarys\OtherFiles\WMP_OverlayApp\News\listNews.txt");
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
