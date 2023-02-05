using AnimePlayer.Class;
using AnimePlayerLibrary.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Graphics.Printing.PrintSupport;

namespace AnimePlayer
{
    public static class ConsoleDevAnimePlayer
    {
        //public static Dictionary<string, Delegate> Commands = new Dictionary<string, Delegate>();
        
        public static void StartCommand(string command)
        {
            try
            {
                if(command.StartsWith("test_content"))
                {
                    TestContent(command);
                }
            }
            catch(Exception ex)
            {
                Debug.Write(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
        private static void TestContent(string command)
        {
            command = command.Remove(0, "test_content".Length);
            Console.WriteLine(command);
            if(command.StartsWith(".load.pageitemdata;"))
            {
                FormMainPlayer form= (FormMainPlayer)(Application.OpenForms[0]);/*
                PageItemData pageItemData = Core.SerializationAndDeserialization.des
                PageItem pageItem = new();*/
            }
        }
    }
}
