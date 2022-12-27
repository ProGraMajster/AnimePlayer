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
    public partial class ControlTitleStatusList_Item_Episodes : UserControl
    {
        public bool CheckBoxState = false;
        public ControlTitleStatusList_Item_Episodes()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
           checkBox.Checked = CheckBoxState;
        }
    }
}
