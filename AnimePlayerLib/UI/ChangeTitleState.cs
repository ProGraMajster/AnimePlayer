using AnimePlayer.Class;
using AnimePlayer.Profile;
using AnimePlayerLibrary.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AnimePlayerLibrary
{
    public partial class ChangeTitleState : UserControl
    {
        PageItemData pageitemData=null;
        List<ProfileIAnimeList> profileIAnimeLists=null;
        private ProfileIAnimeList CurrnetList = null;
        private AnimePlayer.Profile.ItemToList currentItem= null;

        public ChangeTitleState(PageItemData pageItemData)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.pageitemData = pageItemData;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void ButtonSaveChangeState_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Ta funkcja jest nie dostępna\n(Jeszcze nie jest skończona)", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Wystąpił błąd podczas zmieniania listy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeTitleState_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= int.Parse(pageitemData.TitleInformation.NumberOfEpisodes); i++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Size = new Size(290, checkBox.Size.Height);
                    checkBox.Name = "checkBoxEpisode_"+ (i+1).ToString();
                    checkBox.Text = "Odcinek "+ (i+1).ToString();
                    checkBox.Tag = i;
                    checkBox.ForeColor= Color.White;
                    newFlowLayoutPanelEpisodes.Invoke(() =>
                    {
                        newFlowLayoutPanelEpisodes.Controls.Add(checkBox);
                    });
                    Thread threadEp = new(() =>
                    {
                        try
                        {
                            List<Episode> episodes = ContentManagerLibary.GetEpisode(i, pageitemData.TitleInformation.Title);
                            if(episodes == null)
                            {
                                return;
                            }
                            foreach(var item in episodes)
                            {
                                if (item != null)
                                {
                                    if (!string.IsNullOrEmpty(item.TitleOfEpisode))
                                    {
                                        checkBox.Invoke(() =>
                                        {
                                            checkBox.Text += " | " + item.TitleOfEpisode;
                                        });
                                    }
                                }
                            }
                        }
                        catch(Exception exTh)
                        {
                            Debug.WriteLine(exTh.ToString());
                        }
                    });
                    //threadEp.Start();
                }

                Thread thread = new(() =>
                {

                    profileIAnimeLists = ProfileManager.GetAllAnimeList();
                    this.Invoke(() =>
                    {
                        foreach(var animelist in profileIAnimeLists)
                        {
                            comboBox1.Items.Add(animelist.Name);
                        }
                    });
                    foreach(var animelist in profileIAnimeLists)
                    {
                        if(animelist.itemToLists!=null)
                        {
                            foreach(var item in animelist.itemToLists)
                            {
                                if(item.Name == pageitemData.TitleInformation.Title)
                                {
                                    currentItem = item;
                                    CurrnetList = animelist;
                                    return;
                                }
                            }
                        }
                    }
                    this.Invoke(() =>
                    {
                        Loading.Hide();
                        panel.Show();
                    });
                });
                thread.Name = "ChangeTitleState_Load";
                thread.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > 0)
            {
                panel3.Enabled = true;
            }
        }
    }
}
