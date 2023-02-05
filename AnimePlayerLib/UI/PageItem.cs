using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq;

using AnimePlayer.CNM;
using AnimePlayer.Class;
using AnimePlayer.Core;
using AnimePlayerLibrary;
using AnimePlayerLibrary.UI;
using AnimePlayer.Profile;
using ZetaIpc.Runtime.Client;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading;
using System.Collections.Generic;
using Microsoft.Web.WebView2.WinForms;

namespace AnimePlayerLibrary.UI
{
    public partial class PageItem : UserControl
    {
        public PageItemData pageItemData;
        private ProfileClass profileClass { get; set; }
        private ZetaIpc.Runtime.Client.IpcClient ipcClient;
        public string linkToScriptComment = null;
        private readonly PanelItem _PanelItem;

        private Panel PanelLoading;
        private Label LabelLoadingDetails;
        private readonly Panel panelFromMainContent = (Panel)Application.OpenForms[0].Controls.Find("panel2", true)[0];
        public PageItem(PanelItem panelItem)
        {
            InitializeComponent();
            _PanelItem = panelItem;
            GetLoadingCotrols();
            UpdateLoadingTextdetails("Ładowanie strony...");
            ShowPanelLoading();
            SettingInofrmationUIFromPanelItem();
            pageItemData = ContentManagerLibary.GetPageItemDataWithContentFolderFromTitle(panelItem._previewTitleClass.Title);
            LoadPageItem(pageItemData);
            HidePanelLoading();
            try
            {
                ipcClient = new IpcClient();
                int port = int.Parse(File.ReadAllText("IpcServerData_port.txt"));
                ipcClient.Initialize(port);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
        public PageItem(PageItemData pageItemDataP)
        {
            InitializeComponent();
            pageItemData = pageItemDataP;
            GetLoadingCotrols();
            UpdateLoadingTextdetails("Ładowanie strony...");
            ShowPanelLoading();
            labelTitle.Text = pageItemData.TitleInformation.Title;
            pageItemData = ContentManagerLibary.GetPageItemDataWithContentFolderFromTitle(pageItemData.TitleInformation.Title);
            LoadPageItem(pageItemData);
            HidePanelLoading();
            try
            {
                ipcClient = new IpcClient();
                int port = int.Parse(File.ReadAllText("IpcServerData_port.txt"));
                ipcClient.Initialize(port);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void UpdateLoadingTextdetails(string text)
        {
            if (text == null && LabelLoadingDetails == null)
                return;
            Application.DoEvents();
            LabelLoadingDetails.Text = text;
        }

        private void ShowPanelLoading()
        {
            if (PanelLoading != null)
            {
                PanelLoading.Show();
                PanelLoading.BringToFront();
                Application.DoEvents();
            }
        }
        private void HidePanelLoading()
        {
            if (PanelLoading != null)
            {
                PanelLoading.Hide();
            }
        }
        void GetLoadingCotrols()
        {
            PanelLoading = (Panel)Application.OpenForms[0].Controls.Find("panelLoading", true)[0];
            LabelLoadingDetails = (Label)Application.OpenForms[0].Controls.Find("labelLoadingDetails", true)[0];
        }


        private static void SettingLabelFormStringData(Label label, string text)
        {
            if (text != null &&
                    text.Length != 0)
            {
                label.Text = text;
            }
            else
            {
                label.Text = "N/A";
            }
        }

        private static void SettingLabelFormArryStringData(Label label, string[] text)
        {
            if (text != null &&
                    text.Length != 0)
            {
                label.Text = "";
                foreach (string item in text)
                {
                    if (item != null  && item.Length != 0)
                    {
                        label.Text += item+", ";
                    }
                }
            }
        }

        public void LoadPageItem(PageItemData pageItemData)
        {
            try
            {
                if(pageItemData == null)
                {
                    return;
                }
                SettingLabelFormArryStringData(labelotherTitle, pageItemData.TitleInformation.OtherTitle);
                SettingLabelFormStringData(labelDes, pageItemData.TitleInformation.Description);
                SettingLabelFormStringData(labelType, pageItemData.TitleInformation.Type);
                SettingLabelFormStringData(labelStatus, pageItemData.TitleInformation.Status);
                SettingLabelFormStringData(labelDateS, pageItemData.TitleInformation.DateOfIssue);
                SettingLabelFormStringData(labelDateE, pageItemData.TitleInformation.EndOfIssue);
                SettingLabelFormStringData(labelNE,pageItemData.TitleInformation.NumberOfEpisodes);
                SettingLabelFormArryStringData(labelStudio, pageItemData.TitleInformation.Studio);
                SettingLabelFormStringData(labelLE, pageItemData.TitleInformation.EpisodeLength);
                SettingLabelFormStringData(labelMPAA, pageItemData.TitleInformation.MPAA);
                SettingLabelFormArryStringData(labelSpecies,pageItemData.TitleInformation.Species);
                SettingLabelFormArryStringData(labelTypesOfCharacters, pageItemData.TitleInformation.TypesOfCharacters);
                SettingLabelFormArryStringData(labelPlaceAndTime, pageItemData.TitleInformation.PlaceAndTime);
                SettingLabelFormStringData(labelArchetype, pageItemData.TitleInformation.Archetype);
                SettingLabelFormArryStringData(labelOtherTags, pageItemData.TitleInformation.OtherTags);
                SettingLabelFormStringData(labelTargetGroups, pageItemData.TitleInformation.TargetGroups);
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public void SettingInofrmationUIFromPanelItem()
        {
            pictureBoxIcon.Image = _PanelItem.pictureBoxItem.Image;
            labelTitle.Text = _PanelItem._previewTitleClass.Title;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void PictureBoxIcon_Click(object sender, EventArgs e)
        {
            panelViewIcon.Size = new Size(this.Size.Width - 200, this.Size.Height - 100);
            panelViewIcon.Left = (this.ClientSize.Width - panelViewIcon.Width) / 2;
            panelViewIcon.Top = (this.ClientSize.Height - panelViewIcon.Height) / 2;
            panelViewIcon.BringToFront();
            panelViewIcon.Show();
            pictureBox2.Image = pictureBoxIcon.Image;
        }

        private void ButtonViewIconClose_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            panelViewIcon.Hide();
        }

        private void PageItem_Resize(object sender, EventArgs e)
        {
            if (panelViewIcon.Visible)
            {
                panelViewIcon.Size = new Size(this.Size.Width - 200, this.Size.Height - 100);
                panelViewIcon.Left = (this.ClientSize.Width - panelViewIcon.Width) / 2;
                panelViewIcon.Top = (this.ClientSize.Height - panelViewIcon.Height) / 2;
            }
        }

        ChangeTitleState changeTitleState;

        private void ChangeTitleState_Disposed(object sender, EventArgs e)
        {
            panelChangeStatus.Hide();
            changeTitleState = null;
        }    

        private async void Button_Load_Comments_Click(object sender, EventArgs e)
        {
            try
            {
               Button btn = (Button)sender;
               
                if(btn.Tag.GetType() == typeof(WebView2))
                {
                    if(((Microsoft.Web.WebView2.WinForms.WebView2)btn.Tag).Visible)
                    {
                        ((Microsoft.Web.WebView2.WinForms.WebView2)btn.Tag).Visible = false;
                        btn.Text = "Pokaż";
                        panel_com_dockWebview.Visible = false;
                        panel_comments.Size = new Size(panel_comments.Width, 121);
                    }
                    else
                    {
                        ((Microsoft.Web.WebView2.WinForms.WebView2)btn.Tag).Visible = true;
                        btn.Text = "Ukryj";
                        panel_com_dockWebview.Visible = true;
                        panel_comments.Size = new Size(panel_comments.Width, 521);
                    }
                }
                else
                {
                    string code = (string)btn.Tag;
                    panel_comments.Size = new Size(panel_comments.Width, 521);
                    Microsoft.Web.WebView2.WinForms.WebView2 webView2 = new()
                    {
                        Name = "webView2"
                    };
                    await webView2.EnsureCoreWebView2Async(default);
                    panel_com_dockWebview.Controls.Add(webView2);
                    webView2.Dock = DockStyle.Fill;
                    webView2.Show();
                    btn.Tag = webView2;
                    if (webView2 != null && webView2.CoreWebView2 != null)
                    {
                        webView2.CoreWebView2.NavigateToString(code);
                        btn.Text = "Ukryj";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił błąd!");
                Console.WriteLine(ex.ToString());
            }
        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private ProfileIAnimeList currnetList;
        private ItemToList currentItemToList;

        private void PageItem_Load(object sender, EventArgs e)
        {
            try
            {
                if(pageItemData == null)
                {
                    panelNoDataSite.Show();
                    panelNoDataSite.BringToFront();
                    return;
                }
                bool adultContent = false;
                foreach(string item in pageItemData.TitleInformation.Species)
                {
                    if (item.ToLower() == "hentai")
                        adultContent = true;
                }


                if (adultContent)
                {
                    string resoult = ipcClient.Send("get;c;ProfileClass;YearOfBirth");
                    if(!string.IsNullOrEmpty(resoult) && resoult != "null")
                    {
                        DateTime dt;
                        bool status = DateTime.TryParse(resoult, out dt);
                        if (status)
                        {
                            var age = GetAge(dt);
                            if (age < 18)
                            {
                                panelNoAccess.Show();
                                panelNoAccess.BringToFront();
                            }
                        }
                        else
                        {
                            panelAdultContentMessage.Show();
                            panelAdultContentMessage.BringToFront();
                        }
                    }
                    else
                    {
                        panelAdultContentMessage.Show();
                        panelAdultContentMessage.BringToFront();
                    }
                    
                }
                int ep = int.Parse(pageItemData.TitleInformation.NumberOfEpisodes);
                for(int i = 1; i <=ep ; i++)
                {
                    PanelEpisodeNumber panelEpisodeNumber = new();
                    panelEpisodeNumber.AutoSize = false;
                    panelEpisodeNumber.button.Text = "Odcinek " + i.ToString();
                    panelEpisodeNumber.button.Tag = i;
                    panelEpisodeNumber.button.Click += ButtonEpisode_Click;
                    flowLayoutPanelEpisode.Controls.Add(panelEpisodeNumber);
                    Thread threadEpEnd = new(() =>
                    {
                        List<ProfileIAnimeList> profileIAnimeLists= 
                        ProfileManager.GetAllAnimeList();
                        foreach(ProfileIAnimeList animeList in profileIAnimeLists)
                        {
                            if(animeList.itemToLists != null)
                            {
                                foreach(ItemToList itemToList in animeList.itemToLists)
                                {
                                    if(pageItemData.TitleInformation.Title == itemToList.Name)
                                    {
                                        if(currentItemToList == null)
                                        {
                                            currentItemToList = itemToList;
                                        }
                                        if(currnetList ==null)
                                        {
                                            currnetList = animeList;
                                        }
                                        if(itemToList.Episodes != null)
                                        {
                                            foreach(EpisodeAnimeList episodeAnimeList in itemToList.Episodes)
                                            {
                                                if(episodeAnimeList.EpisodeWatched)
                                                {
                                                    panelEpisodeNumber.Invoke(() =>
                                                    {
                                                        panelEpisodeNumber.label.Show();
                                                    });
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    });
                    threadEpEnd.Start();
                }

                string resoultRequestProfile = ipcClient.Send("get;c;ProfileClass");
                if (!string.IsNullOrEmpty(resoultRequestProfile))
                {
                    if(resoultRequestProfile != "null")
                    {   
                        ProfileClass profile = Newtonsoft.Json.JsonConvert.DeserializeObject<ProfileClass>(resoultRequestProfile);
                        if (profile != null)
                        {
                            profileClass = profile;
                            linkLabelChangeState.Show();
                            Thread thread = new(() =>
                            {
                                try
                                {
                                    List<ProfileIAnimeList> profileIAnimeLists =
                                    ProfileManager.GetAllAnimeList();
                                    foreach(ProfileIAnimeList animeList in profileIAnimeLists)
                                    {
                                        if(animeList != null)
                                        {
                                            if(animeList.itemToLists != null)
                                            {
                                                foreach (ItemToList item in animeList.itemToLists)
                                                {
                                                    if(item.Name == pageItemData.TitleInformation.Title)
                                                    {
                                                        this.Invoke(() =>
                                                        {
                                                            linkLabelChangeState.Text = "Zmień status (Aktualny: " + animeList.Name + ")";
                                                        });
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                catch(Exception ex)
                                {
                                    Debug.WriteLine(ex.ToString());
                                }
                            });
                            thread.Name = "Thread_LoadAnimeStatus";
                            thread.Start();
                        }
                    }
                }

                Thread threadTitleComments = new(() =>
                {
                    try
                    {
                        TitleCommentsData titleCommentsData =
                        ContentManagerLibary.GetTitleComments(pageItemData.TitleInformation.Title);
                        if(titleCommentsData == null)
                        {
                            return;
                        }
                        this.Invoke(() =>
                        {
                            panel_comments.Show();
                            button_Load_Comments.Show();
                            button_Load_Comments.Tag = titleCommentsData.Code;
                        });
                    }
                    catch(Exception ex)
                    {
                        Debug.WriteLine(ex.ToString());
                        Console.Error.WriteLine(ex.ToString());
                    }
                });
                threadTitleComments.Name = "threadTitleComments";
                threadTitleComments.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
        int GetAge(DateTime bornDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bornDate.Year;
            if (bornDate > today.AddYears(-age))
                age--;

            return age;
        }
        private void ButtonEpisode_Click(object sender, EventArgs e)
        {
            try
            {
                PageEpisode pageEpisode = new(pageItemData, (int)((Control)sender).Tag)
                {
                    Name = "pageEpisode",
                    Dock = DockStyle.Fill
                };
                panelFromMainContent.Controls.Add(pageEpisode);
                pageEpisode.Show();
                pageEpisode.BringToFront();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void buttonBackA_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void buttonAno_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void buttonAyes_Click(object sender, EventArgs e)
        {
            panelAdultContentMessage.Hide();
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {   
            this.Hide();
            this.Dispose();
        }

        private void linkLabelChangeState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if(changeTitleState != null)
                {
                    return;
                }
                changeTitleState = new ChangeTitleState(pageItemData);
                changeTitleState.Name = "changeTitleState";
                changeTitleState.Dock = DockStyle.Fill;
                panelChangeStatus.Controls.Add(changeTitleState);
                changeTitleState.Show();
                panelChangeStatus.Show();
                /*if (AnimePlayer.Properties.Settings.Default.RoundingControl)
                {
                    ControlsNewMethods.RoundingControl rc = new ControlsNewMethods.RoundingControl();
                    rc.TargetControl = changeTitleState;
                    rc.CornerRadius = 15;
                }*/
                changeTitleState.Disposed += ChangeTitleState_Disposed;
                changeTitleState.EventSaveChangeTitleState += changeTitleState_EventSaveChangeTitleState;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void changeTitleState_EventSaveChangeTitleState(object sender, EventArgs e)
        {
            try
            {
                linkLabelChangeState.Text = "Zmień status (Aktualny: " + changeTitleState.CurrnetList.Name + ")";
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
