namespace AnimePlayerLibrary
{
    partial class PageTitileStatusList
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button = new System.Windows.Forms.Button();
            this.panelSTLnavigation = new System.Windows.Forms.Panel();
            this.panelSTLnavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 380);
            this.tabControl1.TabIndex = 1;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button.Dock = System.Windows.Forms.DockStyle.Right;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(517, 0);
            this.button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button.MaximumSize = new System.Drawing.Size(175, 29);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(149, 29);
            this.button.TabIndex = 3;
            this.button.Text = "Zamknij stronę";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // panelSTLnavigation
            // 
            this.panelSTLnavigation.Controls.Add(this.button);
            this.panelSTLnavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSTLnavigation.Location = new System.Drawing.Point(0, 0);
            this.panelSTLnavigation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelSTLnavigation.Name = "panelSTLnavigation";
            this.panelSTLnavigation.Size = new System.Drawing.Size(666, 32);
            this.panelSTLnavigation.TabIndex = 0;
            // 
            // PageTitileStatusList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelSTLnavigation);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PageTitileStatusList";
            this.Size = new System.Drawing.Size(666, 412);
            this.Load += new System.EventHandler(this.PageTitileStatusList_Load);
            this.panelSTLnavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Panel panelSTLnavigation;
    }
}
