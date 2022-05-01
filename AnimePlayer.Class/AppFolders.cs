using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.Class
{
    public static class AppFolders
    {
        public static readonly string AppFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\";
        public static readonly string Temp = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Temp\\";
        public static readonly string PreviewItems = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\PreviewItems\\";
        public static readonly string Community = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Community\\";
        public static readonly string Logs = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Logs\\";
        public static readonly string News = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\News\\";
        public static readonly string Web = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Web\\";
        public static readonly string PagesItems = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\PagesItems\\";
        public static readonly string VideosItems = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\VideosItems\\";
        public static readonly string Icons  = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Icons\\";
        public static readonly string IconsBackup = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\IconsBackup\\";
    }
}
