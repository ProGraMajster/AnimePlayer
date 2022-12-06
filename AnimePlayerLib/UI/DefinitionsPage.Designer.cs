using System.Windows.Forms;

namespace AnimePlayerLibrary.UI
{
    partial class DefinitionsPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonFindDefinion = new System.Windows.Forms.Button();
            this.buttonCloseDefinitionsPage = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelF = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.textBoxFind);
            this.panel1.Controls.Add(this.buttonFindDefinion);
            this.panel1.Controls.Add(this.buttonCloseDefinitionsPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.panel1.Size = new System.Drawing.Size(788, 67);
            this.panel1.TabIndex = 1;
            // 
            // textBoxFind
            // 
            this.textBoxFind.BackColor = System.Drawing.Color.Black;
            this.textBoxFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxFind.ForeColor = System.Drawing.Color.White;
            this.textBoxFind.Location = new System.Drawing.Point(20, 31);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(618, 16);
            this.textBoxFind.TabIndex = 0;
            this.textBoxFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonFindDefinion
            // 
            this.buttonFindDefinion.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFindDefinion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindDefinion.Location = new System.Drawing.Point(638, 20);
            this.buttonFindDefinion.Name = "buttonFindDefinion";
            this.buttonFindDefinion.Size = new System.Drawing.Size(75, 27);
            this.buttonFindDefinion.TabIndex = 2;
            this.buttonFindDefinion.Text = "Szukaj";
            this.buttonFindDefinion.UseVisualStyleBackColor = true;
            this.buttonFindDefinion.Click += new System.EventHandler(this.ButtonFindDefinion_Click);
            // 
            // buttonCloseDefinitionsPage
            // 
            this.buttonCloseDefinitionsPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseDefinitionsPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseDefinitionsPage.ForeColor = System.Drawing.Color.Red;
            this.buttonCloseDefinitionsPage.Location = new System.Drawing.Point(713, 20);
            this.buttonCloseDefinitionsPage.Name = "buttonCloseDefinitionsPage";
            this.buttonCloseDefinitionsPage.Size = new System.Drawing.Size(75, 27);
            this.buttonCloseDefinitionsPage.TabIndex = 1;
            this.buttonCloseDefinitionsPage.Text = "Zamknij";
            this.buttonCloseDefinitionsPage.UseVisualStyleBackColor = true;
            this.buttonCloseDefinitionsPage.Click += new System.EventHandler(this.ButtonCloseDefinitionsPage_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 67);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(252, 519);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 67);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(536, 519);
            this.label1.TabIndex = 3;
            this.label1.Text = "N/A";
            // 
            // panelF
            // 
            this.panelF.AutoScroll = true;
            this.panelF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelF.Controls.Add(this.button1);
            this.panelF.Controls.Add(this.label3);
            this.panelF.Controls.Add(this.treeView2);
            this.panelF.Controls.Add(this.label2);
            this.panelF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelF.Location = new System.Drawing.Point(252, 67);
            this.panelF.Name = "panelF";
            this.panelF.Padding = new System.Windows.Forms.Padding(25, 25, 25, 0);
            this.panelF.Size = new System.Drawing.Size(536, 519);
            this.panelF.TabIndex = 3;
            this.panelF.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(195, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 282);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label3.Size = new System.Drawing.Size(486, 237);
            this.label3.TabIndex = 4;
            this.label3.Text = "N/A";
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.Color.Black;
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView2.ForeColor = System.Drawing.Color.White;
            this.treeView2.LineColor = System.Drawing.Color.White;
            this.treeView2.Location = new System.Drawing.Point(25, 51);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(486, 231);
            this.treeView2.TabIndex = 1;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            this.treeView2.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView2_NodeMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wynik wyszukiwania";
            // 
            // DefinitionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.panelF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Name = "DefinitionsPage";
            this.Size = new System.Drawing.Size(788, 586);
            this.Load += new System.EventHandler(this.DefinitionsPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelF.ResumeLayout(false);
            this.panelF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TreeView treeView1;
        private Label label1;
        private TextBox textBoxFind;
        private Button buttonFindDefinion;
        private Button buttonCloseDefinitionsPage;
        private Panel panelF;
        private TreeView treeView2;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
