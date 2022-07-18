using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer.ControlsWinForms
{
    public class TransparentPanel : Panel
    {
        public TransparentPanel()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            this.Invalidate();
            base.OnResize(eventargs);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
    }
}
