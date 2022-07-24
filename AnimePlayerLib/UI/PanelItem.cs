using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimePlayer.Class;
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
        private Panel panelFromMainContent = (Panel)Application.OpenForms[0].Controls.Find("panel2",true)[0];
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
            this.panelItem = new Panel();
            this.panelItem.Tag = this;
            this.panelItem.Controls.Add(pictureBoxItem);
            this.panelItem.Controls.Add(buttonItem);
            this.panelItem.Location = new System.Drawing.Point(13, 5);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(160, 240);
            this.panelItem.Font = new Font("Comic Sans MS", 9F);
            this.panelItem.BackColor = Color.FromArgb(30, 30, 30);
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
            pictureBoxItem.Click += object_Click;
            buttonItem.Click += object_Click;
        }

        public async void GetLoadingCotrols()
        {
            await Task.Run(() =>
            {
                panelLoading = (Panel)Application.OpenForms[0].Controls.Find("panelLoading", true)[0];
                labelLoadingDetails = (Label)Application.OpenForms[0].Controls.Find("labelLoadingDetails", true)[0];
            });
        }

        private void object_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateLoadingTextdetails("Find Page > "+ _previewTitleClass.Title);
                ShowPanelLoading();

                PageItem pageItem = new PageItem(this);
                pageItem.Name = "pageItem";
                panelFromMainContent.Controls.Add(pageItem);
                pageItem.Dock = DockStyle.Fill;
                pageItem.Show();
                pageItem.BringToFront();
                /*PageItemUI pageItemUI = new PageItemUI(this);
                pageItemUI.Name ="pageItemUI";
                panelFromMainContent.Controls.Add(pageItemUI);
                pageItemUI.Dock = DockStyle.Fill;
                pageItemUI.Show();
                pageItemUI.BringToFront();*/
            }
            catch(Exception ex)
            {

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

        public PanelItem(PreviewTitleClass previewTitleClass)
        {
            _previewTitleClass = previewTitleClass;
            if(_previewTitleClass == null)
            {
                new ArgumentNullException("_previewTitleClass is null");
            }
            GetLoadingCotrols();
            CreateElemetsUI();
            SetInformationUI();
            AddEvents();
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(panelItem, 15);
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(buttonItem, 15);
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(pictureBoxItem, 15);
            panelItem.Tag=this;
        }
    }
}
