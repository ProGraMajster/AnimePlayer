using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    public partial class BrowserTabPageItem : UserControl
    {
        private class RoundingControl : Component
        {
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            public static extern IntPtr CreateRoundRectRgn
                (
                   int nLeftRect,
                   int nTopRect,
                   int nRightRect,
                   int nBottomRect,
                   int nWidthEllipse,
                   int nHeightEllipse
                );
            private Control _cntrl;
            private int _CornerRadius = 30;

            public Control TargetControl
            {
                get { return _cntrl; }
                set
                {
                    _cntrl = value;
                    _cntrl.SizeChanged += (sender, eventArgs) => _cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, _cntrl.Width, _cntrl.Height, _CornerRadius, _CornerRadius));
                }
            }

            public int CornerRadius
            {
                get { return _CornerRadius; }
                set
                {
                    _CornerRadius = value;
                    if (_cntrl != null)
                        _cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, _cntrl.Width, _cntrl.Height, _CornerRadius, _CornerRadius));
                }
            }
        }

        public BrowserTabPageItem()
        {
            InitializeComponent();
        }

        public bool UseCornerRadius = true;

        private void labelItemTitle_Click(object sender, EventArgs e)
        {
            ShowPage();
        }

        public void ShowPage()
        {
            try
            {
                Control controlPage = (Control)this.Tag;
                Control controlParent = this.ParentForm.Controls.Find("panelContent", true)[0];
                controlParent.Controls.Add(controlPage);
                controlPage.Dock = DockStyle.Fill;
                controlPage.Show();
                controlPage.BringToFront();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonCloseItem_Click(object sender, EventArgs e)
        {
            CloseBrowserTabPageItem();
        }

        private void pictureBoxItemIcon_Click(object sender, EventArgs e)
        {
            ShowPage();
        }

        public void CloseBrowserTabPageItem()
        {
            try
            {
                Control control = (Control)this.Tag;
                control.Hide();
                control.Dispose();
                this.Hide();
                this.Dispose();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void BrowserTabPageItem_Load(object sender, EventArgs e)
        {
            ShowPage();
        }

        private void BrowserTabPageItem_Resize(object sender, EventArgs e)
        {

        }
    }
}
