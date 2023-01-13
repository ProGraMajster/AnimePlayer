using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer
{
    public static class ConsoleDevAnimePlayer
    {
        //public static Dictionary<string, Delegate> Commands = new Dictionary<string, Delegate>();
        
        public static void StartCommand(string command)
        {
            try
            {

            }
            catch(Exception ex)
            {
                Debug.Write(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
