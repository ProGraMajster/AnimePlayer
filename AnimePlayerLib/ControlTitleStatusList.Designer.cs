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
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.panelDockOnTextBox = new System.Windows.Forms.Panel();
            this.textBoxStartPagefinditem = new System.Windows.Forms.TextBox();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.buttonEditList = new System.Windows.Forms.Button();
            this.buttonStartPageFinditem = new System.Windows.Forms.Button();
            this.panelDock = new System.Windows.Forms.Panel();
            this.newFlowLayoutPanel1 = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.bWresiezItem = new System.ComponentModel.BackgroundWorker();
            this.panelNavigation.SuspendLayout();
            this.panelDockOnTextBox.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panelDock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelNavigation.Controls.Add(this.panelDockOnTextBox);
            this.panelNavigation.Controls.Add(this.panelEdit);
            this.panelNavigation.Controls.Add(this.buttonEditList);
            this.panelNavigation.Controls.Add(this.buttonStartPageFinditem);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(628, 39);
            this.panelNavigation.TabIndex = 0;
            // 
            // panelDockOnTextBox
            // 
            this.panelDockOnTextBox.Controls.Add(this.textBoxStartPagefinditem);
            this.panelDockOnTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDockOnTextBox.Location = new System.Drawing.Point(149, 0);
            this.panelDockOnTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelDockOnTextBox.Name = "panelDockOnTextBox";
            this.panelDockOnTextBox.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.panelDockOnTextBox.Size = new System.Drawing.Size(391, 39);
            this.panelDockOnTextBox.TabIndex = 7;
            this.panelDockOnTextBox.Visible = false;
            // 
            // textBoxStartPagefinditem
            // 
            this.textBoxStartPagefinditem.AutoCompleteCustomSource.AddRange(new string[] {
            "TEST"});
            this.textBoxStartPagefinditem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxStartPagefinditem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxStartPagefinditem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxStartPagefinditem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartPagefinditem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStartPagefinditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStartPagefinditem.ForeColor = System.Drawing.Color.White;
            this.textBoxStartPagefinditem.Location = new System.Drawing.Point(0, 12);
            this.textBoxStartPagefinditem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStartPagefinditem.Name = "textBoxStartPagefinditem";
            this.textBoxStartPagefinditem.Size = new System.Drawing.Size(391, 16);
            this.textBoxStartPagefinditem.TabIndex = 6;
            this.textBoxStartPagefinditem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.buttonRemoveSelected);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEdit.Location = new System.Drawing.Point(67, 0);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(82, 39);
            this.panelEdit.TabIndex = 9;
            this.panelEdit.Visible = false;
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveSelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRemoveSelected.FlatAppearance.BorderSize = 0;
            this.buttonRemoveSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonRemoveSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSelected.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveSelected.Location = new System.Drawing.Point(0, 0);
            this.buttonRemoveSelected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(82, 39);
            this.buttonRemoveSelected.TabIndex = 9;
            this.buttonRemoveSelected.Text = "Usuń zaznaczone";
            this.buttonRemoveSelected.UseVisualStyleBackColor = false;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // buttonEditList
            // 
            this.buttonEditList.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditList.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonEditList.FlatAppearance.BorderSize = 0;
            this.buttonEditList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonEditList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonEditList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditList.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditList.ForeColor = System.Drawing.Color.White;
            this.buttonEditList.Location = new System.Drawing.Point(0, 0);
            this.buttonEditList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEditList.Name = "buttonEditList";
            this.buttonEditList.Size = new System.Drawing.Size(67, 39);
            this.buttonEditList.TabIndex = 8;
            this.buttonEditList.Text = "Edytuj";
            this.buttonEditList.UseVisualStyleBackColor = false;
            this.buttonEditList.Click += new System.EventHandler(this.buttonEditList_Click);
            // 
            // buttonStartPageFinditem
            // 
            this.buttonStartPageFinditem.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartPageFinditem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStartPageFinditem.FlatAppearance.BorderSize = 0;
            this.buttonStartPageFinditem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonStartPageFinditem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonStartPageFinditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartPageFinditem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartPageFinditem.ForeColor = System.Drawing.Color.White;
            this.buttonStartPageFinditem.Location = new System.Drawing.Point(540, 0);
            this.buttonStartPageFinditem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStartPageFinditem.Name = "buttonStartPageFinditem";
            this.buttonStartPageFinditem.Size = new System.Drawing.Size(88, 39);
            this.buttonStartPageFinditem.TabIndex = 5;
            this.buttonStartPageFinditem.Text = "Szukaj";
            this.buttonStartPageFinditem.UseVisualStyleBackColor = false;
            this.buttonStartPageFinditem.Visible = false;
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.newFlowLayoutPanel1);
            this.panelDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDock.Location = new System.Drawing.Point(0, 39);
            this.panelDock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelDock.Name = "panelDock";
            this.panelDock.Size = new System.Drawing.Size(628, 398);
            this.panelDock.TabIndex = 1;
            // 
            // newFlowLayoutPanel1
            // 
            this.newFlowLayoutPanel1.AutoScroll = true;
            this.newFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.newFlowLayoutPanel1.Name = "newFlowLayoutPanel1";
            this.newFlowLayoutPanel1.Size = new System.Drawing.Size(628, 398);
            this.newFlowLayoutPanel1.TabIndex = 0;
            this.newFlowLayoutPanel1.SizeChanged += new System.EventHandler(this.newFlowLayoutPanel1_SizeChanged);
            this.newFlowLayoutPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.newFlowLayoutPanel1_ControlAdded);
            // 
            // bWresiezItem
            // 
            this.bWresiezItem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWresiezItem_DoWork);
            // 
            // ControlTitleStatusList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.panelDock);
            this.Controls.Add(this.panelNavigation);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ControlTitleStatusList";
            this.Size = new System.Drawing.Size(628, 437);
            this.Load += new System.EventHandler(this.ControlTitleStatusList_Load);
            this.panelNavigation.ResumeLayout(false);
            this.panelDockOnTextBox.ResumeLayout(false);
            this.panelDockOnTextBox.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelDock.ResumeLayout(false);
            this.ResumeLayout(false);

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
