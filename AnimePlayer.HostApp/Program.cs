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

                foreach(string a in Environment.GetCommandLineArgs())
                {
                    if(a == "-checking_for_updates")
                    {
                        updates = true;
                    }
                }

                if(updates)
                {
                    Environment.Exit(0);
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
                System.IO.File.AppendAllText("CrashApplogs.txt", ex.ToString() + Environment.NewLine);
            }
        }
    }
}
