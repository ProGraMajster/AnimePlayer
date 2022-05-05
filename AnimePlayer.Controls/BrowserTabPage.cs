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
    public partial class BrowserTabPage : UserControl
    {

        public void AddPage(string title, Image image, Control controlContentPage)
        {
            BrowserTabPageItem item = new BrowserTabPageItem();
            item.pictureBoxItemIcon.Image = image;
            item.labelItemTitle.Text = title;
            item.Tag = controlContentPage;
            browserTabPageItems.Add(item);
            newFlowLayoutPanelPages.Controls.Add(item);
        }
        
        public BrowserTabPageItem AddPageAndRef(string title, Image image, Control controlContentPage)
        {
            BrowserTabPageItem item = new BrowserTabPageItem();
            item.pictureBoxItemIcon.Image = image;
            item.labelItemTitle.Text = title;
            item.Tag = controlContentPage;
            browserTabPageItems.Add(item);
            newFlowLayoutPanelPages.Controls.Add(item);
            return item;
        }

        public bool _UseRoundingControl = true;
        public int ValueCornerRadius = 15;

        List<BrowserTabPageItem> browserTabPageItems = new List<BrowserTabPageItem>();


        [
            Category("Appearance"),
            Description("Zaokrąglanie rogów w wewnętrznych kontrolkach")
        ]
        public bool UseRoundingControl ///<summary>Wewnętrzny kolor panelu</summary>
        {
            get
            {
                return _UseRoundingControl;
            }
            set
            {
                _UseRoundingControl = value;
                Invalidate();
            }
        }

        [
            Category("Appearance"),
            Description("Promień łuku używany dla zaokrąglonych krawędzi wenęttrznych kontrolek.")
        ]
        public int RadiusControls ///<summary>Promień łuku używany dla zaokrąglonych krawędzi.</summary>
        {
            get
            {
                return ValueCornerRadius;
            }
            set
            {
                ValueCornerRadius = value;
                Invalidate();
            }
        }

        public BrowserTabPage()
        {
            InitializeComponent();
            if(_UseRoundingControl)
            {
                RoundingControl rc = new RoundingControl();
                rc.TargetControl = buttonNewPage;
                rc.CornerRadius = ValueCornerRadius;
                rc = new RoundingControl();
                rc.TargetControl = buttonViewAllPage;
                rc.CornerRadius = ValueCornerRadius;
            }
            try
            {
                BrowserTabPageItem mainPage = AddPageAndRef("Strona główna", null, new BrowserTabPageHomePage());
                mainPage.buttonCloseItem.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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

        private void buttonNewPage_Click(object sender, EventArgs e)
        {
            AddPage("Strona główna", null, new BrowserTabPageHomePage());
        }
    }
}
