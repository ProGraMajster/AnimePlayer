
namespace AnimePlayerLibrary
{
    partial class ChangeTitleState
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
            this.labelState = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.newFlowLayoutPanel1 = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.newFlowLayoutPanelEpisodes = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSaveChangeState = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Loading = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.newFlowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Loading.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelState
            // 
            this.labelState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelState.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelState.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelState.Location = new System.Drawing.Point(10, 10);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(851, 43);
            this.labelState.TabIndex = 1;
            this.labelState.Text = "Aktualny stan:\r\nbrak ustawionego statnu";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel.Controls.Add(this.buttonClose);
            this.panel.Controls.Add(this.panel1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(5, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(871, 235);
            this.panel.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Firebrick;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(806, 0);
            this.buttonClose.MaximumSize = new System.Drawing.Size(65, 25);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(65, 25);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Anuluj";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelState);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(871, 235);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.newFlowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(10, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 136);
            this.panel3.TabIndex = 6;
            // 
            // newFlowLayoutPanel1
            // 
            this.newFlowLayoutPanel1.Controls.Add(this.panel5);
            this.newFlowLayoutPanel1.Controls.Add(this.panel6);
            this.newFlowLayoutPanel1.Controls.Add(this.panel7);
            this.newFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.newFlowLayoutPanel1.Name = "newFlowLayoutPanel1";
            this.newFlowLayoutPanel1.Size = new System.Drawing.Size(851, 136);
            this.newFlowLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.numericUpDown1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(261, 35);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(198, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "/10";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Black;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(138, 10);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Twoja ocena:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.numericUpDown2);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(270, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 35);
            this.panel6.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.Black;
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown2.ForeColor = System.Drawing.Color.White;
            this.numericUpDown2.Location = new System.Drawing.Point(138, 10);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Obejrzano ponownie:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel7.Controls.Add(this.newFlowLayoutPanelEpisodes);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(537, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(311, 133);
            this.panel7.TabIndex = 2;
            // 
            // newFlowLayoutPanelEpisodes
            // 
            this.newFlowLayoutPanelEpisodes.AutoScroll = true;
            this.newFlowLayoutPanelEpisodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFlowLayoutPanelEpisodes.Location = new System.Drawing.Point(0, 24);
            this.newFlowLayoutPanelEpisodes.Name = "newFlowLayoutPanelEpisodes";
            this.newFlowLayoutPanelEpisodes.Size = new System.Drawing.Size(311, 109);
            this.newFlowLayoutPanelEpisodes.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.buttonSelectAll);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(311, 24);
            this.panel8.TabIndex = 3;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectAll.Location = new System.Drawing.Point(181, 0);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(130, 24);
            this.buttonSelectAll.TabIndex = 2;
            this.buttonSelectAll.Text = "Zaznacz wyszystkie";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Obejrzane odcinki:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSaveChangeState);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 36);
            this.panel2.TabIndex = 5;
            // 
            // buttonSaveChangeState
            // 
            this.buttonSaveChangeState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSaveChangeState.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSaveChangeState.FlatAppearance.BorderSize = 0;
            this.buttonSaveChangeState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChangeState.ForeColor = System.Drawing.Color.White;
            this.buttonSaveChangeState.Location = new System.Drawing.Point(754, 0);
            this.buttonSaveChangeState.Name = "buttonSaveChangeState";
            this.buttonSaveChangeState.Size = new System.Drawing.Size(97, 36);
            this.buttonSaveChangeState.TabIndex = 3;
            this.buttonSaveChangeState.Text = "Zapisz";
            this.buttonSaveChangeState.UseVisualStyleBackColor = false;
            this.buttonSaveChangeState.Click += new System.EventHandler(this.ButtonSaveChangeState_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Brak"});
            this.comboBox1.Location = new System.Drawing.Point(239, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 25);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(233, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 36);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zmień na:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Loading
            // 
            this.Loading.Controls.Add(this.progressBar1);
            this.Loading.Controls.Add(this.label2);
            this.Loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loading.Location = new System.Drawing.Point(5, 5);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(871, 235);
            this.Loading.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 46);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(316, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ładowanie...";
            // 
            // ChangeTitleState
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Loading);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ChangeTitleState";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(881, 245);
            this.Load += new System.EventHandler(this.ChangeTitleState_Load);
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.newFlowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Loading.ResumeLayout(false);
            this.Loading.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonSaveChangeState;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.Panel Loading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel4;
        private AnimePlayer.ControlsWinForms.NewFlowLayoutPanel newFlowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private AnimePlayer.ControlsWinForms.NewFlowLayoutPanel newFlowLayoutPanelEpisodes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonSelectAll;
    }
}
