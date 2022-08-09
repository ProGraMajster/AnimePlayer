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
    public partial class BrowserTabPageHomePage : UserControl
    {
        public BrowserTabPageHomePage()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            _ = new RoundingControl()
            {
                TargetControl = textBoxMain,
                CornerRadius = 15
            };
            _ = new RoundingControl()
            {
                TargetControl = buttonFindInInternet,
                CornerRadius = 15
            };
            _ = new RoundingControl
            {
                TargetControl = buttonFindInApp,
                CornerRadius = 15
            };
            _ = new RoundingControl
            {
                TargetControl = comboBox1,
                CornerRadius = 15
            };
            buttonFindInApp.Tag =(BrowserTabPageHomePage)this;
            Bookmarks bookmarks = new();
            bookmarks.pictureBox1.Hide();
            bookmarks.label1.Text = "+";
            bookmarks.label1.Font = new Font(bookmarks.Font.FontFamily, 18);
            bookmarks.label1.Dock = DockStyle.Fill;
            newFlowLayoutPanel1.Controls.Add(bookmarks);
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(bookmarks, 500);
            
        }

        public string AddressParser(string text)
        {
            if (text.StartsWith("https"))
                return text;

            if (comboBox1.SelectedItem.ToString() == "www.google.com")
            {
                text = @"https://www.google.com/search?q="+text;
            }
            return text;
        }

        private void ButtonFindInInternet_Click(object sender, EventArgs e)
        {
            try
            {
                BrowserTabPage browserTabPage =
                    this.ParentForm.Controls.OfType<BrowserTabPage>().First();
                if (browserTabPage == null)
                {
                    Console.Error.WriteLine("browserTabPage is null {Find in parent form}");
                    return;
                }
                BrowserWebView2 BrowserWebView2 = new(AddressParser(textBoxMain.Text));
                BrowserTabPageItem browserTabPageItem= browserTabPage.AddPageAndRef("Szukanie:"+textBoxMain.Text, null, BrowserWebView2);
                BrowserWebView2.Dock = DockStyle.Fill;
                BrowserWebView2.Tag = browserTabPage;
                BrowserWebView2.webView.Source = new Uri(AddressParser(textBoxMain.Text));
                BrowserWebView2.webView.Tag = browserTabPageItem;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

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

        private void ButtonFindInApp_Click(object sender, EventArgs e)
        {
            
        }

        private void BrowserTabPageHomePage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
