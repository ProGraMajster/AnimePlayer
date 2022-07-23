using System.Windows.Forms;

namespace AnimePlayer.Profile
{
    partial class FormFristProfileCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameProfile = new System.Windows.Forms.TextBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonSetIconProfile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonResetIconProfile = new System.Windows.Forms.Button();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tworzenie profilu";
            // 
            // buttonCreateProfile
            // 
            this.buttonCreateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateProfile.Location = new System.Drawing.Point(30, 336);
            this.buttonCreateProfile.Name = "buttonCreateProfile";
            this.buttonCreateProfile.Size = new System.Drawing.Size(170, 23);
            this.buttonCreateProfile.TabIndex = 1;
            this.buttonCreateProfile.Text = "Utwórz profil";
            this.buttonCreateProfile.UseVisualStyleBackColor = true;
            this.buttonCreateProfile.Click += new System.EventHandler(this.buttonCreateProfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa";
            // 
            // textBoxNameProfile
            // 
            this.textBoxNameProfile.BackColor = System.Drawing.Color.Black;
            this.textBoxNameProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNameProfile.ForeColor = System.Drawing.Color.White;
            this.textBoxNameProfile.Location = new System.Drawing.Point(30, 98);
            this.textBoxNameProfile.Name = "textBoxNameProfile";
            this.textBoxNameProfile.PlaceholderText = "Użytkownik";
            this.textBoxNameProfile.Size = new System.Drawing.Size(303, 18);
            this.textBoxNameProfile.TabIndex = 3;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBoxProfile.Location = new System.Drawing.Point(30, 157);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(100, 64);
            this.pictureBoxProfile.TabIndex = 4;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonSetIconProfile
            // 
            this.buttonSetIconProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetIconProfile.Location = new System.Drawing.Point(136, 157);
            this.buttonSetIconProfile.Name = "buttonSetIconProfile";
            this.buttonSetIconProfile.Size = new System.Drawing.Size(100, 23);
            this.buttonSetIconProfile.TabIndex = 5;
            this.buttonSetIconProfile.Text = "Wybierz";
            this.buttonSetIconProfile.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zdjęcie";
            // 
            // buttonResetIconProfile
            // 
            this.buttonResetIconProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetIconProfile.Location = new System.Drawing.Point(136, 198);
            this.buttonResetIconProfile.Name = "buttonResetIconProfile";
            this.buttonResetIconProfile.Size = new System.Drawing.Size(100, 23);
            this.buttonResetIconProfile.TabIndex = 7;
            this.buttonResetIconProfile.Text = "Reset";
            this.buttonResetIconProfile.UseVisualStyleBackColor = true;
            // 
            // textBoxDes
            // 
            this.textBoxDes.BackColor = System.Drawing.Color.Black;
            this.textBoxDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDes.ForeColor = System.Drawing.Color.White;
            this.textBoxDes.Location = new System.Drawing.Point(32, 262);
            this.textBoxDes.Multiline = true;
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.PlaceholderText = " Główny profil";
            this.textBoxDes.Size = new System.Drawing.Size(303, 55);
            this.textBoxDes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opis";
            // 
            // FormFristProfileCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDes);
            this.Controls.Add(this.buttonResetIconProfile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSetIconProfile);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.textBoxNameProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreateProfile);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormFristProfileCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimePlayer - Tworzenie pierwszego proflu użytkownika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonCreateProfile;
        private Label label2;
        private TextBox textBoxNameProfile;
        private PictureBox pictureBoxProfile;
        private Button buttonSetIconProfile;
        private Label label3;
        private Button buttonResetIconProfile;
        private TextBox textBoxDes;
        private Label label4;
    }
}