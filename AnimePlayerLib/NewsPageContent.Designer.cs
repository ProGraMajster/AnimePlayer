namespace AnimePlayerLibrary
{
    partial class NewsPageContent
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
            this.labelLoadingD = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLoadingD
            // 
            this.labelLoadingD.AutoSize = true;
            this.labelLoadingD.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLoadingD.Font = new System.Drawing.Font("Comic Sans MS", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoadingD.ForeColor = System.Drawing.Color.White;
            this.labelLoadingD.Location = new System.Drawing.Point(0, 0);
            this.labelLoadingD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadingD.Name = "labelLoadingD";
            this.labelLoadingD.Size = new System.Drawing.Size(34, 17);
            this.labelLoadingD.TabIndex = 0;
            this.labelLoadingD.Text = "label";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button);
            this.panel1.Controls.Add(this.labelLoadingD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 58);
            this.panel1.TabIndex = 1;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button.Dock = System.Windows.Forms.DockStyle.Right;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button.ForeColor = System.Drawing.Color.Red;
            this.button.Location = new System.Drawing.Point(873, 0);
            this.button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button.MaximumSize = new System.Drawing.Size(117, 52);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(117, 52);
            this.button.TabIndex = 3;
            this.button.Text = "Zamknij stronę";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // NewsPageContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewsPageContent";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 30, 0);
            this.Size = new System.Drawing.Size(1050, 635);
            this.Resize += new System.EventHandler(this.NewsPageContent_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLoadingD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button;
    }
}
