namespace AnimePlayer.ControlsWinForms
{
    partial class PanelSearchResult
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelTitle = new System.Windows.Forms.LinkLabel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelDes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.linkLabelTitle);
            this.panel1.Controls.Add(this.pictureBoxIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 48);
            this.panel1.TabIndex = 0;
            // 
            // linkLabelTitle
            // 
            this.linkLabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelTitle.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabelTitle.Location = new System.Drawing.Point(67, 0);
            this.linkLabelTitle.Name = "linkLabelTitle";
            this.linkLabelTitle.Size = new System.Drawing.Size(461, 48);
            this.linkLabelTitle.TabIndex = 1;
            this.linkLabelTitle.TabStop = true;
            this.linkLabelTitle.Text = "linkLabel1";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(67, 48);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelDes
            // 
            this.labelDes.AutoEllipsis = true;
            this.labelDes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDes.Location = new System.Drawing.Point(0, 48);
            this.labelDes.Name = "labelDes";
            this.labelDes.Padding = new System.Windows.Forms.Padding(5);
            this.labelDes.Size = new System.Drawing.Size(528, 76);
            this.labelDes.TabIndex = 1;
            this.labelDes.Text = "label1";
            // 
            // PanelSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PanelSearchResult";
            this.Size = new System.Drawing.Size(528, 124);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBoxIcon;
        public System.Windows.Forms.LinkLabel linkLabelTitle;
        public System.Windows.Forms.Label labelDes;
    }
}
