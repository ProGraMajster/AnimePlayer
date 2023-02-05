using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AnimePlayer.CNM
{
    public static class ControlsNewMethods
    {
        public static void CenterControlInForm(Control control, Form form)
        {
            try
            {
                control.Left = (form.ClientSize.Width - control.Width) / 2;
                control.Top = (form.ClientSize.Height - control.Height) / 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine);
            }
        }
        public class RoundingControl : Component
        {
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
#pragma warning disable CA1401 // Elementy P/Invoke nie powinny być widoczne
            public static extern IntPtr CreateRoundRectRgn
#pragma warning restore CA1401 // Elementy P/Invoke nie powinny być widoczne
                (
                   int nLeftRect,
                   int nTopRect,
                   int nRightRect,
                   int nBottomRect,
                   int nWidthEllipse,
                   int nHeightEllipse
                );
            private Control _cntrl;
            private int _CornerRadius = 30;

            public Control TargetControl
            {
                get { return _cntrl; }
                set
                {
                    _cntrl = value;
                    _cntrl.SizeChanged += (sender, eventArgs) => _cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, _cntrl.Width, _cntrl.Height, _CornerRadius, _CornerRadius));
                }
            }

            public int CornerRadius
            {
                get { return _CornerRadius; }
                set
                {
                    _CornerRadius = value;
                    if (_cntrl != null)
                        _cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, _cntrl.Width, _cntrl.Height, _CornerRadius, _CornerRadius));
                }
            }
        }
    }
}