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
    public partial class MerryGoRoundControl : UserControl
    {
        public MerryGoRoundControl()
        {
            InitializeComponent();
            SetLoctionChildElementsUI();
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(buttonNext, 50);
            AnimePlayer.CNM.ExtensionsControl.RoundingTheCorners(buttonBack, 50);
        }

        public void SetLoctionChildElementsUI()
        {
            buttonBack.Location = new Point(5, (transparentPanel1.Height - buttonBack.Height)/2);
            buttonNext.Location = new Point(5, (transparentPanel2.Height - buttonNext.Height)/2);
        }

        protected override void OnResize(EventArgs e)
        {
            Visible = false;
            base.OnResize(e);
            SetLoctionChildElementsUI();
            Visible = true;
        }
    }
}
