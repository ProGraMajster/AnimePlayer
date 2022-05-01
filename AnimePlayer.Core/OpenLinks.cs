using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Core
{
    public static class OpenLinks
    {
        public static Exception Start(string link)
        {
            try
            {
                Process.Start(new ProcessStartInfo("cmd", "/C start \"\" "+link));
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}
