using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePlayer.Class;
using AnimePlayer.Profile;
using AnimePlayerLibrary;

namespace AnimePlayerLibrary.UI
{
    public class PanelItem
    {
        public Panel panelItem;
        public PictureBox pictureBoxItem;
        public Button buttonItem;
        public PreviewTitleClass _previewTitleClass;
        private Panel panelLoading;
        private Label labelLoadingDetails;  
        private readonly Panel panelFromMainContent = (Panel)Application.OpenForms[0].Controls.Find("panel2",true)[0];
        private int UsedLinkIcon = 0;
        private Button buttonAddToList;
        private void CreateElemetsUI()
        {
            // 
            // pictureBoxItem
            // 
            pictureBoxItem = new PictureBox();
            this.pictureBoxItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxItem.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxItem.Name = "picżtureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(160, 199);
            this.pictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxItem.BackgroundImageLayout = ImageLayout.Zoom;
            this.pictureBoxItem.TabIndex = 0;
            this.pictureBoxItem.TabStop = false;
            // 
            // buttonItem
            // 
            buttonItem = new Button();
            this.buttonItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonItem.Location = new System.Drawing.Point(0, 199);
            this.buttonItem.Name = "buttonItem";
            buttonItem.ForeColor = Color.White;
            buttonItem.AutoSize = true;
            buttonItem.Font = new Font("Comic Sans MS", 9F);
            buttonItem.FlatStyle = FlatStyle.Flat;
            buttonItem.FlatAppearance.BorderSize = 0;
            buttonItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 35, 35);
            this.buttonItem.Size = new System.Drawing.Size(177, 42);
            this.buttonItem.TabIndex = 1;
            this.buttonItem.Text = "Name";
            buttonItem.AutoEllipsis = true;
            this.buttonItem.UseVisualStyleBackColor = true;

            // 
            // panelItem
            // 
            this.panelItem = new Panel
            {
                Tag = this
            };
            buttonAddToList = new Button();
            buttonAddToList.Text = "+";
            buttonAddToList.Size = new Size(25, 25);
            buttonAddToList.FlatStyle = FlatStyle.Flat;
            buttonAddToList.ForeColor = Color.White;
            buttonAddToList.FlatAppearance.BorderSize=0;
            buttonAddToList.Font = new Font(buttonAddToList.Font.FontFamily, 12);
            buttonAddToList.BackColor = Color.FromArgb(35,35,35);
            buttonAddToList.Visible= false;
            this.panelItem.Controls.Add(buttonAddToList);
            buttonAddToList.Location= new Point(135, 0);

            this.panelItem.Controls.Add(pictureBoxItem);
            this.panelItem.Controls.Add(buttonItem);
            this.panelItem.Location = new System.Drawing.Point(13, 5);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(160, 240);
            this.panelItem.Font = new Font("Comic Sans MS", 9F);
            this.panelItem.BackColor = Color.FromArgb(40, 40, 40);
        }

        public void SetInformationUI()
        {
            try
            {
                buttonItem.Text = _previewTitleClass.Title;
                pictureBoxItem.ImageLocation = _previewTitleClass.LinkToIcon[0];
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public void AddEvents()
        {
            pictureBoxItem.Click += Object_Click;
            buttonItem.Click += Object_Click;
            pictureBoxItem.LoadCompleted += PictureBoxItem_LoadCompleted;
            pictureBoxItem.MouseMove += PictureBoxItem_MouseMove;
            pictureBoxItem.MouseLeave += PictureBoxItem_MouseLeave;
        }

        private void PictureBoxItem_MouseLeave(object sender, EventArgs e)
        {
            buttonAddToList.Hide();
        }

        private void PictureBoxItem_MouseMove(object sender, MouseEventArgs e)
        {
            //Coming soon...
            //buttonAddToList.Show();
        }

        private void PictureBoxItem_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            try
            {
                if(e.Error != null)
                {
                    UsedLinkIcon++;
                    pictureBoxItem.ImageLocation = _previewTitleClass.LinkToIcon[UsedLinkIcon];
                    #if DEBUG
                        Debug.WriteLine(e.Error.ToString()+"\n UsedLinkIcon:"+UsedLinkIcon);
                    #endif
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public async void GetLoadingCotrols()
        {
            try
            {
                Thread thread = new(() =>
                {
                    panelLoading = (Panel)Application.OpenForms[0].Controls.Find("panelLoading", true)[0];
                    labelLoadingDetails = (Label)Application.OpenForms[0].Controls.Find("labelLoadingDetails", true)[0];
                });
                thread.Start();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void Object_Click(object sender, EventArgs e)
        {
            try
            {
                if(Form.ActiveForm!= null)
                {
                    Form.ActiveForm.ActiveControl = buttonItem;
                }
                UpdateLoadingTextdetails("Find Page > "+ _previewTitleClass.Title);
                ShowPanelLoading();
                PageItem pageItem = new(this)
                {
                    Name = "pageItem",
                    Dock = DockStyle.Fill,
                };
                panelFromMainContent.Controls.Add(pageItem);
                pageItem.Show();
                pageItem.BringToFront();
                HidePanelLoading();
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void UpdateLoadingTextdetails(string text)
        {
            if(text == null && labelLoadingDetails == null)
                return;
            Application.DoEvents();
            labelLoadingDetails.Text = text;
        }

        private void ShowPanelLoading()
        {
            if(panelLoading != null)
            {
                panelLoading.Show();
                panelLoading.BringToFront();
                Application.DoEvents();
            }
        }
        private void HidePanelLoading()
        {
            if(panelLoading != null)
            {
                panelLoading.Hide();
            }
        }
        bool watched = false;
        public PanelItem(PreviewTitleClass previewTitleClass)
        {
            _previewTitleClass = previewTitleClass;
            GetLoadingCotrols();
            CreateElemetsUI();
            SetInformationUI();
            AddEvents();
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(panelItem, 15);
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(buttonItem, 15);
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(pictureBoxItem, 15);
            panelItem.Tag=this;
            /*Thread thread = new(() =>
            {
                
            });
            thread.Start();*/
        }
    }
}
