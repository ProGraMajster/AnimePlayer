using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    partial class MerryGoRoundControl
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
            this.panelContent2 = new System.Windows.Forms.Panel();
            this.panelContent3 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.transparentPanel1 = new AnimePlayer.ControlsWinForms.TransparentPanel();
            this.transparentPanel2 = new AnimePlayer.ControlsWinForms.TransparentPanel();
            this.transparentPanel1.SuspendLayout();
            this.transparentPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(-200, 310);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(200, 100);
            this.panelContent.TabIndex = 0;
            // 
            // panelContent2
            // 
            this.panelContent2.Location = new System.Drawing.Point(780, 98);
            this.panelContent2.Name = "panelContent2";
            this.panelContent2.Size = new System.Drawing.Size(200, 100);
            this.panelContent2.TabIndex = 1;
            // 
            // panelContent3
            // 
            this.panelContent3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContent3.Location = new System.Drawing.Point(16, 18);
            this.panelContent3.Name = "panelContent3";
            this.panelContent3.Size = new System.Drawing.Size(677, 413);
            this.panelContent3.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(2, 198);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(55, 50);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(3, 198);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(55, 50);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.BackColor = System.Drawing.Color.Transparent;
            this.transparentPanel1.Controls.Add(this.buttonBack);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(60, 449);
            this.transparentPanel1.TabIndex = 3;
            // 
            // transparentPanel2
            // 
            this.transparentPanel2.BackColor = System.Drawing.Color.Transparent;
            this.transparentPanel2.Controls.Add(this.buttonNext);
            this.transparentPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.transparentPanel2.Location = new System.Drawing.Point(650, 0);
            this.transparentPanel2.Name = "transparentPanel2";
            this.transparentPanel2.Size = new System.Drawing.Size(60, 449);
            this.transparentPanel2.TabIndex = 4;
            // 
            // MerryGoRoundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.transparentPanel2);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.panelContent2);
            this.Controls.Add(this.panelContent3);
            this.Name = "MerryGoRoundControl";
            this.Size = new System.Drawing.Size(710, 449);
            this.transparentPanel1.ResumeLayout(false);
            this.transparentPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContent;
        private Panel panelContent2;
        private Panel panelContent3;
        private Button buttonBack;
        private Button buttonNext;
        private TransparentPanel transparentPanel1;
        private TransparentPanel transparentPanel2;
    }
}
