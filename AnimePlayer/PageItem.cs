using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AnimePlayerLibrary;

namespace AnimePlayer
{
    public partial class PageItem : UserControl
    {
        WebContent.Values values;
        FormMainPlayer FormMainPlayer;

        public string linkToScriptComment = null;

        public PageItem()
        {
            InitializeComponent();
        }

        public PageItem(WebContent.Values va, FormMainPlayer okno)
        {
            InitializeComponent();
            FormMainPlayer = okno;
            values = va;
            panel_comments.Size = new Size(panel_comments.Width, 121);
            if (values != null)
            {
                linkLabel1.Show();
            }
            else
            {
                linkLabel1.Hide();
            }

            if (AnimePlayer.Properties.Settings.Default.RoundingControl)
            {
                ControlsNewMethods.RoundingControl rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = pictureBoxIcon;
                rc.CornerRadius = 20;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = panelViewIcon;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = labelotherTitle;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = labelTitle;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = button;
                rc.CornerRadius = 15;
                rc = new ControlsNewMethods.RoundingControl();
                rc.TargetControl = button_Load_Comments;
                rc.CornerRadius = 15;
            }
            if(okno.usedThemeColors)
            {
                try
                {
                    panel6.BackColor = okno.BackColor;
                    panel6.ForeColor = okno.tchangerColors.PageItem_ForeColor;

                    panel1.BackColor = okno.tchangerColors.PageItem_BackColor2;
                    labelotherTitle.BackColor = okno.tchangerColors.PageItem_BackColor3;
                    labelTitle.BackColor = okno.tchangerColors.PageItem_BackColor3;
                    button.BackColor = okno.tchangerColors.PageItem_BackColor;
                    panel3.BackColor = okno.tchangerColors.PageItem_BackColor;
                    label2.BackColor = okno.tchangerColors.PageItem_BackColor;
                    label1.BackColor = okno.tchangerColors.PageItem_BackColor;
                    labelDes.BackColor = okno.tchangerColors.PageItem_BackColor4;
                    panel2.BackColor = okno.tchangerColors.PageItem_BackColor4;
                    panel1.BackColor = okno.tchangerColors.PageItem_BackColor2;
                    panel10.BackColor = okno.tchangerColors.PageItem_BackColor4;
                    panel5.BackColor = okno.tchangerColors.PageItem_BackColor;
                    listBoxEpType.BackColor = okno.tchangerColors.PageItem_BackColor4;
                    panelRelatedSeries.BackColor = okno.tchangerColors.PageItem_BackColor;
                    flowLayoutPanelRelatedSeries.BackColor = okno.tchangerColors.PageItem_BackColor4;

                    /*
                    panel1.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    labelotherTitle.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    labelTitle.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    button.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    panel3.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    label2.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    label1.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    labelDes.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    panel2.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    panel1.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    panel10.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    panel5.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    listBoxEpType.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    panel11.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    flowLayoutPanelRelatedSeries.ForeColor = okno.tchangerColors.PageItem_ForeColor;
                    */
                    ThemeChanger.SetForeColorOnControls((PageItem)this, okno.tchangerColors.PageItem_ForeColor);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }


        private void button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        public void buttonEpType_Click(object sender, EventArgs e)
        {
            try
            {
                if (values != null)
                {
                    Button btn = (Button)sender;
                    if (File.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video\\" + values.name + "_list_ep.txt"))
                    {
                        PageEpisode pageEpisode = new PageEpisode(btn.Tag.ToString(),
                                "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video\\" + values.name + "_list_ep.txt", values, FormMainPlayer.panel2, FormMainPlayer, FormMainPlayer.tchangerColors);

                        FormMainPlayer.panel2.Controls.Add(pageEpisode);
                        pageEpisode.Dock = DockStyle.Fill;
                        pageEpisode.Show();
                        pageEpisode.BringToFront();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (values != null)
            {
                if (values.siteLink != null && values.siteLink != "null")
                {
                    DialogResult dr = MessageBox.Show("Czy otworzy link?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(values.siteLink);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listBoxEpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (values != null)
                {
                    if (File.Exists("C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video\\" + values.name + "_list_ep.txt"))
                    {
                        if (listBoxEpType.SelectedItem != null)
                        {
                            PageEpisode pageEpisode = new PageEpisode(listBoxEpType.SelectedItem.ToString(),
                                "C:\\ContentLibrarys\\OtherFiles\\WMP_OverlayApp\\Video\\" + values.name + "_list_ep.txt", values, FormMainPlayer.panel2, FormMainPlayer, FormMainPlayer.tchangerColors);

                            FormMainPlayer.panel2.Controls.Add(pageEpisode);
                            pageEpisode.Dock = DockStyle.Fill;
                            pageEpisode.Show();
                            pageEpisode.BringToFront();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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

        ChangeTitleState changeTitleState;
        private void linkLabelChangeState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FormMainPlayer.panelStartPage.Enabled = false;
                FormMainPlayer.panelAllitem.Enabled = false;
                this.Enabled = false;
                changeTitleState = new ChangeTitleState(this);
                changeTitleState.Name = "changeTitleState";
                FormMainPlayer.panel2.Controls.Add(changeTitleState);
                FormMainPlayer.Resize += ChangeTitleState_Resize;
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
        }

        private void ChangeTitleState_Disposed(object sender, EventArgs e)
        {
            this.Enabled = true;
            FormMainPlayer.panelStartPage.Enabled = true;
            FormMainPlayer.panelAllitem.Enabled = true;
            FormMainPlayer.Resize -= ChangeTitleState_Resize;
        }

        private void ChangeTitleState_Resize(object sender, EventArgs e)
        {
            try
            {
                changeTitleState.Location = new Point((this.ClientSize.Width - changeTitleState.Width) / 2,
                    (this.ClientSize.Height - changeTitleState.Height) / 2);
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
                        webView2.CoreWebView2.Navigate("file:///"+ AnimePlayer.Class.AppFolders.Web + values.name + "_script_comments.html");
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
