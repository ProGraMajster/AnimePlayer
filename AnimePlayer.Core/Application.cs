using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer.Core
{
    public static class ApplicationOpenFormsHelper
    {
        public static Control[] FindControlInAllForms(string Name)
        {
            try
            {
                List<Control> list = new List<Control>();
                foreach (Form form in Application.OpenForms)
                {
                    foreach (Control control in form.Controls)
                    {
                        if (control.Name != null)
                        {
                            if (control.Name == Name)
                            {
                                list.Add(control);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
