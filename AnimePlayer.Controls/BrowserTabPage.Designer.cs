namespace AnimePlayer.ControlsWinForms
{
    partial class BrowserTabPage
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
            this.newFlowLayoutPanel1 = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.buttonViewAllPage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNewPage = new System.Windows.Forms.Button();
            this.newFlowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newFlowLayoutPanel1
            // 
            this.newFlowLayoutPanel1.Controls.Add(this.buttonNewPage);
            this.newFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.newFlowLayoutPanel1.Name = "newFlowLayoutPanel1";
            this.newFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.newFlowLayoutPanel1.Size = new System.Drawing.Size(638, 42);
            this.newFlowLayoutPanel1.TabIndex = 0;
            // 
            // buttonViewAllPage
            // 
            this.buttonViewAllPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonViewAllPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonViewAllPage.FlatAppearance.BorderSize = 0;
            this.buttonViewAllPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewAllPage.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonViewAllPage.ForeColor = System.Drawing.Color.White;
            this.buttonViewAllPage.Location = new System.Drawing.Point(10, 10);
            this.buttonViewAllPage.Name = "buttonViewAllPage";
            this.buttonViewAllPage.Size = new System.Drawing.Size(24, 22);
            this.buttonViewAllPage.TabIndex = 0;
            this.buttonViewAllPage.Text = "\\/";
            this.buttonViewAllPage.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonViewAllPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(594, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(44, 42);
            this.panel1.TabIndex = 1;
            // 
            // buttonNewPage
            // 
            this.buttonNewPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonNewPage.FlatAppearance.BorderSize = 0;
            this.buttonNewPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewPage.ForeColor = System.Drawing.Color.White;
            this.buttonNewPage.Location = new System.Drawing.Point(8, 8);
            this.buttonNewPage.Name = "buttonNewPage";
            this.buttonNewPage.Size = new System.Drawing.Size(40, 30);
            this.buttonNewPage.TabIndex = 1;
            this.buttonNewPage.Text = "+";
            this.buttonNewPage.UseVisualStyleBackColor = false;
            this.buttonNewPage.Click += new System.EventHandler(this.buttonNewPage_Click);
            // 
            // BrowserTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newFlowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "BrowserTabPage";
            this.Size = new System.Drawing.Size(638, 42);
            this.newFlowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NewFlowLayoutPanel newFlowLayoutPanel1;
        private Button buttonViewAllPage;
        private Panel panel1;
        private Button buttonNewPage;
    }
}
