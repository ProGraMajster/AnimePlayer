
using AnimePlayerLibrary;

namespace AnimePlayer
{
    partial class ChangeTitleState
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
            this.labelState = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveChangeState = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.comboBoxNewState = new System.Windows.Forms.ComboBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelState
            // 
            this.labelState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelState.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelState.Location = new System.Drawing.Point(13, 19);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(286, 24);
            this.labelState.TabIndex = 1;
            this.labelState.Text = "Aktualny stan: brak ustawionego statnu";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.buttonSaveChangeState);
            this.panel.Controls.Add(this.buttonClose);
            this.panel.Controls.Add(this.labelState);
            this.panel.Controls.Add(this.comboBoxNewState);
            this.panel.Location = new System.Drawing.Point(5, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(350, 200);
            this.panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zmień na:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSaveChangeState
            // 
            this.buttonSaveChangeState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSaveChangeState.FlatAppearance.BorderSize = 0;
            this.buttonSaveChangeState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChangeState.ForeColor = System.Drawing.Color.White;
            this.buttonSaveChangeState.Location = new System.Drawing.Point(232, 160);
            this.buttonSaveChangeState.Name = "buttonSaveChangeState";
            this.buttonSaveChangeState.Size = new System.Drawing.Size(97, 23);
            this.buttonSaveChangeState.TabIndex = 3;
            this.buttonSaveChangeState.Text = "Zapisz";
            this.buttonSaveChangeState.UseVisualStyleBackColor = false;
            this.buttonSaveChangeState.Click += new System.EventHandler(this.buttonSaveChangeState_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(320, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(27, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // comboBoxNewState
            // 
            this.comboBoxNewState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.comboBoxNewState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNewState.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxNewState.ForeColor = System.Drawing.Color.White;
            this.comboBoxNewState.Items.AddRange(new object[] {
            "Oglądane",
            "Wstrzymane",
            "Planowane",
            "Obejrzane",
            "Pominięte"});
            this.comboBoxNewState.Location = new System.Drawing.Point(130, 95);
            this.comboBoxNewState.Name = "comboBoxNewState";
            this.comboBoxNewState.Size = new System.Drawing.Size(200, 25);
            this.comboBoxNewState.TabIndex = 5;
            // 
            // ChangeTitleState
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ChangeTitleState";
            this.Size = new System.Drawing.Size(360, 210);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox comboBoxNewState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonSaveChangeState;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}
