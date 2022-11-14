using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AnimePlayerLibrary;
using AnimePlayerLibrary.UI;

namespace AnimePlayer
{
    public partial class ChangeTitleState : UserControl
    {
        public ChangeTitleState()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void ButtonSaveChangeState_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Ta funkcja jest nie dostępna\n(Jeszcze nie jest skończona)", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Wystąpił błąd podczas zmieniania listy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeTitleState_Load(object sender, EventArgs e)
        {

        }
    }
}
