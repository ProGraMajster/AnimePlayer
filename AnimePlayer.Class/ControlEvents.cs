using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AnimePlayer.Class
{
    public static class ControlEvents
    {
        public static void OpenLink(object sender, EventArgs eventArgs)
        {
            Process.Start("cmd.exe /C start \"\" ");
        }
    }
}
