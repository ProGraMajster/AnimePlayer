using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using AnimePlayer.ControlsWinForms;
using AnimePlayer.Class;
namespace AnimePlayerLibrary
{
    public partial class ItemsGroup : UserControl
    {
        public GroupClass GroupClass;
        public NewFlowLayoutPanel layoutPanel;
        public ItemsGroup(GroupClass groupClass)
        {
            InitializeComponent();
            try
            {
                GroupClass = groupClass;
                layoutPanel = new NewFlowLayoutPanel();
                layoutPanel.Name = "NewFlowLayoutPanel_"+groupClass.Name;
                this.Controls.Add(layoutPanel);
                layoutPanel.BackColor = Color.FromArgb(20, 20, 20);
                layoutPanel.Dock = DockStyle.Fill;
                layoutPanel.WrapContents = false;
                layoutPanel.AutoScroll= true;
                layoutPanel.Show();
                this.Controls.SetChildIndex(layoutPanel, 0);
                labelTitleGroup.Text = groupClass.Name;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
