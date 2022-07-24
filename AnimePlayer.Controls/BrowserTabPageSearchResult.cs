using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    public partial class BrowserTabPageSearchResult : UserControl
    {
        public BrowserTabPageSearchResult()
        {
            InitializeComponent();
        }

        private void newFlowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            labelResultValue.Text = "Zanleziono: "+newFlowLayoutPanel.Controls.Count;
        }
    }
}
