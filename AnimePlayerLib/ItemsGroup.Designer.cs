
namespace AnimePlayerLibrary
{
    partial class ItemsGroup
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitleGroup = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTitleGroup);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.panelTop.Size = new System.Drawing.Size(1086, 35);
            this.panelTop.TabIndex = 3;
            // 
            // labelTitleGroup
            // 
            this.labelTitleGroup.AutoSize = true;
            this.labelTitleGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleGroup.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitleGroup.ForeColor = System.Drawing.Color.White;
            this.labelTitleGroup.Location = new System.Drawing.Point(12, 0);
            this.labelTitleGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleGroup.Name = "labelTitleGroup";
            this.labelTitleGroup.Size = new System.Drawing.Size(112, 28);
            this.labelTitleGroup.TabIndex = 0;
            this.labelTitleGroup.Text = "TitleGroup";
            this.labelTitleGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemsGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ItemsGroup";
            this.Size = new System.Drawing.Size(1086, 342);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.Label labelTitleGroup;
    }
}
