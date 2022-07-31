using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace AnimePlayerLibrary.UI
{
    public partial class PageCommunity : UserControl
    {
        public PageCommunity()
        {
            InitializeComponent();
            panelView.Hide();
            panelAll.Show();
            Thread thread = new Thread(() =>
            {
                Thread.Sleep(200);
                foreach(var item in ContentManagerLibary.GetAllItemCommunities())
                {
                    PanelPreviewItemCommunity panel = new PanelPreviewItemCommunity(item);
                    panel.Click+=Item_Click;
                    panel.labelName.Click+=Item_Click;
                    panel.pictureBox1.Click+=Item_Click;
                    this.Invoke(() =>
                    {
                        newFlowLayoutPanelAll.Controls.Add(panel);
                        panel.Show();
                    });
                }
            });
            thread.Start();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            //Zmana panelu
            //Klasa już jest tylko prtzypisać wartośći do kontrolek
        }

        private void PageCommunity_Load(object sender, EventArgs e)
        {

        }
    }
}
