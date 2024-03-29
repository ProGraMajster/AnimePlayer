﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePlayer.Class;

namespace AnimePlayer
{
    public partial class FormStarter : Form
    {
        readonly ZetaIpc.Runtime.Server.IpcServer ipcServerMain;
        readonly ZetaIpc.Runtime.Client.IpcClient ipcClientMain;
        Process processApp;
        Process processUpdater;
        public bool updated = false;

        public FormStarter()
        {
            InitializeComponent();
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
            string text = "";
            try
            {
                ipcServerMain = new ZetaIpc.Runtime.Server.IpcServer();
                ipcServerMain.Start(2138);
                ipcServerMain.ReceivedRequest += IpcServer_ReceivedRequest;
                ipcClientMain = new ZetaIpc.Runtime.Client.IpcClient();
                ipcClientMain.Initialize(2139);
                if (Environment.CommandLine.Contains("-debug"))
                {
                    checkBoxDebug.Checked = true;
                }
                if (Environment.CommandLine.Contains("-local"))
                {
                    checkBoxLocal.Checked = true;
                }
                if (Environment.CommandLine.Contains("-offline"))
                {
                    checkBoxOffline.Checked = true;
                }
                if(Environment.CommandLine.Contains("-updated"))
                {
                    updated=true;
                }
                text = "";
                DirectoryInfo directoryInfo = new(Application.StartupPath);
                foreach (var file in directoryInfo.GetFiles())
                {
                    if (file.FullName.EndsWith(".dll"))
                    {
                        FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(file.FullName);
                        text += myFileVersionInfo.ProductName +" v"+myFileVersionInfo.FileVersion +"\n";
                    }
                }
                labelVersion.Text = text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            this.Hide();
        }

        private void IpcServer_ReceivedRequest(object sender, ZetaIpc.Runtime.Server.ReceivedRequestEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if(processUpdater != null)
            {
                processUpdater.Kill();
            }
            Application.Exit();
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panelSettings.Show();
        }

        private void ButtonCloseSettings_Click(object sender, EventArgs e)
        {
            panelSettings.Hide();
            panel1.Show();
        }

        private void ButtonRunApp_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            labelLoadingApp.Left = (this.Width - labelLoadingApp.Width) / 2;
            labelLoadingApp.Top = (this.Height - labelLoadingApp.Height) / 2;
            labelLoadingApp.Show();
            labelLoadingApp.BringToFront();
            Application.DoEvents();
            processApp = new Process();
            processApp.StartInfo.FileName = Application.ExecutablePath;
            processApp.StartInfo.UseShellExecute = true;
            string arg = "";
            if(checkBoxDebug.Checked)
            {
                arg += "-debug ";
            }
            if(checkBoxLocal.Checked)
            {
                arg += "-local ";
            }
            if(checkBoxOffline.Checked)
            {
                arg += "-offline ";
            }
            arg += "-OpenApp";
            arg+=" "+textBoxArgs.Text;
            processApp.StartInfo.Arguments = arg;
            processApp.EnableRaisingEvents = true;
            processApp.Exited += ProcessApp_Exited;
            processApp.Start();
            processApp.WaitForInputIdle();
            Application.DoEvents();
            if (checkBoxOtherWindow.Checked)
            {
                FormAppWindow _ = new()
                {
                    MinimumSize = new Size(1106, 629),
                    Tag = processApp,
                    IsMdiContainer = true
                };
                _.Show();
                Thread.Sleep(500);
                DLLApi.SetWindowPos(processApp.MainWindowHandle, processApp.MainWindowHandle, 0, 0, 300, 300, 0x0080000);
                DLLApi.SetParent(processApp.MainWindowHandle, _.panelContent.Handle);
                DLLApi.SetParent(processApp.MainWindowHandle, _.panelContent.Handle);
                DLLApi.SetParent(processApp.MainWindowHandle, _.panelContent.Handle);
                DLLApi.SetParent(processApp.MainWindowHandle, _.panelContent.Handle);
                DLLApi.MoveWindow(processApp.MainWindowHandle, 0, 0, _.panelContent.Width, _.panelContent.Height, true);
                CenterToScreen();
                DLLApi.MoveWindow(processApp.MainWindowHandle, 1, 1, _.panelContent.Width, _.panelContent.Height, true);
                //childForm.WindowState = FormWindowState.Normal;
#pragma warning disable CA1806 // Nie ignoruj wyników metody
                DLLApi.SetWindowLong(processApp.MainWindowHandle, DLLApi.GWL_STYLE, DLLApi.WS_VISIBLE);
#pragma warning restore CA1806 // Nie ignoruj wyników metody
                _.MainWindowHandle = processApp.MainWindowHandle;
                _.Text = processApp.MainWindowTitle;
                _.Icon = DLLApi.GetAppIcon(processApp.MainWindowHandle);
                _.pictureBoxIcon.Image = _.Icon.ToBitmap();
                if (DLLApi.GetWindowRect(new HandleRef(processApp, processApp.MainWindowHandle), out DLLApi.RECT rect))
                {
                    //To do anything  
                    int width = rect.Right -rect.Left;
                    int height = rect.Bottom;
                    _.Size = new Size(width, height);
                }
            }
            Application.DoEvents();
            this.Hide();
        }

        private void ProcessApp_Exited(object sender, EventArgs e)
        {
            this.Invoke(() => { this.Show(); this.Activate(); this.Focus(); labelLoadingApp.Hide(); panel1.Show(); });
        }

        private void ButtonCheckUpdate_Click(object sender, EventArgs e)
        {

        }

        private void LabelVersion_Click(object sender, EventArgs e)
        {

        }

        private void FormStarter_Load(object sender, EventArgs e)
        {
            if(!updated)
            {
                timer1.Start();
                processUpdater = new Process();
                processUpdater.StartInfo.FileName = Application.ExecutablePath;
                processUpdater.StartInfo.UseShellExecute = true;
                processUpdater.StartInfo.Arguments = "-Updater";
                processUpdater.Start();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                if (File.Exists(AppFolders.Updater+"update"))
                {
                    string text = File.ReadAllText(AppFolders.Updater+"update");
                    if (text == "1")
                    {
                        if (processApp != null)
                        {
                            processApp.Kill();
                        }

                        if (processUpdater != null)
                        {
                            processUpdater.Kill();
                        }
                        File.Delete(AppFolders.Updater+"update");
                        System.Diagnostics.Process.Start(Application.ExecutablePath,"-updated");
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void FormStarter_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (processApp != null)
                {
                    processApp.Kill();
                }

                if (processUpdater != null)
                {
                    processUpdater.Kill();
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void CheckBoxef_CheckedChanged(object sender, EventArgs e)
        {
            buttonBrowser.Visible = checkBoxef.Checked;
        }

        private void ButtonBrowser_Click(object sender, EventArgs e)
        {
            FormBrowser formBrowser = new(false);
            formBrowser.ShowDialog();
        }
    }
}
