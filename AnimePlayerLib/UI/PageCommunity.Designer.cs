namespace AnimePlayerLibrary.UI
{
    partial class PageCommunity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageCommunity));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonClosePage = new System.Windows.Forms.Button();
            this.newFlowLayoutPanelAll = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.panelAll = new System.Windows.Forms.Panel();
            this.panelView = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.newFlowLayoutPanelLinks = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelViewBack = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.panelView.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelViewBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.buttonFind);
            this.panelTop.Controls.Add(this.buttonClosePage);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(20, 20);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.panelTop.Size = new System.Drawing.Size(795, 50);
            this.panelTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panel1.Size = new System.Drawing.Size(625, 28);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(625, 17);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // buttonFind
            // 
            this.buttonFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.ForeColor = System.Drawing.Color.White;
            this.buttonFind.Location = new System.Drawing.Point(635, 11);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 28);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Szukaj";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Visible = false;
            // 
            // buttonClosePage
            // 
            this.buttonClosePage.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClosePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClosePage.ForeColor = System.Drawing.Color.Red;
            this.buttonClosePage.Location = new System.Drawing.Point(710, 11);
            this.buttonClosePage.Name = "buttonClosePage";
            this.buttonClosePage.Size = new System.Drawing.Size(75, 28);
            this.buttonClosePage.TabIndex = 0;
            this.buttonClosePage.Text = "Zamknij";
            this.buttonClosePage.UseVisualStyleBackColor = true;
            this.buttonClosePage.Click += new System.EventHandler(this.ButtonClosePage_Click);
            // 
            // newFlowLayoutPanelAll
            // 
            this.newFlowLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFlowLayoutPanelAll.Location = new System.Drawing.Point(0, 10);
            this.newFlowLayoutPanelAll.Name = "newFlowLayoutPanelAll";
            this.newFlowLayoutPanelAll.Size = new System.Drawing.Size(795, 580);
            this.newFlowLayoutPanelAll.TabIndex = 1;
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.newFlowLayoutPanelAll);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(20, 70);
            this.panelAll.Name = "panelAll";
            this.panelAll.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelAll.Size = new System.Drawing.Size(795, 590);
            this.panelAll.TabIndex = 2;
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.panel5);
            this.panelView.Controls.Add(this.panelViewBack);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(20, 70);
            this.panelView.Name = "panelView";
            this.panelView.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.panelView.Size = new System.Drawing.Size(795, 590);
            this.panelView.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 192);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.panel5.Size = new System.Drawing.Size(775, 384);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel6.Controls.Add(this.newFlowLayoutPanelLinks);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(5, 11);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(765, 362);
            this.panel6.TabIndex = 0;
            // 
            // newFlowLayoutPanelLinks
            // 
            this.newFlowLayoutPanelLinks.Dock = System.Windows.Forms.DockStyle.Top;
            this.newFlowLayoutPanelLinks.Location = new System.Drawing.Point(10, 63);
            this.newFlowLayoutPanelLinks.Name = "newFlowLayoutPanelLinks";
            this.newFlowLayoutPanelLinks.Size = new System.Drawing.Size(755, 60);
            this.newFlowLayoutPanelLinks.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Linki:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 11, 0, 0);
            this.label2.Size = new System.Drawing.Size(112, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inforamcje";
            // 
            // panelViewBack
            // 
            this.panelViewBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelViewBack.Controls.Add(this.labelName);
            this.panelViewBack.Controls.Add(this.pictureBoxIcon);
            this.panelViewBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelViewBack.Location = new System.Drawing.Point(10, 11);
            this.panelViewBack.Name = "panelViewBack";
            this.panelViewBack.Padding = new System.Windows.Forms.Padding(10, 57, 0, 11);
            this.panelViewBack.Size = new System.Drawing.Size(775, 181);
            this.panelViewBack.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(138, 146);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelName.Size = new System.Drawing.Size(67, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(10, 57);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(128, 113);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // PageCommunity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelAll);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PageCommunity";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(835, 680);
            this.Load += new System.EventHandler(this.PageCommunity_Load);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAll.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelViewBack.ResumeLayout(false);
            this.panelViewBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonClosePage;
        private AnimePlayer.ControlsWinForms.NewFlowLayoutPanel newFlowLayoutPanelAll;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panelViewBack;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private AnimePlayer.ControlsWinForms.NewFlowLayoutPanel newFlowLayoutPanelLinks;
        private System.Windows.Forms.Label label3;
    }
}
