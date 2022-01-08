namespace AnimePlayerLibrary
{
    partial class PanelRelatedSeries
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.labelTypetitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 30);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(170, 240);
            this.panelContent.TabIndex = 0;
            // 
            // labelTypetitle
            // 
            this.labelTypetitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTypetitle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypetitle.ForeColor = System.Drawing.Color.White;
            this.labelTypetitle.Location = new System.Drawing.Point(0, 0);
            this.labelTypetitle.Name = "labelTypetitle";
            this.labelTypetitle.Size = new System.Drawing.Size(170, 30);
            this.labelTypetitle.TabIndex = 0;
            this.labelTypetitle.Text = "Powiązana seria";
            this.labelTypetitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelRelatedSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.labelTypetitle);
            this.Name = "PanelRelatedSeries";
            this.Size = new System.Drawing.Size(170, 270);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelContent;
        public System.Windows.Forms.Label labelTypetitle;
    }
}
