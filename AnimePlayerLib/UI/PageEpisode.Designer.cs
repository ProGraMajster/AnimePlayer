
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            labelEpTitle = new System.Windows.Forms.Label();
            labelEpNumber = new System.Windows.Forms.Label();
            labelTitle = new System.Windows.Forms.Label();
            buttonForwardEp = new System.Windows.Forms.Button();
            buttonClose = new System.Windows.Forms.Button();
            buttonBackEp = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            panelViewIcon = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            buttonViewIconClose = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panelSort = new System.Windows.Forms.Panel();
            labelSortLoading = new System.Windows.Forms.Label();
            comboBoxSort = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelViewIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panelSort.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(122, 144);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelEpTitle);
            panel1.Controls.Add(labelEpNumber);
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(buttonForwardEp);
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(buttonBackEp);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(12);
            panel1.Size = new System.Drawing.Size(1008, 168);
            panel1.TabIndex = 1;
            // 
            // labelEpTitle
            // 
            labelEpTitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelEpTitle.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEpTitle.ForeColor = System.Drawing.Color.White;
            labelEpTitle.Location = new System.Drawing.Point(172, 79);
            labelEpTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelEpTitle.Name = "labelEpTitle";
            labelEpTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            labelEpTitle.Size = new System.Drawing.Size(745, 43);
            labelEpTitle.TabIndex = 6;
            labelEpTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelEpTitle.Visible = false;
            // 
            // labelEpNumber
            // 
            labelEpNumber.Dock = System.Windows.Forms.DockStyle.Top;
            labelEpNumber.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEpNumber.ForeColor = System.Drawing.Color.White;
            labelEpNumber.Location = new System.Drawing.Point(172, 36);
            labelEpNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelEpNumber.Name = "labelEpNumber";
            labelEpNumber.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            labelEpNumber.Size = new System.Drawing.Size(745, 43);
            labelEpNumber.TabIndex = 1;
            labelEpNumber.Text = "Odcinek";
            labelEpNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTitle.ForeColor = System.Drawing.Color.White;
            labelTitle.Location = new System.Drawing.Point(172, 12);
            labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            labelTitle.Size = new System.Drawing.Size(61, 24);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Title";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonForwardEp
            // 
            buttonForwardEp.Dock = System.Windows.Forms.DockStyle.Right;
            buttonForwardEp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonForwardEp.ForeColor = System.Drawing.Color.White;
            buttonForwardEp.Location = new System.Drawing.Point(917, 12);
            buttonForwardEp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonForwardEp.Name = "buttonForwardEp";
            buttonForwardEp.Size = new System.Drawing.Size(38, 144);
            buttonForwardEp.TabIndex = 3;
            buttonForwardEp.Text = ">";
            toolTip1.SetToolTip(buttonForwardEp, "Następny odcinek");
            buttonForwardEp.UseVisualStyleBackColor = true;
            buttonForwardEp.Visible = false;
            buttonForwardEp.Click += ButtonForwardEp_Click;
            // 
            // buttonClose
            // 
            buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonClose.ForeColor = System.Drawing.Color.Red;
            buttonClose.Location = new System.Drawing.Point(955, 12);
            buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonClose.MaximumSize = new System.Drawing.Size(41, 29);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(41, 29);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ButtonClose_Click;
            // 
            // buttonBackEp
            // 
            buttonBackEp.Dock = System.Windows.Forms.DockStyle.Left;
            buttonBackEp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBackEp.ForeColor = System.Drawing.Color.White;
            buttonBackEp.Location = new System.Drawing.Point(134, 12);
            buttonBackEp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonBackEp.Name = "buttonBackEp";
            buttonBackEp.Size = new System.Drawing.Size(38, 144);
            buttonBackEp.TabIndex = 2;
            buttonBackEp.Text = "<";
            toolTip1.SetToolTip(buttonBackEp, "Poprzedni odcinek");
            buttonBackEp.UseVisualStyleBackColor = true;
            buttonBackEp.Visible = false;
            buttonBackEp.Click += ButtonBackEp_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(38, 38, 38);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            flowLayoutPanel1.Size = new System.Drawing.Size(1008, 374);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panelViewIcon
            // 
            panelViewIcon.Controls.Add(pictureBox2);
            panelViewIcon.Controls.Add(buttonViewIconClose);
            panelViewIcon.Location = new System.Drawing.Point(70, 23);
            panelViewIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelViewIcon.Name = "panelViewIcon";
            panelViewIcon.Size = new System.Drawing.Size(666, 560);
            panelViewIcon.TabIndex = 5;
            panelViewIcon.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(625, 560);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // buttonViewIconClose
            // 
            buttonViewIconClose.Dock = System.Windows.Forms.DockStyle.Right;
            buttonViewIconClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonViewIconClose.ForeColor = System.Drawing.Color.White;
            buttonViewIconClose.Location = new System.Drawing.Point(625, 0);
            buttonViewIconClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonViewIconClose.MaximumSize = new System.Drawing.Size(41, 29);
            buttonViewIconClose.Name = "buttonViewIconClose";
            buttonViewIconClose.Size = new System.Drawing.Size(41, 29);
            buttonViewIconClose.TabIndex = 6;
            buttonViewIconClose.Text = "X";
            buttonViewIconClose.UseVisualStyleBackColor = true;
            buttonViewIconClose.Click += ButtonViewIconClose_Click;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel4.Location = new System.Drawing.Point(12, 584);
            panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(1008, 40);
            panel4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(panelSort);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(12, 180);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1008, 404);
            panel2.TabIndex = 0;
            // 
            // panelSort
            // 
            panelSort.Controls.Add(labelSortLoading);
            panelSort.Controls.Add(comboBoxSort);
            panelSort.Controls.Add(label1);
            panelSort.Dock = System.Windows.Forms.DockStyle.Top;
            panelSort.Location = new System.Drawing.Point(0, 0);
            panelSort.Name = "panelSort";
            panelSort.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            panelSort.Size = new System.Drawing.Size(1008, 30);
            panelSort.TabIndex = 0;
            panelSort.Visible = false;
            // 
            // labelSortLoading
            // 
            labelSortLoading.Dock = System.Windows.Forms.DockStyle.Left;
            labelSortLoading.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSortLoading.ForeColor = System.Drawing.Color.White;
            labelSortLoading.Location = new System.Drawing.Point(172, 5);
            labelSortLoading.Name = "labelSortLoading";
            labelSortLoading.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            labelSortLoading.Size = new System.Drawing.Size(104, 20);
            labelSortLoading.TabIndex = 2;
            labelSortLoading.Text = "Ładowanie...";
            labelSortLoading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelSortLoading.Visible = false;
            // 
            // comboBoxSort
            // 
            comboBoxSort.BackColor = System.Drawing.Color.Black;
            comboBoxSort.Dock = System.Windows.Forms.DockStyle.Left;
            comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxSort.ForeColor = System.Drawing.Color.White;
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "Wszystko", "Napisy PL", "Lektor PL" });
            comboBoxSort.Location = new System.Drawing.Point(78, 5);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new System.Drawing.Size(94, 23);
            comboBoxSort.TabIndex = 1;
            toolTip1.SetToolTip(comboBoxSort, "Sortowanie odcinków");
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(15, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Pokaż:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PageEpisode
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panelViewIcon);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "PageEpisode";
            Padding = new System.Windows.Forms.Padding(12);
            Size = new System.Drawing.Size(1032, 636);
            Resize += PageEpisode_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelViewIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panelSort.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSort;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSortLoading;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
