using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer
{
    public partial class FormStarter : Form
    {
        ZetaIpc.Runtime.Server.IpcServer ipcServerMain;
        ZetaIpc.Runtime.Client.IpcClient ipcClientMain;
        Process processApp;
        Process processUpdater;
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
                text = "";
                DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath);
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
        }

        private void IpcServer_ReceivedRequest(object sender, ZetaIpc.Runtime.Server.ReceivedRequestEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panelSettings.Show();
        }

        private void buttonCloseSettings_Click(object sender, EventArgs e)
        {
            panelSettings.Hide();
            panel1.Show();
        }

        private void buttonRunApp_Click(object sender, EventArgs e)
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
            processApp.StartInfo.Arguments = arg;
            processApp.EnableRaisingEvents = true;
            processApp.Exited += ProcessApp_Exited;
            processApp.Start();
            processApp.WaitForInputIdle();
            Application.DoEvents();
            if (checkBoxOtherWindow.Checked)
            {
                FormAppWindow _ = new FormAppWindow() { MinimumSize = new Size(1106, 629) };
                _.Tag = processApp;
                _.IsMdiContainer = true;
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
                DLLApi.SetWindowLong(processApp.MainWindowHandle, DLLApi.GWL_STYLE, DLLApi.WS_VISIBLE);
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

        private void buttonCheckUpdate_Click(object sender, EventArgs e)
        {

        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }
    }
}
