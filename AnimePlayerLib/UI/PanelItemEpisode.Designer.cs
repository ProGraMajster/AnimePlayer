namespace AnimePlayerLibrary.UI
{
    partial class PanelItemEpisode
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
            this.buttonPlayEpisode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleAndNumber
            // 
            this.labelTitleAndNumber.AutoEllipsis = true;
            this.labelTitleAndNumber.AutoSize = true;
            this.labelTitleAndNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitleAndNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitleAndNumber.Location = new System.Drawing.Point(5, 5);
            this.labelTitleAndNumber.MaximumSize = new System.Drawing.Size(490, 0);
            this.labelTitleAndNumber.Name = "labelTitleAndNumber";
            this.labelTitleAndNumber.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.labelTitleAndNumber.Size = new System.Drawing.Size(87, 30);
            this.labelTitleAndNumber.TabIndex = 1;
            this.labelTitleAndNumber.Text = "labelName";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(5, 35);
            this.labelType.Name = "labelType";
            this.labelType.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.labelType.Size = new System.Drawing.Size(78, 30);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "labelType";
            // 
            // labelAudio
            // 
            this.labelAudio.AutoSize = true;
            this.labelAudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAudio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAudio.Location = new System.Drawing.Point(5, 65);
            this.labelAudio.Name = "labelAudio";
            this.labelAudio.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.labelAudio.Size = new System.Drawing.Size(87, 30);
            this.labelAudio.TabIndex = 5;
            this.labelAudio.Text = "labelAudio";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubtitle.Location = new System.Drawing.Point(5, 95);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.labelSubtitle.Size = new System.Drawing.Size(98, 30);
            this.labelSubtitle.TabIndex = 6;
            this.labelSubtitle.Text = "labelSubtitle";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLabel1.LinkColor = System.Drawing.Color.Aqua;
            this.linkLabel1.Location = new System.Drawing.Point(5, 125);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.linkLabel1.Size = new System.Drawing.Size(75, 29);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(5, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(490, 69);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // buttonPlayEpisode
            // 
            this.buttonPlayEpisode.BackColor = System.Drawing.Color.Black;
            this.buttonPlayEpisode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayEpisode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlayEpisode.Location = new System.Drawing.Point(395, 114);
            this.buttonPlayEpisode.Name = "buttonPlayEpisode";
            this.buttonPlayEpisode.Size = new System.Drawing.Size(100, 34);
            this.buttonPlayEpisode.TabIndex = 9;
            this.buttonPlayEpisode.Text = "Oglądaj >";
            this.buttonPlayEpisode.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(305, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Pobierz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // PanelItemEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPlayEpisode);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelAudio);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTitleAndNumber);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PanelItemEpisode";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(500, 228);
            this.Load += new System.EventHandler(this.PanelItemEpisode_Load);
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
        public System.Windows.Forms.Button buttonPlayEpisode;
        public System.Windows.Forms.Button button1;
    }
}
