using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AnimePlayer.HostApp
{
    static class Program
    {
        /// <summary>
        /// G³ówny punkt wejœcia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                bool updates = false;
                bool download = false;
                string donwloadDll_link = null;
                string donwloadDll_fileLink = null;
                string dllname=null;
                bool skiperrorMessagebox = false;

                foreach(string a in Environment.GetCommandLineArgs())
                {
                    if(a == "-checking_for_updates")
                    {
                        updates = true;
                        AnimePlayerLibrary.FileLog.Write("Process flag: -checking_for_updates");
                    }
                    else if(a.StartsWith("-DLL"))
                    {
                        AnimePlayerLibrary.FileLog.Write("Process flag: "+a);
                        dllname = a.Split(';')[1];
                        download = true;
                        donwloadDll_link = a.Split(";")[3];
                    }
                }

                if(updates)
                {
                    AnimePlayerLibrary.FileLog.Write("updates>");
                    AnimePlayerLibrary.FileLog.Write("DownloadFile");
                    AnimePlayerLibrary.Download.File(AnimePlayerLibrary.LinkDownload.link, AnimePlayerLibrary.DefaultAppDir.Temp + "ver.txt");
                    string[] code = File.ReadAllText(AnimePlayerLibrary.DefaultAppDir.Temp + "ver.txt").Split(';');
                    int limits = 0;
                    for (int i = 0; i < code.Length; i++)
                    {
                        limits = i;
                        code[i] = code[i].Replace("\n", "").Replace("\r", "").Replace("\t", "");
                    }
                    AnimePlayerLibrary.FileLog.Write("Open file:"+ AnimePlayerLibrary.DefaultAppDir.Temp + "ver.txt");
                    bool end = false;
                    int position = 0;
                    while (end != true)
                    {
                        if (position == limits)
                        {
                            end = true;
                        }

                        if (code[position] == "MainModule")
                        {
                            AnimePlayerLibrary.FileLog.Write("MainModule");
                            position++;
                            string[] n_strver = code[position].Split('.');
                            AnimePlayerLibrary.FileLog.Write("n_server:"+code[position]);
                            position++;
                            AnimePlayerLibrary.FileLog.Write("dlink"+code[position]);
                            string dlink = code[position];
                            File.WriteAllText("tempFileLink.txt", dlink);
                            FileVersionInfo file = FileVersionInfo.GetVersionInfo("AnimePlayerLibrary.dll");
                            int[] c_version = new int[] { file.FileMajorPart, file.FileMinorPart, file.FileBuildPart, file.FilePrivatePart };
                            int[] n_ver = new int[] { int.Parse(n_strver[0]), int.Parse(n_strver[1]), int.Parse(n_strver[2]), int.Parse(n_strver[3])};
                            bool d = false;
                            AnimePlayerLibrary.FileLog.Write("c_version "+c_version[0]+"."+c_version[1]+"."+c_version[2]+"."+c_version[3]);
                            if (n_ver[0] > c_version[0])
                            {
                                d = true;
                                AnimePlayerLibrary.FileLog.Write("if_0 = true");
                            }
                            else
                            {
                                if (n_ver[1] > c_version[1])
                                {
                                    d = true;
                                    AnimePlayerLibrary.FileLog.Write("if_1 = true");
                                }
                                else
                                {
                                    if (n_ver[2] > c_version[2])
                                    {
                                        d = true;
                                        AnimePlayerLibrary.FileLog.Write("if_2 = true");
                                    }
                                    else
                                    {
                                        if (n_ver[3] > c_version[3])
                                        {
                                            d = true;
                                            AnimePlayerLibrary.FileLog.Write("if_3 = true");
                                        }
                                    }
                                }
                            }
                            if(d)
                            {
                                AnimePlayerLibrary.FileLog.Write("update = true\n file move AnimePlayerLibrary.dll to AnimePlayerLibraryOld.dll");
                                try
                                {
                                    File.Move("AnimePlayerLibrary.dll", "AnimePlayerLibraryOld.dll");
                                }
                                catch(Exception exMove)
                                {
                                    Environment.Exit(0);
                                }
                                AnimePlayerLibrary.FileLog.Write("Process info create");
                                ProcessStartInfo psi = new ProcessStartInfo();
                                psi.FileName = Application.ExecutablePath;
                                psi.UseShellExecute = true;
                                psi.Arguments = "-DLL_name;AnimePlayerLibrary.dll;-downloadDLLwithsLinkFile;tempFileLink.txt";
                                AnimePlayerLibrary.FileLog.Write("Start");
                                bool s = false;
                                Process.Start(psi);
                                AnimePlayerLibrary.FileLog.Write("infoprocess:\n"+psi.FileName +"\n"+psi.Arguments);
                            }
                        }
                        position++;
                    }
                }
                else if(download)
                {
                    donwloadDll_fileLink = File.ReadAllText("tempFileLink.txt");
                    AnimePlayerLibrary.Download.File(donwloadDll_link, dllname);
                    File.WriteAllText("Update.txt", "1");
                }
                else
                {
                    try
                    {
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = Application.ExecutablePath;
                        psi.Arguments = "-checking_for_updates";
                        //Process.Start(psi);
                    }
                    catch (Exception exProc)
                    {
                        Console.WriteLine(exProc.ToString());
                    }
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormStarter());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wyst¹pi³ krytyczny b³¹d", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.IO.File.WriteAllText("CrashAppRaport.txt", ex.ToString() + Environment.NewLine);
            }
        }
    }
}
