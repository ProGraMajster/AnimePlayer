using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePlayer.ControlsWinForms;
using AnimePlayer.Core;
using AnimePlayer.Profile;

namespace AnimePlayerLibrary
{
    public partial class ControlTitleStatusList : UserControl
    {
        readonly NewFlowLayoutPanel newFlowLayoutPanel;
        public ProfileIAnimeList ProfileIAnimeList;

        public bool EditMode = false;
        public ControlTitleStatusList(ProfileIAnimeList profileIAnimeList)
        {
            InitializeComponent();
            ProfileIAnimeList = profileIAnimeList;
            newFlowLayoutPanel = new NewFlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                Name = "newFlowLayoutPanel_Titles",
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            newFlowLayoutPanel.Resize += NewFlowLayoutPanel_Resize;
            panelDock.Controls.Add(newFlowLayoutPanel);
            newFlowLayoutPanel.Show();
        }

        private void NewFlowLayoutPanel_Resize(object sender, EventArgs e)
        {
            if (!bWresiezItem.IsBusy)
            {
                bWresiezItem.RunWorkerAsync();
            }
        }

        private void BWresiezItem_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                foreach (ControlTitleStatusList_Item i in newFlowLayoutPanel.Controls.OfType<ControlTitleStatusList_Item>())
                {
                    this.BeginInvoke(new Action(() => i.SetWidth(newFlowLayoutPanel.Width - 35)));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ControlTitleStatusList_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    Thread thread = new(() =>
                    {
                        List<ControlTitleStatusList_Item> controlTitleStatusList_Items = new List<ControlTitleStatusList_Item>();
                        foreach (ItemToList itemList in ProfileIAnimeList.itemToLists)
                        {
                            ControlTitleStatusList_Item controlTitleStatusList_Item = new ControlTitleStatusList_Item(itemList);
                            controlTitleStatusList_Item.ItemEpisodeChangeSettings += new EventHandler<ControlTitleStatusList_Item.EventArgsI>((s, e) =>
                            {
                                Thread threadSaveChange = new(() =>
                                {
                                    try
                                    {
                                        if (e != null)
                                        {
                                            if (e.ChangeSetting)
                                            {
                                                foreach (var ep in e.ItemToList.Episodes)
                                                {
                                                    if (ep.NumberEpisode == e.EpisodeAnimeList.NumberEpisode)
                                                    {
                                                        e.ItemToList.Episodes.Remove(ep);
                                                        e.ItemToList.Episodes.Add(e.EpisodeAnimeList);
                                                        break;
                                                    }
                                                }
                                                foreach (var itl in ProfileIAnimeList.itemToLists)
                                                {
                                                    if (itl.Name == e.ItemToList.Name)
                                                    {
                                                        ProfileIAnimeList.itemToLists.Remove(itl);
                                                        ProfileIAnimeList.itemToLists.Add(e.ItemToList);
                                                    }
                                                }
                                                string path = ProfileManager.GetPrfileAnimeListPath(ProfileIAnimeList);
                                                string json = AnimePlayer.Core.SerializationAndDeserialization
                                                .SerializationJsonEx(ProfileIAnimeList, typeof(ProfileIAnimeList));
                                                File.WriteAllText(path, json);
                                                MessageBox.Show("Zapisano!");
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Debug.WriteLine(ex.ToString());
                                        Console.WriteLine(ex.ToString());
                                    }
                                });
                                threadSaveChange.Start();
                            });
                            controlTitleStatusList_Items.Add(controlTitleStatusList_Item);
                        }

                        this.Invoke(() =>
                        {
                            foreach (var item in controlTitleStatusList_Items)
                            {
                                newFlowLayoutPanel1.Controls.Add(item);
                            }
                        });
                    });
                    thread.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void newFlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in newFlowLayoutPanel1.Controls)
                {
                    control.Size = new Size((newFlowLayoutPanel1.Width - 30), control.Height);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }

        private void newFlowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                foreach (Control control in newFlowLayoutPanel1.Controls)
                {
                    control.Size = new Size((newFlowLayoutPanel1.Width - 30), control.Height);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonEditList_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditMode)
                {
                    EditMode = false;
                    panelEdit.Hide();
                    buttonEditList.Text = "Edytuj";
                    foreach (ControlTitleStatusList_Item controlTitle in newFlowLayoutPanel1.Controls.OfType<ControlTitleStatusList_Item>())
                    {
                        controlTitle.HideCheckBox();
                    }
                }
                else
                {
                    EditMode = true;
                    panelEdit.Show();
                    buttonEditList.Text = "X";
                    foreach (ControlTitleStatusList_Item controlTitle in newFlowLayoutPanel1.Controls.OfType<ControlTitleStatusList_Item>())
                    {
                        controlTitle.ShowCheckBox();
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                List<ItemToList> items = new List<ItemToList>();
                //UI
                for (int i = 0; i <= newFlowLayoutPanel1.Controls.Count - 1; i++)
                {
                    ControlTitleStatusList_Item controlTitle =
                        (ControlTitleStatusList_Item)newFlowLayoutPanel1.Controls[i];
                    if (controlTitle != null)
                    {
                        if (controlTitle.State)
                        {
                            items.Add(controlTitle.ItemToList);
                            controlTitle.Hide();
                            controlTitle.Dispose();
                        }
                    }
                }
                /*foreach (Control c in newFlowLayoutPanel1.Controls)
                {
                    ControlTitleStatusList_Item controlTitle = (ControlTitleStatusList_Item)c;
                    if(controlTitle == null)
                    {
                        break;
                    }
                    if(controlTitle.State)
                    {
                        items.Add(controlTitle.ItemToList);
                        controlTitle.Hide();
                        controlTitle.Dispose();
                    }
                }*/

                var animeList = ProfileIAnimeList.itemToLists;

                foreach (var anime in animeList.ToList())
                {
                    foreach (var item in items)
                    {
                        if (anime.Name == item.Name)
                        {
                            ProfileIAnimeList.itemToLists.Remove(anime);
                        }
                    }
                }

                string path = ProfileManager.GetPrfileAnimeListPath(ProfileIAnimeList);
                string json = SerializationAndDeserialization.SerializationJsonEx(ProfileIAnimeList, typeof(ProfileIAnimeList));
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
                MessageBox.Show("Wystąpił błąd!\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
