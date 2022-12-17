namespace AnimePlayerLibrary.UI
{
    partial class PanelEpisodeNumber
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
            this.button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(120, 40);
            this.button.TabIndex = 0;
            this.button.Text = "TEXT";
            this.button.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Green;
            this.label.Dock = System.Windows.Forms.DockStyle.Right;
            this.label.Location = new System.Drawing.Point(101, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(19, 15);
            this.label.TabIndex = 1;
            this.label.Text = "✔";
            this.label.Visible = false;
            // 
            // PanelEpisodeNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.label);
            this.Controls.Add(this.button);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PanelEpisodeNumber";
            this.Size = new System.Drawing.Size(120, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.Button button;
    }
}
