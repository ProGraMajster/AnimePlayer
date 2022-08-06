using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    partial class BrowserTabPageHomePage
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.newFlowLayoutPanel1 = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonFindInInternet = new System.Windows.Forms.Button();
            this.buttonFindInApp = new System.Windows.Forms.Button();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(125, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.panel1.Size = new System.Drawing.Size(594, 449);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.newFlowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 298);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel3.Size = new System.Drawing.Size(594, 151);
            this.panel3.TabIndex = 1;
            // 
            // newFlowLayoutPanel1
            // 
            this.newFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFlowLayoutPanel1.Location = new System.Drawing.Point(0, 15);
            this.newFlowLayoutPanel1.Name = "newFlowLayoutPanel1";
            this.newFlowLayoutPanel1.Size = new System.Drawing.Size(594, 136);
            this.newFlowLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.textBoxMain);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 221);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(50, 10, 50, 5);
            this.panel5.Size = new System.Drawing.Size(594, 77);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.buttonFindInInternet);
            this.panel6.Controls.Add(this.buttonFindInApp);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(50, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(494, 32);
            this.panel6.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "www.google.com"});
            this.comboBox1.Location = new System.Drawing.Point(270, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // buttonFindInInternet
            // 
            this.buttonFindInInternet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.buttonFindInInternet.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonFindInInternet.FlatAppearance.BorderSize = 0;
            this.buttonFindInInternet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindInInternet.ForeColor = System.Drawing.Color.White;
            this.buttonFindInInternet.Location = new System.Drawing.Point(135, 0);
            this.buttonFindInInternet.Name = "buttonFindInInternet";
            this.buttonFindInInternet.Size = new System.Drawing.Size(135, 32);
            this.buttonFindInInternet.TabIndex = 1;
            this.buttonFindInInternet.Text = "Szukaj w internecie";
            this.buttonFindInInternet.UseVisualStyleBackColor = false;
            this.buttonFindInInternet.Click += new System.EventHandler(this.buttonFindInInternet_Click);
            // 
            // buttonFindInApp
            // 
            this.buttonFindInApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.buttonFindInApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonFindInApp.FlatAppearance.BorderSize = 0;
            this.buttonFindInApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindInApp.ForeColor = System.Drawing.Color.White;
            this.buttonFindInApp.Location = new System.Drawing.Point(0, 0);
            this.buttonFindInApp.Name = "buttonFindInApp";
            this.buttonFindInApp.Size = new System.Drawing.Size(135, 32);
            this.buttonFindInApp.TabIndex = 0;
            this.buttonFindInApp.Text = "Szukaj w AnimePlayer";
            this.buttonFindInApp.UseVisualStyleBackColor = false;
            // 
            // textBoxMain
            // 
            this.textBoxMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMain.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMain.ForeColor = System.Drawing.Color.White;
            this.textBoxMain.Location = new System.Drawing.Point(50, 10);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(494, 24);
            this.textBoxMain.TabIndex = 0;
            this.textBoxMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.panel4.Size = new System.Drawing.Size(594, 171);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 151);
            this.label1.TabIndex = 1;
            this.label1.Text = "AnimePlayer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(50, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 399);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 469);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BrowserTabPageHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BrowserTabPageHomePage";
            this.Size = new System.Drawing.Size(845, 469);
            this.Load += new System.EventHandler(this.BrowserTabPageHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private Button buttonFindInInternet;
        private ComboBox comboBox1;
        public Button buttonFindInApp;
        public TextBox textBoxMain;
        private NewFlowLayoutPanel newFlowLayoutPanel1;
    }
}
