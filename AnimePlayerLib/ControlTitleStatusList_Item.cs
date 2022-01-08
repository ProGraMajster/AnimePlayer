using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AnimePlayerLibrary
{
    public partial class ControlTitleStatusList_Item : UserControl
    {
        public ControlTitleStatusList_Item()
        {
            InitializeComponent();
            try
            {
                if(File.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\NoImage.png"))
                {
                    pictureBox.ImageLocation = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\NoImage.png";
                }
                panelV2.Hide();
                View2 = false;
                this.Size = new Size(this.Size.Width, hView1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public string Title;
        public string OtherString;
        public bool State = false;

        public void SetWidth(int width)
        {
            this.Size = new System.Drawing.Size(width, Height);
        }

        public void ShowCheckBox()
        {
            checkBox.Show();
        }

        public void HideCheckBox()
        {
            checkBox.Hide();
        }

        bool View2 = false;
        int hView1 = 55;
        int hView2 = 400;

        private void buttonViewChange_Click(object sender, EventArgs e)
        {
            if(View2)
            {
                panelV2.Hide();
                View2 =false;
                this.Size = new Size(this.Size.Width, hView1);
                buttonViewChange.Text = @"\/";
                return;
            }
            else
            {
                panelV2.Show();
                View2 = true;
                this.Size = new Size(this.Size.Width, hView2);
                buttonViewChange.Text = @"/\";
                return;
            }
        }
    }
}
