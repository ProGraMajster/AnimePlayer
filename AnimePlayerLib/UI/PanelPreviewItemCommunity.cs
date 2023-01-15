using AnimePlayer.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace AnimePlayerLibrary.UI
{
    public partial class PanelPreviewItemCommunity : UserControl
    {
        public PanelPreviewItemCommunity()
        {
            InitializeComponent();
        }
        private string[] links;
        private int numerLink=0;
        Image image;
        public PanelPreviewItemCommunity(ItemCommunity itemCommunity)
        {
            InitializeComponent();
            try
            {
                image = pictureBox1.Image;
                links=itemCommunity.IconLinks;
                this.Tag =itemCommunity;
                labelName.Text = itemCommunity.Name;
                pictureBox1.ImageLocation = links[numerLink];
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void PanelPreviewItemCommunity_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {

                if(pictureBox1.Image == pictureBox1.ErrorImage)
                {
                    numerLink++;
                    if(numerLink>links.Length)
                    {
                        pictureBox1.Image = image;
                    }
                    else
                    {
                        pictureBox1.ImageLocation = links[numerLink];
                    }
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
