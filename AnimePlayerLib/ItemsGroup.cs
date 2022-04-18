using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerLibrary
{
    public partial class ItemsGroup : UserControl
    {
        public string groupTitle;
        Panel panelDock;
        public NewFlowLayoutPanel layoutPanel;
        public ItemsGroup(Panel panel, string title)
        {
            InitializeComponent();
            try
            {
                layoutPanel = new NewFlowLayoutPanel();
                layoutPanel.Name = "NewFlowLayoutPanel_"+title;
                this.Controls.Add(layoutPanel);
                layoutPanel.BackColor = Color.FromArgb(20, 20, 20);
                layoutPanel.Dock = DockStyle.Fill;
                layoutPanel.Show();
                this.Controls.SetChildIndex(layoutPanel, 0);
                panelDock = panel;
                groupTitle = title;
                labelTitleGroup.Text = groupTitle;
            }
            catch(Exception ex)
            {
                //FileLog.Write(ex.ToString());
            }
        }
    }
}
