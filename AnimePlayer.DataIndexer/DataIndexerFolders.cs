using AnimePlayer.Class;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System;

namespace AnimePlayer.DataIndexer
{
    public class DataIndexerFolders
    {
        Process processDataIndexer;
        public readonly string Folder = AppFolders.AppFolder + "\\DataIndexer\\";

        public ContentIndex contentIndex;


        public void Start()
        {
            contentIndex = new ContentIndex();
            bool end = false;
            while(end)
            {
               // DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.Icons);
            }
        }

        public void StartProcess()
        {
            try
            {
                processDataIndexer = new Process();
                processDataIndexer.StartInfo.FileName = Application.ExecutablePath;
                processDataIndexer.StartInfo.UseShellExecute = true;
                processDataIndexer.Start();
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}