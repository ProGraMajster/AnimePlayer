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
        public static class OneDrive
        {

            public static string onedriveUri(string link)
            {
                if(string.IsNullOrEmpty(link))
                {
                    return "null";
                }
                link = link.Replace("https://onedrive.live.com/download?cid=", "");
                return link;
            }

            public static bool MainFile()
            {
                try
                {
                    string link = "https://onedrive.live.com/download?cid=EA5053D1DC80D557&resid=EA5053D1DC80D557%21555&authkey=AI-xt2ueGPifUzo";
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(link, "main.txt");
                    webClient.Dispose();
                    return true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    //FileLog.Write(ex.ToString());
                    return false;
                }
            }

            public static void downloadFile(string link)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(link,
                        "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\" + onedriveUri(link) + ".txt");
                    webClient.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    //FileLog.Write(ex.ToString());
                }
            }

            public static void downloadFile(string link, string path)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(link, path);
                    webClient.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{ERROR}downloadPage > \n" + link + "\n" + path);
                    Console.WriteLine(ex.ToString() + Environment.NewLine);
                    //FileLog.Write(ex.ToString());
                }
            }

            public static string downloadPage(string link, string filename)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(onedriveUri(link), "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Page\\" + filename + ".txt");
                    webClient.Dispose();
                    return "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Page\\" + filename + ".txt";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{ERROR}downloadPage > \n" + link + "\n" + filename);
                    Console.WriteLine(ex.ToString() + Environment.NewLine);
                    return null;
                }
            }

            public static string downloadIcon(string link, string filename)
            {
                try
                {

                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(link, "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon\\" + filename.Replace(":", " ") + ".png");
                    webClient.Dispose();
                    return "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Icon\\" + filename.Replace(":", " ") + ".png";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("--------- downloadIcon ------");
                    Console.WriteLine("filename: " + filename);
                    Console.WriteLine("{ERROR}downloadPage > \n" + link + "\n" + filename);
                    Console.WriteLine(ex.ToString() + Environment.NewLine);
                    return null;
                }
            }

            public static string downloadVideoContent(string link, string filename)
            {
                try
                {
                    if (!Directory.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video"))
                    {
                        Directory.CreateDirectory("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video");
                    }
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(link, "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video\\" + filename + "_list_ep.txt");
                    webClient.Dispose();
                    return "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video\\" + filename + "_list_ep.txt";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{ERROR}downloadPage > \n" + link + "\n" + filename);
                    Console.WriteLine(ex.ToString() + Environment.NewLine);
                    return null;
                }
            }

        }

        public static class GoogleDrive
        {
            public static string dUri(string id)
            {
                id = "https://drive.google.com/uc?export=download&id=" + id;
                return id;
            }
        }

        public static bool File(string link, string path)
        {
            try
            {
                WebClient webClient = new WebClient();
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
