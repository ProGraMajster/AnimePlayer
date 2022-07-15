using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerLibrary.UI
{
    public partial class PageItemUI : UserControl
    {
        public PanelItem panelItem;
        
        public PageItemUI(PanelItem _panelItem)
        {
            InitializeComponent();
            panelItem = _panelItem;
        }

        Image image;

        protected override void OnResize(EventArgs e)
        {
            /*int widthAll = panel1.Width +panel2.Width +panel6.Width +panel7.Width +panel8.Width;
            vScrollBar1.Maximum = widthAll;*/
            base.OnResize(e);
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            image = panel1.BackgroundImage;
            panel1.BackgroundImage = null;
            this.Invalidate();
            base.OnScroll(se);
            panel1.BackgroundImage = image;
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void PageItemUI_Load(object sender, EventArgs e)
        {
            SettInformationUI();
        }

        public void SettInformationUI()
        {
            if(panelItem == null)
            {
                return;
            }

            pictureBoxIcon.Image = panelItem.pictureBoxItem.Image;
            labelTitle.Text = panelItem.buttonItem.Text;
        }

        private void panelGradient1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClosePageItemUI_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonWatch_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel6.Show();
        }

        private void buttonBackToPanel1_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel1.Show();
        }
    }
}