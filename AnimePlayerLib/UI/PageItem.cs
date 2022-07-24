﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AnimePlayer.CNM;
using AnimePlayer.Class;
using AnimePlayer.Core;
using AnimePlayerLibrary;
using AnimePlayerLibrary.UI;
using System.Threading.Tasks;

namespace AnimePlayerLibrary.UI
{
    public partial class PageItem : UserControl
    {
        public string linkToScriptComment = null;
        private PanelItem _PanelItem;

        private Panel PanelLoading;
        private Label LabelLoadingDetails;
        public PageItem(PanelItem panelItem)
        {
            InitializeComponent();
            _PanelItem = panelItem;
            GetLoadingCotrols();
            UpdateLoadingTextdetails("Ładowanie strony...");
            ShowPanelLoading();
            SettingInofrmationUIFromPanelItem();
            LoadPageItem(ContentManagerLibary.GetPageItemDataWithContentFolderFromTitle(panelItem._previewTitleClass.Title));
            HidePanelLoading();
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


        private void SettingLabelFormStringData(Label label, string text)
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

        private void SettingLabelFormArryStringData(Label label, string[] text)
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

        private void button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void pictureBoxIcon_Click(object sender, EventArgs e)
        {
            panelViewIcon.Size = new Size(this.Size.Width - 200, this.Size.Height - 100);
            panelViewIcon.Left = (this.ClientSize.Width - panelViewIcon.Width) / 2;
            panelViewIcon.Top = (this.ClientSize.Height - panelViewIcon.Height) / 2;
            panelViewIcon.BringToFront();
            panelViewIcon.Show();
            pictureBox2.Image = pictureBoxIcon.Image;
        }

        private void buttonViewIconClose_Click(object sender, EventArgs e)
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

        /*//ChangeTitleState changeTitleState;
        private void linkLabelChangeState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //FormMainPlayer.panelStartPage.Enabled = false;
                //FormMainPlayer.panelAllitem.Enabled = false;
                this.Enabled = false;
                changeTitleState = new ChangeTitleState(this);
                changeTitleState.Name = "changeTitleState";
                //FormMainPlayer.panel2.Controls.Add(changeTitleState);
                //FormMainPlayer.Resize += ChangeTitleState_Resize;
                changeTitleState.Show();
                changeTitleState.BringToFront();
                if (AnimePlayer.Properties.Settings.Default.RoundingControl)
                {
                    ControlsNewMethods.RoundingControl rc = new ControlsNewMethods.RoundingControl();
                    rc.TargetControl = changeTitleState;
                    rc.CornerRadius = 15;
                }
                changeTitleState.Disposed += ChangeTitleState_Disposed;
                changeTitleState.Location = new Point((this.ClientSize.Width - changeTitleState.Width) / 2,
                    (this.ClientSize.Height - changeTitleState.Height) / 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }*/

        private void ChangeTitleState_Disposed(object sender, EventArgs e)
        {
            this.Enabled = true;
            //FormMainPlayer.panelStartPage.Enabled = true;
            //FormMainPlayer.panelAllitem.Enabled = true;
            //FormMainPlayer.Resize -= ChangeTitleState_Resize;
        }

        private void ChangeTitleState_Resize(object sender, EventArgs e)
        {
            try
            {
                /*changeTitleState.Location = new Point((this.ClientSize.Width - changeTitleState.Width) / 2,
                    (this.ClientSize.Height - changeTitleState.Height) / 2);*/
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }        

        private async void button_Load_Comments_Click(object sender, EventArgs e)
        {
            try
            {
               Button btn = (Button)sender;
               
                if(btn.Tag != null)
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
                    panel_comments.Size = new Size(panel_comments.Width, 521);
                    Microsoft.Web.WebView2.WinForms.WebView2 webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
                    webView2.Name = "webView2";
                    await webView2.EnsureCoreWebView2Async(default);
                    panel_com_dockWebview.Controls.Add(webView2);
                    webView2.Dock = DockStyle.Fill;
                    webView2.Show();
                    btn.Tag = webView2;
                    if (webView2 != null && webView2.CoreWebView2 != null)
                    {
                        //webView2.CoreWebView2.Navigate("file:///"+ AnimePlayer.Class.AppFolders.Web + values.name + "_script_comments.html");
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}