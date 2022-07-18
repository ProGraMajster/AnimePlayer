using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimePlayerLibrary;
using AnimePlayer.Class;
using System.IO;
using System.Windows.Forms;

namespace AnimePlayer.Updater
{
    public static class ContentUpdate
    {
        public static readonly string LinkToContent = @"https://github.com/ProGraMajster/AnimePlayer.Content/archive/refs/heads/master.zip";

        public static void DownloadContent()
        {
            try
            {
                Console.WriteLine("DownloadContet > DownloadFile");
                Console.WriteLine("Link:"+LinkToContent);
                Console.WriteLine("path:"+AppFolders.Updater+"content.zip");
                Download.File(LinkToContent, AppFolders.Updater+"content.zip");
                Unpack();
            }
            catch(FileNotFoundException fnfe)
            {
                Console.Error.WriteLine(fnfe.ToString());
                DialogResult dialogResult = MessageBox.Show(fnfe.Message+"\n Spróbować ponownie pobrać zawartość?", "Błąd", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(dialogResult == DialogResult.Yes)
                {
                    DownloadContent();
                    return;
                }
                return;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private static void Unpack()
        {
            try
            {
                if (!File.Exists(AppFolders.Updater+"content.zip"))
                {
                    new FileNotFoundException();
                }
                if(Directory.Exists(AppFolders.UpdatedContentFolder))
                {
                    Directory.Delete(AppFolders.UpdatedContentFolder, true);
                    Directory.CreateDirectory(AppFolders.UpdatedContentFolder); 
                }
                System.IO.Compression.ZipFile.ExtractToDirectory(AppFolders.Updater+"content.zip", AppFolders.UpdatedContentFolder);
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
