using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    partial class BrowserTabPageItem
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
            this.pictureBoxItemIcon = new System.Windows.Forms.PictureBox();
            this.labelItemTitle = new System.Windows.Forms.Label();
            this.buttonCloseItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxItemIcon
            // 
            this.pictureBoxItemIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBoxItemIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxItemIcon.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxItemIcon.Name = "pictureBoxItemIcon";
            this.pictureBoxItemIcon.Size = new System.Drawing.Size(34, 25);
            this.pictureBoxItemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxItemIcon.TabIndex = 0;
            this.pictureBoxItemIcon.TabStop = false;
            this.pictureBoxItemIcon.Click += new System.EventHandler(this.pictureBoxItemIcon_Click);
            // 
            // labelItemTitle
            // 
            this.labelItemTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelItemTitle.Location = new System.Drawing.Point(39, 5);
            this.labelItemTitle.Name = "labelItemTitle";
            this.labelItemTitle.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.labelItemTitle.Size = new System.Drawing.Size(159, 25);
            this.labelItemTitle.TabIndex = 1;
            this.labelItemTitle.Text = "ItemTitle";
            this.labelItemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelItemTitle.Click += new System.EventHandler(this.labelItemTitle_Click);
            // 
            // buttonCloseItem
            // 
            this.buttonCloseItem.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseItem.FlatAppearance.BorderSize = 0;
            this.buttonCloseItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseItem.ForeColor = System.Drawing.Color.Red;
            this.buttonCloseItem.Location = new System.Drawing.Point(198, 5);
            this.buttonCloseItem.Name = "buttonCloseItem";
            this.buttonCloseItem.Size = new System.Drawing.Size(25, 25);
            this.buttonCloseItem.TabIndex = 2;
            this.buttonCloseItem.Text = "X";
            this.buttonCloseItem.UseVisualStyleBackColor = false;
            this.buttonCloseItem.Click += new System.EventHandler(this.buttonCloseItem_Click);
            // 
            // BrowserTabPageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.labelItemTitle);
            this.Controls.Add(this.buttonCloseItem);
            this.Controls.Add(this.pictureBoxItemIcon);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "BrowserTabPageItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(228, 35);
            this.Load += new System.EventHandler(this.BrowserTabPageItem_Load);
            this.Resize += new System.EventHandler(this.BrowserTabPageItem_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public PictureBox pictureBoxItemIcon;
        public Label labelItemTitle;
        public Button buttonCloseItem;
    }
}
