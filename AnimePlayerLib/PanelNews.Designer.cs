namespace AnimePlayerLibrary
{
    partial class PanelNews
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.item_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 70);
            this.panel1.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(605, 31);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "labelTitle";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.item_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescription.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(0, 31);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelDescription.Size = new System.Drawing.Size(605, 39);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "labelDescription";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDescription.Click += new System.EventHandler(this.item_Click);
            // 
            // PanelNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "PanelNews";
            this.Size = new System.Drawing.Size(605, 304);
            this.SizeChanged += new System.EventHandler(this.PanelNews_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTitle;
    }
}
