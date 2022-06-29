using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AnimePlayer.Class;

namespace AnimePlayerLibrary.UI
{
    public class PanelItem
    {
        public Panel panelItem;
        public PictureBox pictureBoxItem;
        public Button buttonItem;
        
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

        public void SetInformationUI(PreviewTitleClass previewTitleClass)
        {
            try
            {
                buttonItem.Text = previewTitleClass.Title;
                pictureBoxItem.ImageLocation = previewTitleClass.LinkToIcon[0];
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public PanelItem(PreviewTitleClass previewTitleClass)
        {
            CreateElemetsUI();
            SetInformationUI(previewTitleClass);

        }
    }
}
