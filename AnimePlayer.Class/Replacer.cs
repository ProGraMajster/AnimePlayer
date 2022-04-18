using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    public static class Replacer
    {
        public static string Names(string name)
        {
            return name.Replace(":", " ").Replace("?", " ");
        }
    }

}
