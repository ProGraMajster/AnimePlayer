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
                string dllname=null;

                foreach(string a in Environment.GetCommandLineArgs())
                {
                    if(a == "-checking_for_updates")
                    {
                        updates = true;
                    }
                    else if(a.StartsWith("-DLL_name;"))
                    {
                        dllname = a.Split(';')[1];
                        download = true;
                        donwloadDll_link = a.Split(";")[3];
                    }
                }

                if(updates)
                {
                    AnimePlayerLibrary.Download.File(AnimePlayerLibrary.LinkDownload.link, AnimePlayerLibrary.DefaultAppDir.Temp + "ver.txt");
                    string[] code = File.ReadAllText(AnimePlayerLibrary.DefaultAppDir.Temp + "ver.txt").Split(';');
                    int limits = 0;
                    for (int i = 0; i < code.Length; i++)
                    {
                        limits = i;
                        code[i] = code[i].Replace("\n", "").Replace("\r", "").Replace("\t", "");
                    }

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
                            position++;
                            string[] n_strver = code[position].Split('.');
                            position++;
                            string dlink = code[position];
                            FileVersionInfo file = FileVersionInfo.GetVersionInfo("AnimePlayerLibrary.dll");
                            int[] c_version = new int[] { file.FileMajorPart, file.FileMinorPart, file.FileBuildPart, file.FilePrivatePart };
                            int[] n_ver = new int[] { int.Parse(n_strver[0]), int.Parse(n_strver[1]), int.Parse(n_strver[2]), int.Parse(n_strver[3])};
                            bool d = false;
                            if(n_ver[0] > c_version[0])
                            {
                                d = true;
                            }
                            else
                            {
                                if (n_ver[1] > c_version[1])
                                {
                                    d = true;
                                }
                                else
                                {
                                    if (n_ver[2] > c_version[2])
                                    {
                                        d = true;
                                    }
                                    else
                                    {
                                        if (n_ver[2] > c_version[2])
                                        {
                                            d = true;
                                        }
                                    }
                                }
                            }
                            if(d)
                            {
                                File.Move("AnimePlayerLibrary.dll", "AnimePlayerLibrarybOld.dll");
                                ProcessStartInfo psi = new ProcessStartInfo();
                                psi.FileName = Application.ExecutablePath;
                                psi.Arguments = "-DLL_name;AnimePlayerLibrary.dll;-downloadDLL;" + dlink;
                                Process.Start(psi);
                            }
                        }
                        position++;
                    }
                }
                else if(download)
                {
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
                        Process.Start(psi);
                    }
                    catch (Exception exProc)
                    {
                        Console.WriteLine(exProc.ToString());
                    }
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new OknoG());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wyst¹pi³ krytyczny b³¹d", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.IO.File.WriteAllText("CrashApplogs.txt", ex.ToString() + Environment.NewLine);
            }
        }
    }
}
