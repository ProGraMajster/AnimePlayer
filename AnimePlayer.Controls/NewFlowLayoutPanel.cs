using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    public class NewFlowLayoutPanel : System.Windows.Forms.FlowLayoutPanel
    {
        public NewFlowLayoutPanel()
        {
            this.DoubleBuffered = true;
            this.Scroll += NewFlowLayoutPanel_Scroll;
        }

        private void NewFlowLayoutPanel_Scroll(object sender, ScrollEventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            Application.DoEvents();
            this.Invalidate();
            base.OnScroll(se);
        }
    }
}
