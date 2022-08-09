namespace AnimePlayer.ControlsWinForms
{
    partial class BrowserTabPageSearchResult
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
            this.newFlowLayoutPanel = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelResultValue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newFlowLayoutPanel
            // 
            this.newFlowLayoutPanel.AutoScroll = true;
            this.newFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.newFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFlowLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.newFlowLayoutPanel.Name = "newFlowLayoutPanel";
            this.newFlowLayoutPanel.Size = new System.Drawing.Size(673, 643);
            this.newFlowLayoutPanel.TabIndex = 0;
            this.newFlowLayoutPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.NewFlowLayoutPanel_ControlAdded);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.labelResultValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(683, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 643);
            this.panel1.TabIndex = 1;
            // 
            // labelResultValue
            // 
            this.labelResultValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelResultValue.Location = new System.Drawing.Point(0, 0);
            this.labelResultValue.Name = "labelResultValue";
            this.labelResultValue.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.labelResultValue.Size = new System.Drawing.Size(200, 33);
            this.labelResultValue.TabIndex = 0;
            this.labelResultValue.Text = "Zanleziono:";
            // 
            // BrowserTabPageSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.newFlowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "BrowserTabPageSearchResult";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(893, 663);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public NewFlowLayoutPanel newFlowLayoutPanel;
        private System.Windows.Forms.Label labelResultValue;
    }
}
