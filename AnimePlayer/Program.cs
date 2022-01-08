using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AnimePlayer
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                bool updates = false;
                foreach(string arg in Environment.GetCommandLineArgs())
                {
                    if(arg == "-Checking_update")
                    {
                        updates = true;
                    }
                }

                if(updates == false)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    StartProcess(Path.GetFullPath(Application.ExecutablePath), "-Checking_update");
                    Application.Run(new OknoG());
                }
                else
                {

                    try
                    {
                        bool update_available = false;
                        WebClient wb = new WebClient();
                        wb.DownloadFile(AnimePlayer.Properties.Settings.Default.UpdateLink_Version, "ver-lib.txt");
                        string[] version_txt = File.ReadAllText("ver-lib.txt").Split('.');
                        FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo("AnimePlayerLibrary.dll");
                        string fvi = myFileVersionInfo.FileMajorPart + "." + myFileVersionInfo.FileMinorPart + "." +
                            myFileVersionInfo.FileBuildPart + "." + myFileVersionInfo.FilePrivatePart;
                        string[] currentVersion = fvi.Split('.');

                        if (int.Parse(version_txt[0]) > int.Parse(currentVersion[0]))// 1
                        {
                            update_available = true;
                        }
                        else if (int.Parse(version_txt[0]) <= int.Parse(currentVersion[0])) //1
                        {
                            if (int.Parse(version_txt[1]) > int.Parse(currentVersion[1])) //2
                            {
                                update_available = true;
                            }
                            else if (int.Parse(version_txt[1]) <= int.Parse(currentVersion[1])) //2
                            {
                                if (int.Parse(version_txt[2]) > int.Parse(currentVersion[2]))//3
                                {
                                    update_available = true;
                                }
                                else if (int.Parse(version_txt[2]) <= int.Parse(currentVersion[2])) // 3
                                {
                                    if (int.Parse(version_txt[3]) > int.Parse(currentVersion[3]))//4 
                                    {
                                        update_available = true;
                                    }
                                    else
                                    {
                                        update_available = false;
                                    }
                                }
                            }
                        }

                        if (update_available == true)
                        {
                            wb = new WebClient();
                            wb.DownloadFile(AnimePlayer.Properties.Settings.Default.UpdateLink_File, "lib_link_download.txt");
                            string[] zm = File.ReadAllText("lib_link_download.txt").Split(';');
                            
                            if(File.Exists("AnimePlayerLibrary.dll"))
                            {
                                File.Move("AnimePlayerLibrary.dll", "AnimePlayerLibraryOld.dll");
                            }

                            wb = new WebClient();
                            wb.DownloadFile(zm[1], zm[0]);
                        }
                        File.Delete("ver-lib.txt");
                        File.Delete("lib_link_download.txt");
                        File.AppendAllText("logs.txt", "The library was successfully updated"+Environment.NewLine);
                        Environment.Exit(0);
                    }
                    catch (Exception ex2)
                    {
                        File.Delete("ver-lib.txt");
                        File.Delete("lib_link_download.txt");
                        Console.WriteLine(ex2.ToString());
                        File.AppendAllText("logs.txt", ex2.ToString() + Environment.NewLine+ Environment.NewLine);
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił krytyczny błąd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.IO.File.AppendAllText("CrashApplogs.txt", ex.ToString() + Environment.NewLine);
            }
        }

        public static void StartProcess(string pathTofile, string args)
        {
            try
            {
                File.AppendAllText("logs.txt",
                    "StartProcess >" + Environment.NewLine+ "pathTofile: " + pathTofile + Environment.NewLine + "args: "+ args + Environment.NewLine);
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = pathTofile;
                info.Arguments = args;
                info.UseShellExecute = true;
                Process.Start(info);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
