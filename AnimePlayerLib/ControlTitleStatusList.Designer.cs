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
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonStartPageFinditem = new System.Windows.Forms.Button();
            this.panelDock = new System.Windows.Forms.Panel();
            this.bWresiezItem = new System.ComponentModel.BackgroundWorker();
            this.panelNavigation.SuspendLayout();
            this.panelDockOnTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelNavigation.Controls.Add(this.panelDockOnTextBox);
            this.panelNavigation.Controls.Add(this.buttonRemoveItem);
            this.panelNavigation.Controls.Add(this.buttonStartPageFinditem);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(538, 34);
            this.panelNavigation.TabIndex = 0;
            // 
            // panelDockOnTextBox
            // 
            this.panelDockOnTextBox.Controls.Add(this.textBoxStartPagefinditem);
            this.panelDockOnTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDockOnTextBox.Location = new System.Drawing.Point(75, 0);
            this.panelDockOnTextBox.Name = "panelDockOnTextBox";
            this.panelDockOnTextBox.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelDockOnTextBox.Size = new System.Drawing.Size(388, 34);
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
            this.textBoxStartPagefinditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxStartPagefinditem.ForeColor = System.Drawing.Color.White;
            this.textBoxStartPagefinditem.Location = new System.Drawing.Point(0, 10);
            this.textBoxStartPagefinditem.Name = "textBoxStartPagefinditem";
            this.textBoxStartPagefinditem.Size = new System.Drawing.Size(388, 16);
            this.textBoxStartPagefinditem.TabIndex = 6;
            this.textBoxStartPagefinditem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRemoveItem.FlatAppearance.BorderSize = 0;
            this.buttonRemoveItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveItem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemoveItem.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveItem.Location = new System.Drawing.Point(0, 0);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(75, 34);
            this.buttonRemoveItem.TabIndex = 8;
            this.buttonRemoveItem.Text = "Usuń";
            this.buttonRemoveItem.UseVisualStyleBackColor = false;
            // 
            // buttonStartPageFinditem
            // 
            this.buttonStartPageFinditem.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartPageFinditem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStartPageFinditem.FlatAppearance.BorderSize = 0;
            this.buttonStartPageFinditem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonStartPageFinditem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonStartPageFinditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartPageFinditem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartPageFinditem.ForeColor = System.Drawing.Color.White;
            this.buttonStartPageFinditem.Location = new System.Drawing.Point(463, 0);
            this.buttonStartPageFinditem.Name = "buttonStartPageFinditem";
            this.buttonStartPageFinditem.Size = new System.Drawing.Size(75, 34);
            this.buttonStartPageFinditem.TabIndex = 5;
            this.buttonStartPageFinditem.Text = "Szukaj";
            this.buttonStartPageFinditem.UseVisualStyleBackColor = false;
            this.buttonStartPageFinditem.Visible = false;
            // 
            // panelDock
            // 
            this.panelDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDock.Location = new System.Drawing.Point(0, 34);
            this.panelDock.Name = "panelDock";
            this.panelDock.Size = new System.Drawing.Size(538, 345);
            this.panelDock.TabIndex = 1;
            // 
            // bWresiezItem
            // 
            this.bWresiezItem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWresiezItem_DoWork);
            // 
            // ControlTitleStatusList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.panelDock);
            this.Controls.Add(this.panelNavigation);
            this.DoubleBuffered = true;
            this.Name = "ControlTitleStatusList";
            this.Size = new System.Drawing.Size(538, 379);
            this.Load += new System.EventHandler(this.ControlTitleStatusList_Load);
            this.panelNavigation.ResumeLayout(false);
            this.panelDockOnTextBox.ResumeLayout(false);
            this.panelDockOnTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        public System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Panel panelDockOnTextBox;
        public System.Windows.Forms.TextBox textBoxStartPagefinditem;
        public System.Windows.Forms.Button buttonStartPageFinditem;
        private System.Windows.Forms.Panel panelDock;
        private System.ComponentModel.BackgroundWorker bWresiezItem;
    }
}
