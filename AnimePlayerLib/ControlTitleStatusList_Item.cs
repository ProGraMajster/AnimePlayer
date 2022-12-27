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
using AnimePlayer.Profile;

namespace AnimePlayerLibrary
{
    public partial class ControlTitleStatusList_Item : UserControl
    {
        public PreviewTitleClass previewTitleClass=null;
        public PageItemData pageItemData=null;
        private ItemToList ItemToList;
        public ControlTitleStatusList_Item(AnimePlayer.Profile.ItemToList itemToList)
        {
            InitializeComponent();
            ItemToList = itemToList;
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

        private void ControlTitleStatusList_Item_Load(object sender, EventArgs e)
        {
            try
            {
                Thread threadTitleClass = new(() =>
                {
                    previewTitleClass = ContentManagerLibary.GetPreviewTitleClassFromTitle(ItemToList.Name);
                    pageItemData = ContentManagerLibary.GetPageItemDataWithContentFolderFromTitle(ItemToList.Name);
                    if (previewTitleClass != null)
                    {
                        this.Invoke(() =>
                        {
                            pictureBox.ImageLocation = previewTitleClass.LinkToIcon[0];
                        });
                    }
                    if (pageItemData != null)
                    {
                        List<ControlTitleStatusList_Item_Episodes> episodesItem = new List<ControlTitleStatusList_Item_Episodes>();
                        for (int i = 0; i < int.Parse(pageItemData.TitleInformation.NumberOfEpisodes); i++)
                        {
                            ControlTitleStatusList_Item_Episodes item_Episodes = new();
                            item_Episodes.labelEpisodeTitle.Text = "Odcinek: " + (i+1).ToString();
                            episodesItem.Add(item_Episodes);
                            Thread thread = new(() =>
                            {
                                if(ItemToList.Episodes == null)
                                {
                                    return;
                                }   
                                foreach(EpisodeAnimeList episodeAnime in ItemToList.Episodes)
                                {
                                    if(i == episodeAnime.NumberEpisode)
                                    {
                                        item_Episodes.Tag = episodeAnime;
                                        item_Episodes.labelEpisodeTitle.Text += " | "+episodeAnime.NameEpisode;
                                        item_Episodes.CheckBoxState = episodeAnime.EpisodeWatched;
                                        item_Episodes.checkBox.Checked = episodeAnime.EpisodeWatched;
                                        item_Episodes.labelDateTime.Text = episodeAnime.DateTimeWatched.ToString();
                                    }
                                }
                            });
                            thread.Start();
                        }
                        this.Invoke(() =>
                        {
                            labelOtherTitle.Text = "";
                            foreach (string title in pageItemData.TitleInformation.OtherTitle)
                            {
                                labelOtherTitle.Text += title + ", ";
                            }
                            foreach (var item in episodesItem)
                            {
                                newFlowLayoutPanelEpisodes.Invoke(() =>
                                {
                                    newFlowLayoutPanelEpisodes.Controls.Add(item);
                                });
                            }
                        });
                    }
                });
                threadTitleClass.Start();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
