using AnimePlayer.Class;
using AnimePlayer.Profile;
using AnimePlayerLibrary.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AnimePlayerLibrary
{
    public partial class ChangeTitleState : UserControl
    {
        PageItemData pageitemData=null;
        Dictionary<ProfileIAnimeList, string> profileIAnimeLists = null;
        //List<ProfileIAnimeList> profileIAnimeLists=null;
        public ProfileIAnimeList CurrnetList = null;
        private AnimePlayer.Profile.ItemToList currentItem= null;

        public EventHandler EventSaveChangeTitleState;

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
                if(profileIAnimeLists == null)
                {
                    MessageBox.Show("Wystąpił błąd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                /*MessageBox.Show("Ta funkcja jest nie dostępna\n(Jeszcze nie jest skończona)", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);*/
               // if(currentItem == null)
               // {
                    currentItem = new ItemToList();
                    currentItem.Name = pageitemData.TitleInformation.Title;
                    currentItem.Note = string.Empty;
                    currentItem.Episodes = new List<EpisodeAnimeList>();
                    currentItem.IsEpisodes = false;
                    if (int.Parse(pageitemData.TitleInformation.NumberOfEpisodes) > 1)
                    {
                        currentItem.IsEpisodes = true;
                    }
                    currentItem.YourScore = (int)numericUpDown1.Value;
                    currentItem.ReWatch= (int)numericUpDown2.Value;
                    foreach(ChangeTitleStateEpisode stateEpisode in newFlowLayoutPanelEpisodes.Controls.OfType<ChangeTitleStateEpisode>())
                    {
                        EpisodeAnimeList episodeAnime = new();
                        episodeAnime.NameAnime = pageitemData.TitleInformation.Title;
                        episodeAnime.EpisodeWatched = stateEpisode.checkBox.Checked;
                        episodeAnime.DateTimeWatched = stateEpisode.dateTimePicker.Value;
                        if (stateEpisode.checkBox.Tag != null)
                        {
                            if(stateEpisode.checkBox.Tag.GetType() == typeof(Episode))
                            {
                                Episode episode = (Episode)stateEpisode.checkBox.Tag;
                                if (episode != null)
                                {
                                    episodeAnime.NumberEpisode = int.Parse(episode.NumberEpisode);
                                    episodeAnime.NameEpisode = episode.TitleOfEpisode;
                                }
                            }
                            else
                            {
                                if(stateEpisode.checkBox.Tag.GetType() == typeof(int))
                                {
                                    episodeAnime.NumberEpisode = 1;
                                }
                                episodeAnime.NameEpisode = string.Empty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("stateEpisode.checkBox.Tag is NULL");
                        }
                        currentItem.Episodes.Add(episodeAnime);
                    }
                //}
                if(CurrnetList == null)
                {
                    foreach(ProfileIAnimeList animeList in profileIAnimeLists.Keys)
                    {
                        if(animeList.Name == comboBox1.SelectedItem.ToString())
                        {
                            CurrnetList = animeList;
                            animeList.itemToLists.Add(currentItem);
                            string path;
                            profileIAnimeLists.TryGetValue(animeList, out path);
                            string txt = AnimePlayer.Core.SerializationAndDeserialization
                                .SerializationJsonEx(animeList, typeof(ProfileIAnimeList));
                            File.WriteAllText(path, txt);
                            MessageBox.Show("Zapisano!");
                            if(EventSaveChangeTitleState != null)
                            {
                                EventSaveChangeTitleState.Invoke(this, EventArgs.Empty);
                            }
                        }
                    }
                }
                else
                {
                    ProfileIAnimeList profileIAnimeListNew = CurrnetList;
                    if (CurrnetList.Name != comboBox1.SelectedItem.ToString())
                    {
                        profileIAnimeListNew = ProfileManager.GetProfileIAnimeListFromName(comboBox1.SelectedItem.ToString());
                        foreach(var item in CurrnetList.itemToLists.ToList())
                        {
                            if(item.Name == currentItem.Name)
                            {
                                CurrnetList.itemToLists.Remove(item);
                            }
                        }
                        string path;
                        profileIAnimeLists.TryGetValue(CurrnetList, out path);
                        string txt = AnimePlayer.Core.SerializationAndDeserialization
                            .SerializationJsonEx(CurrnetList, typeof(ProfileIAnimeList));
                        File.WriteAllText(path, txt);
                    }
                    foreach (var item in profileIAnimeListNew.itemToLists.ToList())
                    {
                        if (item.Name == currentItem.Name)
                        {
                            CurrnetList.itemToLists.Remove(item);
                        }
                    }
                    profileIAnimeListNew.itemToLists.Add(currentItem);
                    string pathNew = ProfileManager.GetPrfileAnimeListPath(profileIAnimeListNew);
                    //profileIAnimeLists.TryGetValue(profileIAnimeListNew, out pathNew);
                    string txtNew = AnimePlayer.Core.SerializationAndDeserialization
                        .SerializationJsonEx(profileIAnimeListNew, typeof(ProfileIAnimeList));
                    File.WriteAllText(pathNew, txtNew);
                    CurrnetList = profileIAnimeListNew;
                    if (EventSaveChangeTitleState != null)
                    {
                        EventSaveChangeTitleState.Invoke(this, EventArgs.Empty);
                    }
                }
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
                for (int i = 0; i < int.Parse(pageitemData.TitleInformation.NumberOfEpisodes); i++)
                {
                    ChangeTitleStateEpisode changeTitleStateEpisode = new();
                    //CheckBox checkBox = new CheckBox();
                    changeTitleStateEpisode.checkBox.Name = "checkBoxEpisode_"+ (i+1).ToString();
                    changeTitleStateEpisode.checkBox.Text = "Odcinek "+ (i+1).ToString();
                    changeTitleStateEpisode.checkBox.Tag = i;
                    changeTitleStateEpisode.checkBox.ForeColor= Color.White;
                    newFlowLayoutPanelEpisodes.Invoke(() =>
                    {
                        newFlowLayoutPanelEpisodes.Controls.Add(changeTitleStateEpisode);
                    });
                    Thread threadEp = new(() =>
                    {
                        try
                        {
                            bool added= false;
                            List<Episode> episodes = ContentManagerLibary.GetEpisode(i, pageitemData.TitleInformation.Title);
                            if(episodes == null)
                            {
                                return;
                            }
                            foreach(var item in episodes)
                            {
                                if (item != null)
                                {
                                    if (!string.IsNullOrEmpty(item.TitleOfEpisode)&& !added)
                                    {
                                        changeTitleStateEpisode.Invoke(() =>
                                        {
                                            changeTitleStateEpisode.checkBox.Text += " | " + item.TitleOfEpisode;
                                            changeTitleStateEpisode.checkBox.Tag = item;
                                            added= true;
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
                    threadEp.Start();
                }

                Thread thread = new(() =>
                {

                    profileIAnimeLists = ProfileManager.GetAllAnimeListAndFilePath();
                    this.Invoke(() =>
                    {
                        foreach(var animelist in profileIAnimeLists.Keys)
                        {
                            comboBox1.Items.Add(animelist.Name);
                        }
                    });
                    foreach(var animelist in profileIAnimeLists.Keys)
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
                if(CurrnetList != null)
                {
                    labelState.Text = "Aktualna lista: \n" + CurrnetList.Name;
                }
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

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(ChangeTitleStateEpisode changeTitleStateEpisode in newFlowLayoutPanelEpisodes.Controls.OfType<ChangeTitleStateEpisode>())
                {
                    changeTitleStateEpisode.checkBox.Checked= true;
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
