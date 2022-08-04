
namespace AnimePlayerLibrary.UI
{
    partial class PageEpisode
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
            this.labelEpTitle = new System.Windows.Forms.Label();
            this.labelEpNumber = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonForwardEp = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBackEp = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelViewIcon = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonViewIconClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelViewIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelEpTitle);
            this.panel1.Controls.Add(this.labelEpNumber);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.buttonForwardEp);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonBackEp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12);
            this.panel1.Size = new System.Drawing.Size(712, 168);
            this.panel1.TabIndex = 1;
            // 
            // labelEpTitle
            // 
            this.labelEpTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEpTitle.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEpTitle.ForeColor = System.Drawing.Color.White;
            this.labelEpTitle.Location = new System.Drawing.Point(172, 79);
            this.labelEpTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEpTitle.Name = "labelEpTitle";
            this.labelEpTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelEpTitle.Size = new System.Drawing.Size(449, 43);
            this.labelEpTitle.TabIndex = 6;
            this.labelEpTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEpTitle.Visible = false;
            // 
            // labelEpNumber
            // 
            this.labelEpNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEpNumber.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEpNumber.ForeColor = System.Drawing.Color.White;
            this.labelEpNumber.Location = new System.Drawing.Point(172, 36);
            this.labelEpNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEpNumber.Name = "labelEpNumber";
            this.labelEpNumber.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelEpNumber.Size = new System.Drawing.Size(449, 43);
            this.labelEpNumber.TabIndex = 1;
            this.labelEpNumber.Text = "Odcinek";
            this.labelEpNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(172, 12);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(61, 24);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonForwardEp
            // 
            this.buttonForwardEp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonForwardEp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForwardEp.ForeColor = System.Drawing.Color.White;
            this.buttonForwardEp.Location = new System.Drawing.Point(621, 12);
            this.buttonForwardEp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonForwardEp.Name = "buttonForwardEp";
            this.buttonForwardEp.Size = new System.Drawing.Size(38, 144);
            this.buttonForwardEp.TabIndex = 3;
            this.buttonForwardEp.Text = ">";
            this.buttonForwardEp.UseVisualStyleBackColor = true;
            this.buttonForwardEp.Visible = false;
            this.buttonForwardEp.Click += new System.EventHandler(this.buttonForwardEp_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(659, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.MaximumSize = new System.Drawing.Size(41, 29);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(41, 29);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonBackEp
            // 
            this.buttonBackEp.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBackEp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackEp.ForeColor = System.Drawing.Color.White;
            this.buttonBackEp.Location = new System.Drawing.Point(134, 12);
            this.buttonBackEp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBackEp.Name = "buttonBackEp";
            this.buttonBackEp.Size = new System.Drawing.Size(38, 144);
            this.buttonBackEp.TabIndex = 2;
            this.buttonBackEp.Text = "<";
            this.buttonBackEp.UseVisualStyleBackColor = true;
            this.buttonBackEp.Visible = false;
            this.buttonBackEp.Click += new System.EventHandler(this.buttonBackEp_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 180);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(712, 391);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panelViewIcon
            // 
            this.panelViewIcon.Controls.Add(this.pictureBox2);
            this.panelViewIcon.Controls.Add(this.buttonViewIconClose);
            this.panelViewIcon.Location = new System.Drawing.Point(70, 23);
            this.panelViewIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelViewIcon.Name = "panelViewIcon";
            this.panelViewIcon.Size = new System.Drawing.Size(666, 560);
            this.panelViewIcon.TabIndex = 5;
            this.panelViewIcon.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(625, 560);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // buttonViewIconClose
            // 
            this.buttonViewIconClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonViewIconClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewIconClose.ForeColor = System.Drawing.Color.White;
            this.buttonViewIconClose.Location = new System.Drawing.Point(625, 0);
            this.buttonViewIconClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonViewIconClose.MaximumSize = new System.Drawing.Size(41, 29);
            this.buttonViewIconClose.Name = "buttonViewIconClose";
            this.buttonViewIconClose.Size = new System.Drawing.Size(41, 29);
            this.buttonViewIconClose.TabIndex = 6;
            this.buttonViewIconClose.Text = "X";
            this.buttonViewIconClose.UseVisualStyleBackColor = true;
            this.buttonViewIconClose.Click += new System.EventHandler(this.buttonViewIconClose_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(12, 571);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(712, 40);
            this.panel4.TabIndex = 0;
            // 
            // PageEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelViewIcon);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PageEpisode";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(562, 394);
            this.Resize += new System.EventHandler(this.PageEpisode_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelViewIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEpNumber;
        private System.Windows.Forms.Button buttonForwardEp;
        private System.Windows.Forms.Button buttonBackEp;
        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelViewIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonViewIconClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelEpTitle;
    }
}
