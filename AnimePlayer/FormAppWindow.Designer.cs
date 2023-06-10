using System.Windows.Forms;

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
            panelNavigation = new Panel();
            buttonOptions = new Button();
            buttonMin = new Button();
            buttonMax = new Button();
            buttonClose = new Button();
            labelWindowText = new Label();
            pictureBoxIcon = new PictureBox();
            panelContent = new Panel();
            panelBottom = new Panel();
            panelRightBottom = new Panel();
            panelLeftBottom = new Panel();
            panelWindowMenu = new Panel();
            buttonContentReload = new Button();
            checkBoxTopMost = new CheckBox();
            buttonHideMenu = new Button();
            panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panelBottom.SuspendLayout();
            panelWindowMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            panelNavigation.Controls.Add(buttonOptions);
            panelNavigation.Controls.Add(buttonMin);
            panelNavigation.Controls.Add(buttonMax);
            panelNavigation.Controls.Add(buttonClose);
            panelNavigation.Controls.Add(labelWindowText);
            panelNavigation.Controls.Add(pictureBoxIcon);
            panelNavigation.Dock = DockStyle.Top;
            panelNavigation.ForeColor = System.Drawing.Color.White;
            panelNavigation.Location = new System.Drawing.Point(0, 0);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new System.Drawing.Size(800, 24);
            panelNavigation.TabIndex = 0;
            panelNavigation.DoubleClick += PanelNavigation_DoubleClick;
            panelNavigation.MouseDown += PanelNavigation_MouseDown;
            panelNavigation.MouseMove += PanelNavigation_MouseMove;
            panelNavigation.MouseUp += panelNavigation_MouseUp;
            // 
            // buttonOptions
            // 
            buttonOptions.BackColor = System.Drawing.Color.FromArgb(200, 25, 25, 25);
            buttonOptions.Dock = DockStyle.Right;
            buttonOptions.FlatAppearance.BorderSize = 0;
            buttonOptions.FlatStyle = FlatStyle.Flat;
            buttonOptions.Location = new System.Drawing.Point(676, 0);
            buttonOptions.Name = "buttonOptions";
            buttonOptions.Size = new System.Drawing.Size(30, 24);
            buttonOptions.TabIndex = 5;
            buttonOptions.Text = "=";
            buttonOptions.UseVisualStyleBackColor = false;
            buttonOptions.Click += ButtonOptions_Click;
            // 
            // buttonMin
            // 
            buttonMin.BackColor = System.Drawing.Color.FromArgb(200, 25, 25, 25);
            buttonMin.Dock = DockStyle.Right;
            buttonMin.FlatAppearance.BorderSize = 0;
            buttonMin.FlatStyle = FlatStyle.Flat;
            buttonMin.Location = new System.Drawing.Point(706, 0);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new System.Drawing.Size(30, 24);
            buttonMin.TabIndex = 4;
            buttonMin.Text = "_";
            buttonMin.UseVisualStyleBackColor = false;
            buttonMin.Click += buttonMin_Click;
            // 
            // buttonMax
            // 
            buttonMax.BackColor = System.Drawing.Color.FromArgb(200, 25, 25, 25);
            buttonMax.Dock = DockStyle.Right;
            buttonMax.FlatAppearance.BorderSize = 0;
            buttonMax.FlatStyle = FlatStyle.Flat;
            buttonMax.Location = new System.Drawing.Point(736, 0);
            buttonMax.Name = "buttonMax";
            buttonMax.Size = new System.Drawing.Size(34, 24);
            buttonMax.TabIndex = 3;
            buttonMax.Text = "[ ]";
            buttonMax.UseVisualStyleBackColor = false;
            buttonMax.Click += ButtonMax_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = System.Drawing.Color.FromArgb(200, 25, 25, 25);
            buttonClose.Dock = DockStyle.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new System.Drawing.Point(770, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(30, 24);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelWindowText
            // 
            labelWindowText.AutoSize = true;
            labelWindowText.BackColor = System.Drawing.Color.FromArgb(150, 25, 25, 25);
            labelWindowText.Dock = DockStyle.Left;
            labelWindowText.Location = new System.Drawing.Point(32, 0);
            labelWindowText.Name = "labelWindowText";
            labelWindowText.Padding = new Padding(0, 5, 0, 5);
            labelWindowText.Size = new System.Drawing.Size(72, 25);
            labelWindowText.TabIndex = 1;
            labelWindowText.Text = "WindowText";
            labelWindowText.MouseDown += PanelNavigation_MouseDown;
            labelWindowText.MouseMove += PanelNavigation_MouseMove;
            labelWindowText.MouseUp += panelNavigation_MouseUp;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.BackColor = System.Drawing.Color.FromArgb(150, 25, 25, 25);
            pictureBoxIcon.Dock = DockStyle.Left;
            pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new System.Drawing.Size(32, 24);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new System.Drawing.Point(0, 24);
            panelContent.Name = "panelContent";
            panelContent.Size = new System.Drawing.Size(800, 426);
            panelContent.TabIndex = 1;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = System.Drawing.SystemColors.Control;
            panelBottom.Controls.Add(panelRightBottom);
            panelBottom.Controls.Add(panelLeftBottom);
            panelBottom.Cursor = Cursors.SizeNS;
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new System.Drawing.Point(0, 445);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new System.Drawing.Size(800, 5);
            panelBottom.TabIndex = 0;
            // 
            // panelRightBottom
            // 
            panelRightBottom.Cursor = Cursors.SizeNWSE;
            panelRightBottom.Dock = DockStyle.Right;
            panelRightBottom.Location = new System.Drawing.Point(795, 0);
            panelRightBottom.Name = "panelRightBottom";
            panelRightBottom.Size = new System.Drawing.Size(5, 5);
            panelRightBottom.TabIndex = 1;
            panelRightBottom.MouseDown += PanelLeftBottom_MouseDown;
            panelRightBottom.MouseMove += PanelLeftBottom_MouseMove;
            panelRightBottom.MouseUp += PanelLeftBottom_MouseUp;
            // 
            // panelLeftBottom
            // 
            panelLeftBottom.Cursor = Cursors.SizeNESW;
            panelLeftBottom.Dock = DockStyle.Left;
            panelLeftBottom.Location = new System.Drawing.Point(0, 0);
            panelLeftBottom.Name = "panelLeftBottom";
            panelLeftBottom.Size = new System.Drawing.Size(5, 5);
            panelLeftBottom.TabIndex = 0;
            panelLeftBottom.MouseDown += PanelLeftBottom_MouseDown;
            panelLeftBottom.MouseMove += PanelLeftBottom_MouseMove;
            panelLeftBottom.MouseUp += PanelLeftBottom_MouseUp;
            // 
            // panelWindowMenu
            // 
            panelWindowMenu.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            panelWindowMenu.Controls.Add(buttonContentReload);
            panelWindowMenu.Controls.Add(checkBoxTopMost);
            panelWindowMenu.Controls.Add(buttonHideMenu);
            panelWindowMenu.ForeColor = System.Drawing.Color.White;
            panelWindowMenu.Location = new System.Drawing.Point(0, 0);
            panelWindowMenu.Name = "panelWindowMenu";
            panelWindowMenu.Size = new System.Drawing.Size(152, 91);
            panelWindowMenu.TabIndex = 0;
            panelWindowMenu.Visible = false;
            // 
            // buttonContentReload
            // 
            buttonContentReload.Dock = DockStyle.Top;
            buttonContentReload.FlatStyle = FlatStyle.Flat;
            buttonContentReload.ForeColor = System.Drawing.Color.White;
            buttonContentReload.Location = new System.Drawing.Point(0, 42);
            buttonContentReload.Name = "buttonContentReload";
            buttonContentReload.Size = new System.Drawing.Size(152, 46);
            buttonContentReload.TabIndex = 2;
            buttonContentReload.Text = "Załaduj ponownie zawartość okna";
            buttonContentReload.UseVisualStyleBackColor = true;
            buttonContentReload.Click += ButtonContentReload_Click;
            // 
            // checkBoxTopMost
            // 
            checkBoxTopMost.AutoSize = true;
            checkBoxTopMost.Dock = DockStyle.Top;
            checkBoxTopMost.Location = new System.Drawing.Point(0, 23);
            checkBoxTopMost.Name = "checkBoxTopMost";
            checkBoxTopMost.Size = new System.Drawing.Size(152, 19);
            checkBoxTopMost.TabIndex = 0;
            checkBoxTopMost.Text = "Zawsze na wierzchu";
            checkBoxTopMost.UseVisualStyleBackColor = true;
            checkBoxTopMost.CheckedChanged += CheckBoxTopMost_CheckedChanged;
            // 
            // buttonHideMenu
            // 
            buttonHideMenu.Dock = DockStyle.Top;
            buttonHideMenu.FlatStyle = FlatStyle.Flat;
            buttonHideMenu.ForeColor = System.Drawing.Color.Red;
            buttonHideMenu.Location = new System.Drawing.Point(0, 0);
            buttonHideMenu.Name = "buttonHideMenu";
            buttonHideMenu.Size = new System.Drawing.Size(152, 23);
            buttonHideMenu.TabIndex = 1;
            buttonHideMenu.Text = "X";
            buttonHideMenu.UseVisualStyleBackColor = true;
            buttonHideMenu.Click += ButtonHideMenu_Click;
            // 
            // FormAppWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panelWindowMenu);
            Controls.Add(panelBottom);
            Controls.Add(panelContent);
            Controls.Add(panelNavigation);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAppWindow";
            Text = "AppWindowName";
            SizeChanged += FormAppWindow_SizeChanged;
            TextChanged += FormAppWindow_TextChanged;
            Resize += FormAppWindow_Resize;
            panelNavigation.ResumeLayout(false);
            panelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panelBottom.ResumeLayout(false);
            panelWindowMenu.ResumeLayout(false);
            panelWindowMenu.PerformLayout();
            ResumeLayout(false);
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