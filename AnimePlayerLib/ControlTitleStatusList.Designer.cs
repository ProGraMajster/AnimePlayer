namespace AnimePlayerLibrary
{
    partial class ControlTitleStatusList
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
            panelNavigation = new System.Windows.Forms.Panel();
            panelDockOnTextBox = new System.Windows.Forms.Panel();
            textBoxStartPagefinditem = new System.Windows.Forms.TextBox();
            panelEdit = new System.Windows.Forms.Panel();
            buttonRemoveSelected = new System.Windows.Forms.Button();
            buttonEditList = new System.Windows.Forms.Button();
            buttonStartPageFinditem = new System.Windows.Forms.Button();
            panelDock = new System.Windows.Forms.Panel();
            newFlowLayoutPanel1 = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            bWresiezItem = new System.ComponentModel.BackgroundWorker();
            panelNavigation.SuspendLayout();
            panelDockOnTextBox.SuspendLayout();
            panelEdit.SuspendLayout();
            panelDock.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            panelNavigation.Controls.Add(panelDockOnTextBox);
            panelNavigation.Controls.Add(panelEdit);
            panelNavigation.Controls.Add(buttonEditList);
            panelNavigation.Controls.Add(buttonStartPageFinditem);
            panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            panelNavigation.Location = new System.Drawing.Point(0, 0);
            panelNavigation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new System.Drawing.Size(628, 39);
            panelNavigation.TabIndex = 0;
            // 
            // panelDockOnTextBox
            // 
            panelDockOnTextBox.Controls.Add(textBoxStartPagefinditem);
            panelDockOnTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDockOnTextBox.Location = new System.Drawing.Point(149, 0);
            panelDockOnTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelDockOnTextBox.Name = "panelDockOnTextBox";
            panelDockOnTextBox.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            panelDockOnTextBox.Size = new System.Drawing.Size(391, 39);
            panelDockOnTextBox.TabIndex = 7;
            panelDockOnTextBox.Visible = false;
            // 
            // textBoxStartPagefinditem
            // 
            textBoxStartPagefinditem.AutoCompleteCustomSource.AddRange(new string[] { "TEST" });
            textBoxStartPagefinditem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            textBoxStartPagefinditem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            textBoxStartPagefinditem.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            textBoxStartPagefinditem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxStartPagefinditem.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxStartPagefinditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxStartPagefinditem.ForeColor = System.Drawing.Color.White;
            textBoxStartPagefinditem.Location = new System.Drawing.Point(0, 12);
            textBoxStartPagefinditem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxStartPagefinditem.Name = "textBoxStartPagefinditem";
            textBoxStartPagefinditem.Size = new System.Drawing.Size(391, 16);
            textBoxStartPagefinditem.TabIndex = 6;
            textBoxStartPagefinditem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelEdit
            // 
            panelEdit.Controls.Add(buttonRemoveSelected);
            panelEdit.Dock = System.Windows.Forms.DockStyle.Left;
            panelEdit.Location = new System.Drawing.Point(67, 0);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new System.Drawing.Size(82, 39);
            panelEdit.TabIndex = 9;
            panelEdit.Visible = false;
            // 
            // buttonRemoveSelected
            // 
            buttonRemoveSelected.BackColor = System.Drawing.Color.Transparent;
            buttonRemoveSelected.Dock = System.Windows.Forms.DockStyle.Left;
            buttonRemoveSelected.FlatAppearance.BorderSize = 0;
            buttonRemoveSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            buttonRemoveSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            buttonRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRemoveSelected.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRemoveSelected.ForeColor = System.Drawing.Color.White;
            buttonRemoveSelected.Location = new System.Drawing.Point(0, 0);
            buttonRemoveSelected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonRemoveSelected.Name = "buttonRemoveSelected";
            buttonRemoveSelected.Size = new System.Drawing.Size(82, 39);
            buttonRemoveSelected.TabIndex = 9;
            buttonRemoveSelected.Text = "Usuń zaznaczone";
            buttonRemoveSelected.UseVisualStyleBackColor = false;
            buttonRemoveSelected.Click += buttonRemoveSelected_Click;
            // 
            // buttonEditList
            // 
            buttonEditList.BackColor = System.Drawing.Color.Transparent;
            buttonEditList.Dock = System.Windows.Forms.DockStyle.Left;
            buttonEditList.FlatAppearance.BorderSize = 0;
            buttonEditList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            buttonEditList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            buttonEditList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonEditList.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonEditList.ForeColor = System.Drawing.Color.White;
            buttonEditList.Location = new System.Drawing.Point(0, 0);
            buttonEditList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonEditList.Name = "buttonEditList";
            buttonEditList.Size = new System.Drawing.Size(67, 39);
            buttonEditList.TabIndex = 8;
            buttonEditList.Text = "Edytuj";
            buttonEditList.UseVisualStyleBackColor = false;
            buttonEditList.Click += buttonEditList_Click;
            // 
            // buttonStartPageFinditem
            // 
            buttonStartPageFinditem.BackColor = System.Drawing.Color.Transparent;
            buttonStartPageFinditem.Dock = System.Windows.Forms.DockStyle.Right;
            buttonStartPageFinditem.FlatAppearance.BorderSize = 0;
            buttonStartPageFinditem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            buttonStartPageFinditem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            buttonStartPageFinditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonStartPageFinditem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonStartPageFinditem.ForeColor = System.Drawing.Color.White;
            buttonStartPageFinditem.Location = new System.Drawing.Point(540, 0);
            buttonStartPageFinditem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonStartPageFinditem.Name = "buttonStartPageFinditem";
            buttonStartPageFinditem.Size = new System.Drawing.Size(88, 39);
            buttonStartPageFinditem.TabIndex = 5;
            buttonStartPageFinditem.Text = "Szukaj";
            buttonStartPageFinditem.UseVisualStyleBackColor = false;
            buttonStartPageFinditem.Visible = false;
            // 
            // panelDock
            // 
            panelDock.Controls.Add(newFlowLayoutPanel1);
            panelDock.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDock.Location = new System.Drawing.Point(0, 39);
            panelDock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelDock.Name = "panelDock";
            panelDock.Size = new System.Drawing.Size(628, 398);
            panelDock.TabIndex = 1;
            // 
            // newFlowLayoutPanel1
            // 
            newFlowLayoutPanel1.AutoScroll = true;
            newFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            newFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            newFlowLayoutPanel1.Name = "newFlowLayoutPanel1";
            newFlowLayoutPanel1.Size = new System.Drawing.Size(628, 398);
            newFlowLayoutPanel1.TabIndex = 0;
            newFlowLayoutPanel1.SizeChanged += newFlowLayoutPanel1_SizeChanged;
            newFlowLayoutPanel1.ControlAdded += newFlowLayoutPanel1_ControlAdded;
            // 
            // bWresiezItem
            // 
            bWresiezItem.DoWork += BWresiezItem_DoWork;
            // 
            // ControlTitleStatusList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            Controls.Add(panelDock);
            Controls.Add(panelNavigation);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ControlTitleStatusList";
            Size = new System.Drawing.Size(628, 437);
            Load += ControlTitleStatusList_Load;
            panelNavigation.ResumeLayout(false);
            panelDockOnTextBox.ResumeLayout(false);
            panelDockOnTextBox.PerformLayout();
            panelEdit.ResumeLayout(false);
            panelDock.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        public System.Windows.Forms.Button buttonEditList;
        private System.Windows.Forms.Panel panelDockOnTextBox;
        public System.Windows.Forms.TextBox textBoxStartPagefinditem;
        public System.Windows.Forms.Button buttonStartPageFinditem;
        private System.Windows.Forms.Panel panelDock;
        private System.ComponentModel.BackgroundWorker bWresiezItem;
        private AnimePlayer.ControlsWinForms.NewFlowLayoutPanel newFlowLayoutPanel1;
        private System.Windows.Forms.Panel panelEdit;
        public System.Windows.Forms.Button buttonRemoveSelected;
    }
}
