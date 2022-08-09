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
    public partial class PanelGradient : Panel
    {
        Graphics g;

        public void DrawGradient()
        {
            try
            {
                if(g == null)
                {
                    return;
                }
                var rc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    rc,
                    Color.FromArgb(255, Color.Black),
                    Color.FromArgb(0, Color.Black),
                    0f);
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                g.FillRectangle(brush, rc);
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;
            DrawGradient();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Refresh();
            DrawGradient();
        }
    }
}
