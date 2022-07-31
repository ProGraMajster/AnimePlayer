using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    partial class BrowserTabPage
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
            this.newFlowLayoutPanelPages = new AnimePlayer.ControlsWinForms.NewFlowLayoutPanel();
            this.buttonNewPage = new System.Windows.Forms.Button();
            this.buttonViewAllPage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTabPageValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.newFlowLayoutPanelPages.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newFlowLayoutPanelPages
            // 
            this.newFlowLayoutPanelPages.Controls.Add(this.buttonNewPage);
            this.newFlowLayoutPanelPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFlowLayoutPanelPages.Location = new System.Drawing.Point(0, 0);
            this.newFlowLayoutPanelPages.Name = "newFlowLayoutPanelPages";
            this.newFlowLayoutPanelPages.Padding = new System.Windows.Forms.Padding(5);
            this.newFlowLayoutPanelPages.Size = new System.Drawing.Size(544, 42);
            this.newFlowLayoutPanelPages.TabIndex = 0;
            this.newFlowLayoutPanelPages.WrapContents = false;
            this.newFlowLayoutPanelPages.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.newFlowLayoutPanelPages_ControlAdded);
            this.newFlowLayoutPanelPages.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.newFlowLayoutPanelPages_ControlRemoved);
            // 
            // buttonNewPage
            // 
            this.buttonNewPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonNewPage.FlatAppearance.BorderSize = 0;
            this.buttonNewPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewPage.ForeColor = System.Drawing.Color.White;
            this.buttonNewPage.Location = new System.Drawing.Point(8, 8);
            this.buttonNewPage.Name = "buttonNewPage";
            this.buttonNewPage.Size = new System.Drawing.Size(40, 30);
            this.buttonNewPage.TabIndex = 1;
            this.buttonNewPage.Text = "+";
            this.buttonNewPage.UseVisualStyleBackColor = false;
            this.buttonNewPage.Click += new System.EventHandler(this.buttonNewPage_Click);
            // 
            // buttonViewAllPage
            // 
            this.buttonViewAllPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonViewAllPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonViewAllPage.FlatAppearance.BorderSize = 0;
            this.buttonViewAllPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewAllPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonViewAllPage.ForeColor = System.Drawing.Color.White;
            this.buttonViewAllPage.Location = new System.Drawing.Point(10, 10);
            this.buttonViewAllPage.Name = "buttonViewAllPage";
            this.buttonViewAllPage.Size = new System.Drawing.Size(24, 22);
            this.buttonViewAllPage.TabIndex = 0;
            this.buttonViewAllPage.Text = "=";
            this.buttonViewAllPage.UseVisualStyleBackColor = false;
            this.buttonViewAllPage.Click += new System.EventHandler(this.buttonViewAllPage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonViewAllPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(594, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(44, 42);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTabPageValue);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(544, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(50, 42);
            this.panel2.TabIndex = 2;
            // 
            // labelTabPageValue
            // 
            this.labelTabPageValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTabPageValue.ForeColor = System.Drawing.Color.White;
            this.labelTabPageValue.Location = new System.Drawing.Point(10, 10);
            this.labelTabPageValue.Name = "labelTabPageValue";
            this.labelTabPageValue.Size = new System.Drawing.Size(30, 22);
            this.labelTabPageValue.TabIndex = 1;
            this.labelTabPageValue.Text = "0";
            this.labelTabPageValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BrowserTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.newFlowLayoutPanelPages);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "BrowserTabPage";
            this.Size = new System.Drawing.Size(638, 42);
            this.Load += new System.EventHandler(this.BrowserTabPage_Load);
            this.newFlowLayoutPanelPages.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonViewAllPage;
        private Panel panel1;
        private Button buttonNewPage;
        public NewFlowLayoutPanel newFlowLayoutPanelPages;
        private Panel panel2;
        private Label labelTabPageValue;
        private Button button1;
    }
}
