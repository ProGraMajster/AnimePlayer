﻿namespace AnimePlayerLibrary
{
    partial class DynamicContentPage
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
            this.bWLoadContnt = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // bWLoadContnt
            // 
            this.bWLoadContnt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWLoadContnt_DoWork);
            // 
            // DynamicContentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Name = "DynamicContentPage";
            this.Size = new System.Drawing.Size(505, 430);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bWLoadContnt;
    }
}