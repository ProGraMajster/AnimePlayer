using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    public partial class BrowserTabPageItem : UserControl
    {
        public BrowserTabPageItem()
        {
            InitializeComponent();
        }

        private void labelItemTitle_Click(object sender, EventArgs e)
        {
            CloseBrowserTabPageItem();
        }

        private void buttonCloseItem_Click(object sender, EventArgs e)
        {
            CloseBrowserTabPageItem();
        }

        private void pictureBoxItemIcon_Click(object sender, EventArgs e)
        {
            CloseBrowserTabPageItem();
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
    }
}
