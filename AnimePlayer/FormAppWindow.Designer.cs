namespace AnimePlayer
{
    partial class FormAppWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelWindowText = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelRightBottom = new System.Windows.Forms.Panel();
            this.panelLeftBottom = new System.Windows.Forms.Panel();
            this.panelWindowMenu = new System.Windows.Forms.Panel();
            this.buttonContentReload = new System.Windows.Forms.Button();
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.buttonHideMenu = new System.Windows.Forms.Button();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelWindowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelNavigation.Controls.Add(this.buttonOptions);
            this.panelNavigation.Controls.Add(this.buttonMin);
            this.panelNavigation.Controls.Add(this.buttonMax);
            this.panelNavigation.Controls.Add(this.buttonClose);
            this.panelNavigation.Controls.Add(this.labelWindowText);
            this.panelNavigation.Controls.Add(this.pictureBoxIcon);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.ForeColor = System.Drawing.Color.White;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(800, 24);
            this.panelNavigation.TabIndex = 0;
            this.panelNavigation.DoubleClick += new System.EventHandler(this.panelNavigation_DoubleClick);
            this.panelNavigation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNavigation_MouseDown);
            this.panelNavigation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelNavigation_MouseMove);
            this.panelNavigation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelNavigation_MouseUp);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOptions.FlatAppearance.BorderSize = 0;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Location = new System.Drawing.Point(676, 0);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(30, 24);
            this.buttonOptions.TabIndex = 5;
            this.buttonOptions.Text = "=";
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Location = new System.Drawing.Point(706, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(30, 24);
            this.buttonMin.TabIndex = 4;
            this.buttonMin.Text = "_";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMax.FlatAppearance.BorderSize = 0;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Location = new System.Drawing.Point(736, 0);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(34, 24);
            this.buttonMax.TabIndex = 3;
            this.buttonMax.Text = "[ ]";
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(770, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 24);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelWindowText
            // 
            this.labelWindowText.AutoSize = true;
            this.labelWindowText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelWindowText.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelWindowText.Location = new System.Drawing.Point(32, 0);
            this.labelWindowText.Name = "labelWindowText";
            this.labelWindowText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelWindowText.Size = new System.Drawing.Size(72, 25);
            this.labelWindowText.TabIndex = 1;
            this.labelWindowText.Text = "WindowText";
            this.labelWindowText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNavigation_MouseDown);
            this.labelWindowText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelNavigation_MouseMove);
            this.labelWindowText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelNavigation_MouseUp);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(32, 24);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 24);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 426);
            this.panelContent.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.Control;
            this.panelBottom.Controls.Add(this.panelRightBottom);
            this.panelBottom.Controls.Add(this.panelLeftBottom);
            this.panelBottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 445);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 5);
            this.panelBottom.TabIndex = 0;
            // 
            // panelRightBottom
            // 
            this.panelRightBottom.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panelRightBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightBottom.Location = new System.Drawing.Point(795, 0);
            this.panelRightBottom.Name = "panelRightBottom";
            this.panelRightBottom.Size = new System.Drawing.Size(5, 5);
            this.panelRightBottom.TabIndex = 1;
            this.panelRightBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeftBottom_MouseDown);
            this.panelRightBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLeftBottom_MouseMove);
            this.panelRightBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLeftBottom_MouseUp);
            // 
            // panelLeftBottom
            // 
            this.panelLeftBottom.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.panelLeftBottom.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftBottom.Location = new System.Drawing.Point(0, 0);
            this.panelLeftBottom.Name = "panelLeftBottom";
            this.panelLeftBottom.Size = new System.Drawing.Size(5, 5);
            this.panelLeftBottom.TabIndex = 0;
            this.panelLeftBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeftBottom_MouseDown);
            this.panelLeftBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLeftBottom_MouseMove);
            this.panelLeftBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLeftBottom_MouseUp);
            // 
            // panelWindowMenu
            // 
            this.panelWindowMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelWindowMenu.Controls.Add(this.buttonContentReload);
            this.panelWindowMenu.Controls.Add(this.checkBoxTopMost);
            this.panelWindowMenu.Controls.Add(this.buttonHideMenu);
            this.panelWindowMenu.ForeColor = System.Drawing.Color.White;
            this.panelWindowMenu.Location = new System.Drawing.Point(0, 0);
            this.panelWindowMenu.Name = "panelWindowMenu";
            this.panelWindowMenu.Size = new System.Drawing.Size(152, 91);
            this.panelWindowMenu.TabIndex = 0;
            this.panelWindowMenu.Visible = false;
            // 
            // buttonContentReload
            // 
            this.buttonContentReload.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonContentReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContentReload.ForeColor = System.Drawing.Color.White;
            this.buttonContentReload.Location = new System.Drawing.Point(0, 42);
            this.buttonContentReload.Name = "buttonContentReload";
            this.buttonContentReload.Size = new System.Drawing.Size(152, 46);
            this.buttonContentReload.TabIndex = 2;
            this.buttonContentReload.Text = "Załaduj ponownie zawartość okna";
            this.buttonContentReload.UseVisualStyleBackColor = true;
            this.buttonContentReload.Click += new System.EventHandler(this.buttonContentReload_Click);
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxTopMost.Location = new System.Drawing.Point(0, 23);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(152, 19);
            this.checkBoxTopMost.TabIndex = 0;
            this.checkBoxTopMost.Text = "Zawsze na wierzchu";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
            // 
            // buttonHideMenu
            // 
            this.buttonHideMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHideMenu.ForeColor = System.Drawing.Color.Red;
            this.buttonHideMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonHideMenu.Name = "buttonHideMenu";
            this.buttonHideMenu.Size = new System.Drawing.Size(152, 23);
            this.buttonHideMenu.TabIndex = 1;
            this.buttonHideMenu.Text = "X";
            this.buttonHideMenu.UseVisualStyleBackColor = true;
            this.buttonHideMenu.Click += new System.EventHandler(this.buttonHideMenu_Click);
            // 
            // FormAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelWindowMenu);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelNavigation);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAppWindow";
            this.Text = "AppWindowName";
            this.SizeChanged += new System.EventHandler(this.FormAppWindow_SizeChanged);
            this.TextChanged += new System.EventHandler(this.FormAppWindow_TextChanged);
            this.Resize += new System.EventHandler(this.FormAppWindow_Resize);
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelWindowMenu.ResumeLayout(false);
            this.panelWindowMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNavigation;
        private Button buttonOptions;
        private Button buttonMin;
        private Button buttonMax;
        private Button buttonClose;
        public Label labelWindowText;
        public PictureBox pictureBoxIcon;
        public Panel panelContent;
        private Panel panelBottom;
        private Panel panelLeftBottom;
        private Panel panelRightBottom;
        private Panel panelWindowMenu;
        private CheckBox checkBoxTopMost;
        private Button buttonHideMenu;
        private Button buttonContentReload;
    }
}