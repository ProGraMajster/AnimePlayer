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
            Thread thread = new(() =>
            {
                Thread.Sleep(200);
                foreach(var item in ContentManagerLibary.GetAllItemCommunities())
                {
                    PanelPreviewItemCommunity panel = new(item);
                    panel.Click+=Item_Click;
                    panel.labelName.Click+=Item_Click;
                    panel.pictureBox1.Click+=Item_Click;
                    panel.Tag = item;
                    panel.labelName.Tag = item;
                    panel.pictureBox1.Tag = item;
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
            try
            {
                Control control = (Control)sender;
                AnimePlayer.Class.ItemCommunity itemCommunity = (AnimePlayer.Class.ItemCommunity)control.Tag;
                panelAll.Hide();
                panelView.Show();
                labelName.Text = itemCommunity.Name;
                if(itemCommunity.IconLinks.Length >0 && itemCommunity.IconLinks != null)
                {
                    pictureBoxIcon.ImageLocation = itemCommunity.IconLinks[0];
                }
                if(itemCommunity.banners.Length >0 && itemCommunity.banners != null)
                {
                    PictureBox pictureBox = new()
                    {
                        ImageLocation = itemCommunity.banners[0]
                    };
                    panelViewBack.BackgroundImage = pictureBox.Image;
                    pictureBox.Dispose();
                }
                foreach(var item in itemCommunity.URLs)
                {
                    LinkLabel linkLabel = new()
                    {
                        Text = item.Key.ToString(),
                        Tag = item.Value.ToString(),
                        LinkColor = Color.Aqua
                    };
                    linkLabel.LinkClicked +=LinkLabel_LinkClicked;
                    newFlowLayoutPanelLinks.Controls.Add(linkLabel);
                }
            } 
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                AnimePlayer.Core.OpenLinks.Start((string)((Control)sender).Tag);
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void PageCommunity_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClosePage_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
