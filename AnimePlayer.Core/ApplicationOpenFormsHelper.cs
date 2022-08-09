using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayer.Core
{
    public static class ApplicationFormsHelper
    {
        public static Control[] FindControlInAllForms(string Name)
        {
            try
            {
                List<Control> list = new();
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
                return list.ToArray();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
