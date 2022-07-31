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
            RoundingControl rc = new RoundingControl();
            rc.TargetControl = textBoxMain;
            rc.CornerRadius = 15;
            rc = new RoundingControl();
            rc.TargetControl = buttonFindInInternet;
            rc.CornerRadius = 15;
            rc = new RoundingControl();
            rc.TargetControl = buttonFindInApp;
            rc.CornerRadius = 15;
            rc = new RoundingControl();
            rc.TargetControl = comboBox1;
            rc.CornerRadius = 15;
            buttonFindInApp.Tag =(BrowserTabPageHomePage)this;

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

        private void buttonFindInInternet_Click(object sender, EventArgs e)
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
                BrowserWebView2 BrowserWebView2 = new BrowserWebView2(AddressParser(textBoxMain.Text));
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

        private void buttonFindInApp_Click(object sender, EventArgs e)
        {
            
        }

        private void BrowserTabPageHomePage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
