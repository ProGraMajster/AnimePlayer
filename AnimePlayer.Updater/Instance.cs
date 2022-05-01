using AnimePlayer.Class;
using System.Diagnostics;

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
        }

        List<string> list = new List<string>();

        private void ReadFileWithMainfestLinks()
        {
            foreach (string link in File.ReadAllLines(AppFolders.Updater+"updater_links_mainfest.tzt"))
            {
                list.Add(link);
            }
        }

    }
}