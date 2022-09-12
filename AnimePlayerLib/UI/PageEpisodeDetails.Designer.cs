namespace AnimePlayerLibrary.UI
{
    partial class PageEpisodeDetails
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
            this.labelTitleAndNumber = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAudio = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDownloadEpisode = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPlayEp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitleAndNumber
            // 
            this.labelTitleAndNumber.AutoEllipsis = true;
            this.labelTitleAndNumber.AutoSize = true;
            this.labelTitleAndNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitleAndNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitleAndNumber.Location = new System.Drawing.Point(0, 45);
            this.labelTitleAndNumber.MaximumSize = new System.Drawing.Size(490, 0);
            this.labelTitleAndNumber.Name = "labelTitleAndNumber";
            this.labelTitleAndNumber.Padding = new System.Windows.Forms.Padding(5, 10, 0, 5);
            this.labelTitleAndNumber.Size = new System.Drawing.Size(87, 35);
            this.labelTitleAndNumber.TabIndex = 2;
            this.labelTitleAndNumber.Text = "labelName";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(0, 80);
            this.labelType.Name = "labelType";
            this.labelType.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.labelType.Size = new System.Drawing.Size(78, 30);
            this.labelType.TabIndex = 5;
            this.labelType.Text = "labelType";
            // 
            // labelAudio
            // 
            this.labelAudio.AutoSize = true;
            this.labelAudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAudio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAudio.Location = new System.Drawing.Point(0, 110);
            this.labelAudio.Name = "labelAudio";
            this.labelAudio.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.labelAudio.Size = new System.Drawing.Size(87, 30);
            this.labelAudio.TabIndex = 6;
            this.labelAudio.Text = "labelAudio";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubtitle.Location = new System.Drawing.Point(0, 140);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.labelSubtitle.Size = new System.Drawing.Size(98, 30);
            this.labelSubtitle.TabIndex = 7;
            this.labelSubtitle.Text = "labelSubtitle";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLabel1.LinkColor = System.Drawing.Color.Aqua;
            this.linkLabel1.Location = new System.Drawing.Point(0, 170);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.linkLabel1.Size = new System.Drawing.Size(75, 29);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 249);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(835, 341);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(835, 45);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(750, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDownloadEpisode
            // 
            this.buttonDownloadEpisode.BackColor = System.Drawing.Color.Black;
            this.buttonDownloadEpisode.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDownloadEpisode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadEpisode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDownloadEpisode.Location = new System.Drawing.Point(10, 10);
            this.buttonDownloadEpisode.Name = "buttonDownloadEpisode";
            this.buttonDownloadEpisode.Size = new System.Drawing.Size(156, 30);
            this.buttonDownloadEpisode.TabIndex = 11;
            this.buttonDownloadEpisode.Text = "Pobierz odcinek";
            this.buttonDownloadEpisode.UseVisualStyleBackColor = false;
            this.buttonDownloadEpisode.Visible = false;
            this.buttonDownloadEpisode.Click += new System.EventHandler(this.buttonDownloadEpisode_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonPlayEp);
            this.panel2.Controls.Add(this.buttonDownloadEpisode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 199);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(835, 50);
            this.panel2.TabIndex = 12;
            // 
            // buttonPlayEp
            // 
            this.buttonPlayEp.BackColor = System.Drawing.Color.Black;
            this.buttonPlayEp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPlayEp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayEp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlayEp.Location = new System.Drawing.Point(711, 10);
            this.buttonPlayEp.Name = "buttonPlayEp";
            this.buttonPlayEp.Size = new System.Drawing.Size(114, 30);
            this.buttonPlayEp.TabIndex = 12;
            this.buttonPlayEp.Text = "Oglądaj >";
            this.buttonPlayEp.UseVisualStyleBackColor = false;
            this.buttonPlayEp.Click += new System.EventHandler(this.buttonPlayEp_Click);
            // 
            // PageEpisodeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelAudio);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTitleAndNumber);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PageEpisodeDetails";
            this.Size = new System.Drawing.Size(835, 590);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleAndNumber;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelAudio;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button buttonDownloadEpisode;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button buttonPlayEp;
    }
}
