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
            labelTitleAndNumber = new System.Windows.Forms.Label();
            labelType = new System.Windows.Forms.Label();
            labelAudio = new System.Windows.Forms.Label();
            labelSubtitle = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            buttonPlayEpisode = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelTitleAndNumber
            // 
            labelTitleAndNumber.AutoEllipsis = true;
            labelTitleAndNumber.AutoSize = true;
            labelTitleAndNumber.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitleAndNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTitleAndNumber.Location = new System.Drawing.Point(5, 5);
            labelTitleAndNumber.MaximumSize = new System.Drawing.Size(490, 0);
            labelTitleAndNumber.Name = "labelTitleAndNumber";
            labelTitleAndNumber.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labelTitleAndNumber.Size = new System.Drawing.Size(87, 30);
            labelTitleAndNumber.TabIndex = 1;
            labelTitleAndNumber.Text = "labelName";
            labelTitleAndNumber.DoubleClick += PanelItemEpisode_DoubleClick;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Dock = System.Windows.Forms.DockStyle.Top;
            labelType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelType.Location = new System.Drawing.Point(5, 35);
            labelType.Name = "labelType";
            labelType.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labelType.Size = new System.Drawing.Size(78, 30);
            labelType.TabIndex = 4;
            labelType.Text = "labelType";
            labelType.DoubleClick += PanelItemEpisode_DoubleClick;
            // 
            // labelAudio
            // 
            labelAudio.AutoSize = true;
            labelAudio.Dock = System.Windows.Forms.DockStyle.Top;
            labelAudio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelAudio.Location = new System.Drawing.Point(5, 65);
            labelAudio.Name = "labelAudio";
            labelAudio.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labelAudio.Size = new System.Drawing.Size(87, 30);
            labelAudio.TabIndex = 5;
            labelAudio.Text = "labelAudio";
            labelAudio.DoubleClick += PanelItemEpisode_DoubleClick;
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSubtitle.Location = new System.Drawing.Point(5, 95);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labelSubtitle.Size = new System.Drawing.Size(98, 30);
            labelSubtitle.TabIndex = 6;
            labelSubtitle.Text = "labelSubtitle";
            labelSubtitle.DoubleClick += PanelItemEpisode_DoubleClick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            linkLabel1.LinkColor = System.Drawing.Color.Aqua;
            linkLabel1.Location = new System.Drawing.Point(5, 125);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            linkLabel1.Size = new System.Drawing.Size(75, 29);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.Color.Black;
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.ForeColor = System.Drawing.Color.White;
            richTextBox1.Location = new System.Drawing.Point(5, 154);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(490, 69);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            richTextBox1.LinkClicked += richTextBox1_LinkClicked;
            richTextBox1.DoubleClick += PanelItemEpisode_DoubleClick;
            // 
            // buttonPlayEpisode
            // 
            buttonPlayEpisode.BackColor = System.Drawing.Color.Black;
            buttonPlayEpisode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonPlayEpisode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonPlayEpisode.Location = new System.Drawing.Point(395, 114);
            buttonPlayEpisode.Name = "buttonPlayEpisode";
            buttonPlayEpisode.Size = new System.Drawing.Size(100, 34);
            buttonPlayEpisode.TabIndex = 9;
            buttonPlayEpisode.Text = "Oglądaj >";
            buttonPlayEpisode.UseVisualStyleBackColor = false;
            // 
            // PanelItemEpisode
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            Controls.Add(buttonPlayEpisode);
            Controls.Add(richTextBox1);
            Controls.Add(linkLabel1);
            Controls.Add(labelSubtitle);
            Controls.Add(labelAudio);
            Controls.Add(labelType);
            Controls.Add(labelTitleAndNumber);
            ForeColor = System.Drawing.Color.White;
            Name = "PanelItemEpisode";
            Padding = new System.Windows.Forms.Padding(5);
            Size = new System.Drawing.Size(500, 228);
            Load += PanelItemEpisode_Load;
            DoubleClick += PanelItemEpisode_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelTitleAndNumber;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelAudio;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button buttonPlayEpisode;
    }
}
