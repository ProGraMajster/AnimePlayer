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
        public EventHandler eventHandler;
        int tabPageValue = 0;
        public void AddPage(string title, Image image, Control controlContentPage)
        {
            BrowserTabPageItem item = new BrowserTabPageItem();
            item.pictureBoxItemIcon.Image = image;
            item.labelItemTitle.Text = title;
            item.Tag = controlContentPage;
            browserTabPageItems.Add(item);
            newFlowLayoutPanelPages.Controls.Add(item);
            if(_UseRoundingControl)
            {
                RoundingControl roundingControl = new RoundingControl();
                roundingControl.TargetControl = item;
                roundingControl.CornerRadius = ValueCornerRadius;
            }
            item.pictureBoxItemIcon.Click += Item_Click;
            item.labelItemTitle.Click += Item_Click;
            item.Click += Item_Click;
        }

        public void BrowserTabItemsChageBackColor(Color color)
        {
            try
            {
                foreach(var control in newFlowLayoutPanelPages.Controls.OfType<BrowserTabPageItem>())
                {
                    control.BackColor = color;
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control = (Control)control.Tag;
            control.BackColor = Color.FromArgb(55,55,55);
            BrowserTabItemsChageBackColor(Color.FromArgb(30, 30, 30));
        }

        public BrowserTabPageItem AddPageAndRef(string title, Image image, Control controlContentPage)
        {
            BrowserTabPageItem item = new BrowserTabPageItem();
            item.pictureBoxItemIcon.Image = image;
            item.labelItemTitle.Text = title;
            item.Tag = controlContentPage;
            browserTabPageItems.Add(item);
            newFlowLayoutPanelPages.Controls.Add(item);
            if (_UseRoundingControl)
            {
                RoundingControl roundingControl = new RoundingControl();
                roundingControl.TargetControl = item;
                roundingControl.CornerRadius = ValueCornerRadius;
            }
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

                homePage.buttonFindInApp.Click += eventHandler;
                mainPage = AddPageAndRef("Strona główna", null, homePage);
                mainPage.buttonCloseItem.Hide();
                Timer timer = new Timer();
                timer.Tick+=Timer_Tick;
                timer.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        BrowserTabPageItem mainPage;


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

        public BrowserTabPageHomePage browserTabPageHomePage;
        private void buttonNewPage_Click(object sender, EventArgs e)
        {
            browserTabPageHomePage =new BrowserTabPageHomePage();
            browserTabPageHomePage.buttonFindInApp.Click += eventHandler;
            AddPage("Strona główna", null, browserTabPageHomePage);
        }

        private void newFlowLayoutPanelPages_ControlAdded(object sender, ControlEventArgs e)
        {
            if(e.Control.GetType() == typeof(BrowserTabPageHomePage) ||
                e.Control.GetType() == typeof(BrowserTabPageItem))
            {
                tabPageValue++;
                labelTabPageValue.Text = tabPageValue.ToString();
            }
        }

        private void newFlowLayoutPanelPages_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control.GetType() == typeof(BrowserTabPageHomePage) ||
                e.Control.GetType() == typeof(BrowserTabPageItem))
            {
                tabPageValue--;
                labelTabPageValue.Text = tabPageValue.ToString();
            }
        }
        BrowserTabPageHomePage homePage = new BrowserTabPageHomePage();
        private void BrowserTabPage_Load(object sender, EventArgs e)
        {
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(eventHandler !=null)
            {
                homePage.buttonFindInApp.Click += eventHandler;
                Timer timer = (Timer)sender;
                timer.Stop();
            }
        }
    }
}