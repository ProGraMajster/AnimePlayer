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
using System.Threading;
using AnimePlayer.Class;
using System.Diagnostics;

namespace AnimePlayerLibrary
{
    public partial class ControlTitleStatusList_Item : UserControl
    {
        public PreviewTitleClass previewTitleClass=null;
        public PageItemData pageItemData=null;
        public ControlTitleStatusList_Item(AnimePlayer.Profile.ItemToList itemToList)
        {
            InitializeComponent();
            pictureBox.LoadCompleted += PictureBox_LoadCompleted;
            try
            {
                if(File.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\NoImage.png"))
                {
                    pictureBox.ImageLocation = "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\NoImage.png";
                }
                panelV2.Hide();
                View2 = false;
                this.Size = new Size(this.Size.Width, hView1);
                labelTitle.Text = itemToList.Name;

                Thread threadTitleClass = new(() =>
                {
                    previewTitleClass = ContentManagerLibary.GetPreviewTitleClassFromTitle(itemToList.Name);
                    pageItemData = ContentManagerLibary.GetPageItemDataWithContentFolderFromTitle(itemToList.Name);
                    if(previewTitleClass != null)
                    {
                        this.Invoke(() =>
                        {
                            pictureBox.ImageLocation = previewTitleClass.LinkToIcon[0];
                        });
                    }
                    if(pageItemData != null)
                    {
                        List<CheckBox> checkBoxes= new List<CheckBox>();
                        for(int i = 0; i< int.Parse(pageItemData.TitleInformation.NumberOfEpisodes); i++)
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = "Odcinek: "+ i.ToString();
                            checkBoxes.Add(checkBox);
                        }
                        this.Invoke(() =>
                        {
                            labelOtherTitle.Text = pageItemData.TitleInformation.OtherTitle.ToString();
                            foreach(CheckBox checkBox in checkBoxes)
                            {
                                checkedListBox1.Items.Add(checkBox);
                            }
                        });
                    }
                });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private int UsedLinkIcon = 0;
        private void PictureBox_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    UsedLinkIcon++;
                    if(previewTitleClass!=null)
                    {
                        pictureBox.ImageLocation = previewTitleClass.LinkToIcon[UsedLinkIcon];
                    }
#if DEBUG
                    Debug.WriteLine(e.Error.ToString() + "\n UsedLinkIcon:" + UsedLinkIcon);
#endif
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
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
        readonly int hView1 = 55;
        readonly int hView2 = 400;

        private void ButtonViewChange_Click(object sender, EventArgs e)
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
