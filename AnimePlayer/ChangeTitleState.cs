using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AnimePlayerLibrary;

namespace AnimePlayer
{
    public partial class ChangeTitleState : UserControl
    {
        PageItem pageItem;
        public ChangeTitleState(PageItem page)
        {
            InitializeComponent();
            pageItem = page;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void buttonSaveChangeState_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Wystąpił błąd podczas zmieniania listy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
