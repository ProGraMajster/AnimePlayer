namespace AnimePlayerLibrary.UI
{
    partial class PanelEpisodeGroup
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.newFlowLayoutPanelMoreInformation = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.labelType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Location = new System.Drawing.Point(65, 5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "labelName";
            // 
            // newFlowLayoutPanelMoreInformation
            // 
            this.newFlowLayoutPanelMoreInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFlowLayoutPanelMoreInformation.Location = new System.Drawing.Point(65, 35);
            this.newFlowLayoutPanelMoreInformation.Name = "newFlowLayoutPanelMoreInformation";
            this.newFlowLayoutPanelMoreInformation.Size = new System.Drawing.Size(230, 35);
            this.newFlowLayoutPanelMoreInformation.TabIndex = 2;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelType.Location = new System.Drawing.Point(65, 20);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(38, 15);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "label1";
            // 
            // PanelEpisodeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.newFlowLayoutPanelMoreInformation);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PanelEpisodeGroup";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(300, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private AnimePlayer.ControlsWinForms.NewFlowLayoutPanel newFlowLayoutPanelMoreInformation;
        private System.Windows.Forms.Label labelType;
    }
}
