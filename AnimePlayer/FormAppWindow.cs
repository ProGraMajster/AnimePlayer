using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AnimePlayer
{
    public partial class FormAppWindow : Form
    {
        public FormAppWindow()
        {
            InitializeComponent();
        }

        void CloseWindow(IntPtr hwnd)
        {
           DLLApi.SendMessage(hwnd, DLLApi.WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = (Process)this.Tag;
                CloseWindow(p.MainWindowHandle);
            }
            catch (Exception ex)
            {

            }
            this.Close();
        }

        private void ButtonMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                buttonMax.Text = "[^]";
                return;
            }

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                buttonMax.Text = "[ ]";
                return;
            }
            DLLApi.MoveWindow(MainWindowHandle, 1, 1, panelContent.Width - 2, panelContent.Height - 2, true);
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void PanelNavigation_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void PanelNavigation_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panelNavigation_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        public IntPtr MainWindowHandle;

        private void FormAppWindow_Resize(object sender, EventArgs e)
        {
            panelWindowMenu.Location = new Point(buttonOptions.Left - panelWindowMenu.Width, buttonOptions.Top);
            if (MainWindowHandle != IntPtr.Zero)
            {
               DLLApi.MoveWindow(MainWindowHandle, 1, 1, panelContent.Width - 2, panelContent.Height - 2, true);
            }
        }

        private void FormAppWindow_SizeChanged(object sender, EventArgs e)
        {
            if (MainWindowHandle != IntPtr.Zero)
            {
                DLLApi.MoveWindow(MainWindowHandle, 1, 1, panelContent.Width - 2, panelContent.Height - 2, true);
            }
        }

        int Mx;
        int My;
        int Sw;
        int Sh;

        bool mov;

        private void PanelLeftBottom_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        private void PanelLeftBottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        private void PanelLeftBottom_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void PanelNavigation_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                buttonMax.Text = "[^]";
                return;
            }

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                buttonMax.Text = "[ ]";
                return;
            }
        }

        private void FormAppWindow_TextChanged(object sender, EventArgs e)
        {
            labelWindowText.Text = this.Text;
        }

        private void CheckBoxTopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost= checkBoxTopMost.Checked;
        }

        private void ButtonHideMenu_Click(object sender, EventArgs e)
        {
            panelWindowMenu.Hide();
        }

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            panelWindowMenu.Location = new Point(buttonOptions.Left - panelWindowMenu.Width, buttonOptions.Top);
            panelWindowMenu.Show();
            panelWindowMenu.BringToFront();
        }

        private void ButtonContentReload_Click(object sender, EventArgs e)
        {
            Process processApp = (Process)this.Tag;

            Thread.Sleep(500);
            DLLApi.SetWindowPos(processApp.MainWindowHandle, processApp.MainWindowHandle, 0, 0, 300, 300, 0x0080000);
            DLLApi.SetParent(processApp.MainWindowHandle, panelContent.Handle);
            Thread.Sleep(50);
            DLLApi.SetParent(processApp.MainWindowHandle, panelContent.Handle);
            Thread.Sleep(50);
            DLLApi.SetParent(processApp.MainWindowHandle, panelContent.Handle);
            Thread.Sleep(50);
            DLLApi.SetParent(processApp.MainWindowHandle, panelContent.Handle);
            Thread.Sleep(50);
            DLLApi.MoveWindow(processApp.MainWindowHandle, 0, 0, panelContent.Width, panelContent.Height, true);
            CenterToScreen();
            DLLApi.MoveWindow(processApp.MainWindowHandle, 1, 1, panelContent.Width, panelContent.Height, true);
            //childForm.WindowState = FormWindowState.Normal;
            DLLApi.SetWindowLong(processApp.MainWindowHandle, DLLApi.GWL_STYLE, DLLApi.WS_VISIBLE);
            MainWindowHandle = processApp.MainWindowHandle;
            Text = processApp.MainWindowTitle;
            Icon = DLLApi.GetAppIcon(processApp.MainWindowHandle);
            pictureBoxIcon.Image = Icon.ToBitmap();
            if (DLLApi.GetWindowRect(new HandleRef(processApp, processApp.MainWindowHandle), out DLLApi.RECT rect))
            {
                //To do anything  
                int width = rect.Right -rect.Left;
                int height = rect.Bottom;
                Size = new Size(width, height);
            }
        }
    }
}