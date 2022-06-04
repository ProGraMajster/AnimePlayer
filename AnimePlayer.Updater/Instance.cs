using AnimePlayer.Class;
using System.Diagnostics;
using System.IO.Compression;
using System.Net;

namespace AnimePlayer.Updater
{
    public class Instance
    {
        public void Start()
        {
            FileStream filestream = new FileStream(AnimePlayer.Class.AppFolders.Logs+"\\"+ Process.GetCurrentProcess().StartTime.ToString().Replace(":", " ") + "_updater.txt", FileMode.Append);
            var streamwriter = new StreamWriter(filestream);
            streamwriter.AutoFlush = true;
            Console.SetOut(streamwriter);
            Console.SetError(streamwriter);
            DownloadMainFestFile();
            MainFeststFilesInFolders();
        }

        public void DownloadMainFestFile()
        {
            try
            {
                int number = 0;
                foreach(var link in LinksToMainfest.Links.ToArray())
                {
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile(link, "updater_links_mainfest_"+number+".tzt");
                        webClient.Dispose();
                    }
                    catch(Exception exDownload)
                    {
                        Console.Error.WriteLine(exDownload.ToString());
                    }
                    number+=1;
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public void MainFeststFilesInFolders()
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.Updater);

                foreach(var file in directoryInfo.GetFiles())
                {
                    ReadFileWithMainfestLinks(file.FullName);
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        List<string> list = new List<string>();

        private void ReadFileWithMainfestLinks(string path)
        {
            foreach (string link in File.ReadAllLines(path))
            {
                list.Add(link);
            }
        }
    }
}