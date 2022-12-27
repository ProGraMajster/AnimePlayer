namespace AnimePlayerLibrary
{
    partial class ControlTitleStatusList_Item
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.panelCheckBox = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelOtherTitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonViewChange = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelV2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonOpenTitlePage = new System.Windows.Forms.Button();
            this.labelDescryption = new System.Windows.Forms.Label();
            this.newFlowLayoutPanelEpisodes = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.panelCheckBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelV2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox.Location = new System.Drawing.Point(22, 29);
            this.checkBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 0;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panelCheckBox
            // 
            this.panelCheckBox.Controls.Add(this.checkBox);
            this.panelCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCheckBox.Location = new System.Drawing.Point(0, 0);
            this.panelCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelCheckBox.Name = "panelCheckBox";
            this.panelCheckBox.Size = new System.Drawing.Size(58, 70);
            this.panelCheckBox.TabIndex = 1;
            this.panelCheckBox.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Location = new System.Drawing.Point(58, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(71, 70);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelOtherTitle);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(129, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(452, 70);
            this.panel2.TabIndex = 3;
            // 
            // labelOtherTitle
            // 
            this.labelOtherTitle.AutoSize = true;
            this.labelOtherTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOtherTitle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOtherTitle.Location = new System.Drawing.Point(6, 29);
            this.labelOtherTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOtherTitle.Name = "labelOtherTitle";
            this.labelOtherTitle.Size = new System.Drawing.Size(70, 17);
            this.labelOtherTitle.TabIndex = 1;
            this.labelOtherTitle.Text = "OtherTitle";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(6, 6);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(46, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonViewChange);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(581, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 70);
            this.panel3.TabIndex = 4;
            // 
            // buttonViewChange
            // 
            this.buttonViewChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonViewChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewChange.Location = new System.Drawing.Point(0, 0);
            this.buttonViewChange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonViewChange.Name = "buttonViewChange";
            this.buttonViewChange.Size = new System.Drawing.Size(36, 70);
            this.buttonViewChange.TabIndex = 0;
            this.buttonViewChange.Text = "\\/";
            this.buttonViewChange.UseVisualStyleBackColor = true;
            this.buttonViewChange.Click += new System.EventHandler(this.ButtonViewChange_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.pictureBox);
            this.panel4.Controls.Add(this.panelCheckBox);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(617, 70);
            this.panel4.TabIndex = 2;
            // 
            // panelV2
            // 
            this.panelV2.Controls.Add(this.panel5);
            this.panelV2.Controls.Add(this.newFlowLayoutPanelEpisodes);
            this.panelV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelV2.Location = new System.Drawing.Point(0, 70);
            this.panelV2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelV2.Name = "panelV2";
            this.panelV2.Size = new System.Drawing.Size(617, 405);
            this.panelV2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonOpenTitlePage);
            this.panel5.Controls.Add(this.labelDescryption);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(617, 87);
            this.panel5.TabIndex = 4;
            // 
            // buttonOpenTitlePage
            // 
            this.buttonOpenTitlePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonOpenTitlePage.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOpenTitlePage.FlatAppearance.BorderSize = 0;
            this.buttonOpenTitlePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenTitlePage.Location = new System.Drawing.Point(0, 58);
            this.buttonOpenTitlePage.Name = "buttonOpenTitlePage";
            this.buttonOpenTitlePage.Size = new System.Drawing.Size(129, 29);
            this.buttonOpenTitlePage.TabIndex = 2;
            this.buttonOpenTitlePage.Text = "Otwórz stronę tytułu";
            this.buttonOpenTitlePage.UseVisualStyleBackColor = false;
            this.buttonOpenTitlePage.Click += new System.EventHandler(this.buttonOpenTitlePage_Click);
            // 
            // labelDescryption
            // 
            this.labelDescryption.AutoEllipsis = true;
            this.labelDescryption.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescryption.Location = new System.Drawing.Point(0, 0);
            this.labelDescryption.Name = "labelDescryption";
            this.labelDescryption.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.labelDescryption.Size = new System.Drawing.Size(617, 58);
            this.labelDescryption.TabIndex = 3;
            this.labelDescryption.Text = "Opis:";
            // 
            // newFlowLayoutPanelEpisodes
            // 
            this.newFlowLayoutPanelEpisodes.AutoScroll = true;
            this.newFlowLayoutPanelEpisodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newFlowLayoutPanelEpisodes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newFlowLayoutPanelEpisodes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.newFlowLayoutPanelEpisodes.Location = new System.Drawing.Point(0, 87);
            this.newFlowLayoutPanelEpisodes.Name = "newFlowLayoutPanelEpisodes";
            this.newFlowLayoutPanelEpisodes.Size = new System.Drawing.Size(617, 318);
            this.newFlowLayoutPanelEpisodes.TabIndex = 1;
            this.newFlowLayoutPanelEpisodes.WrapContents = false;
            this.newFlowLayoutPanelEpisodes.SizeChanged += new System.EventHandler(this.newFlowLayoutPanelEpisodes_SizeChanged);
            this.newFlowLayoutPanelEpisodes.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.newFlowLayoutPanelEpisodes_ControlAdded);
            // 
            // ControlTitleStatusList_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.panelV2);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ControlTitleStatusList_Item";
            this.Size = new System.Drawing.Size(617, 475);
            this.Load += new System.EventHandler(this.ControlTitleStatusList_Item_Load);
            this.panelCheckBox.ResumeLayout(false);
            this.panelCheckBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelV2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Panel panelCheckBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelOtherTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonViewChange;
        private System.Windows.Forms.Panel panelV2;
        private AnimePlayer.ControlsWinForms.NewFlowLayoutPanel newFlowLayoutPanelEpisodes;
        private System.Windows.Forms.Button buttonOpenTitlePage;
        private System.Windows.Forms.Label labelDescryption;
        private System.Windows.Forms.Panel panel5;
    }
}
