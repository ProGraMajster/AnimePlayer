namespace AnimePlayerLibrary.UI
{
    partial class PanelItemViewTypeList
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
            pictureBoxItem = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            newFlowLayoutPanel1 = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            labelDate = new System.Windows.Forms.Label();
            labelType = new System.Windows.Forms.Label();
            labelTitle = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxItem
            // 
            pictureBoxItem.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBoxItem.Location = new System.Drawing.Point(10, 11);
            pictureBoxItem.Name = "pictureBoxItem";
            pictureBoxItem.Size = new System.Drawing.Size(96, 109);
            pictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxItem.TabIndex = 0;
            pictureBoxItem.TabStop = false;
            pictureBoxItem.LoadCompleted += pictureBoxItem_LoadCompleted;
            pictureBoxItem.Click += Object_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(106, 11);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(620, 109);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(newFlowLayoutPanel1);
            panel3.Controls.Add(labelDate);
            panel3.Controls.Add(labelType);
            panel3.Controls.Add(labelTitle);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 0);
            panel3.Size = new System.Drawing.Size(592, 109);
            panel3.TabIndex = 3;
            panel3.Click += Object_Click;
            // 
            // newFlowLayoutPanel1
            // 
            newFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            newFlowLayoutPanel1.Location = new System.Drawing.Point(5, 79);
            newFlowLayoutPanel1.Name = "newFlowLayoutPanel1";
            newFlowLayoutPanel1.Size = new System.Drawing.Size(582, 30);
            newFlowLayoutPanel1.TabIndex = 3;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Dock = System.Windows.Forms.DockStyle.Top;
            labelDate.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDate.ForeColor = System.Drawing.Color.Gainsboro;
            labelDate.Location = new System.Drawing.Point(5, 56);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(41, 17);
            labelDate.TabIndex = 2;
            labelDate.Text = "DATE";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Dock = System.Windows.Forms.DockStyle.Top;
            labelType.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelType.ForeColor = System.Drawing.Color.Gainsboro;
            labelType.Location = new System.Drawing.Point(5, 34);
            labelType.Name = "labelType";
            labelType.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            labelType.Size = new System.Drawing.Size(38, 22);
            labelType.TabIndex = 1;
            labelType.Text = "TYPE";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(5, 6);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            labelTitle.Size = new System.Drawing.Size(60, 28);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "TITLE";
            // 
            // panel2
            // 
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(592, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(28, 109);
            panel2.TabIndex = 2;
            // 
            // PanelItemViewTypeList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            Controls.Add(panel1);
            Controls.Add(pictureBoxItem);
            Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.White;
            Name = "PanelItemViewTypeList";
            Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            Size = new System.Drawing.Size(736, 131);
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private AnimePlayer.ControlsWinForms.NewFlowLayoutPanel newFlowLayoutPanel1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelType;
    }
}
