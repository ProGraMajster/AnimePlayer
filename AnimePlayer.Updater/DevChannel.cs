using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using AnimePlayerLibrary;
using AnimePlayer.Class;
using System.Diagnostics;

namespace AnimePlayer.Updater
{
    public static class DevChannel
    {
        static readonly string link = @"https://github.com/ProGraMajster/AnimePlayer/archive/refs/heads/master.zip";
        public static void Start()
        {
            try
            {
                if (Directory.Exists(AppFolders.Updater+"Downloaded_repo"))
                {
                    Directory.Delete(AppFolders.Updater+"Downloaded_repo", true);
                }
                Download.File(link, AppFolders.Temp+"libs.zip");
                Directory.CreateDirectory(AppFolders.Updater+"Downloaded_repo");
                ZipFile.ExtractToDirectory(AppFolders.Temp+"libs.zip", AppFolders.Updater+"Downloaded_repo");
                MoveOldLib();
                UpdateOperation();
            }
            catch(Exception ex)
            {
                    Console.Error.WriteLine(ex.ToString());
            }
        }

        static readonly string repo_path = @"C:\Users\ssass\AppData\Roaming\AnimePlayer\Updater\Downloaded_repo\AnimePlayer-master\AnimePlayer.HostApp\bin\Debug\net6.0-windows";
        public static void UpdateOperation()
        {
            try
            {
                FileInfo[] fileInfosN = GetDLLFiles(repo_path);
                FileInfo[] fileInfosC = GetDLLFiles(Application.StartupPath);
                for (int i=0; i < fileInfosN.Length; i++)
                {
                    try
                    {
                        if (CheckingFileDLLVersion(fileInfosN[i].FullName, fileInfosC[i].FullName))
                        {
                            Console.WriteLine(fileInfosC[i].FullName+" > "+fileInfosC[i].DirectoryName+"\\"+fileInfosC[i].Name.Replace(".dll", "_Old.dll"));
                            File.Move(fileInfosC[i].FullName, fileInfosC[i].DirectoryName+"\\"+fileInfosC[i].Name.Replace(".dll", "_Old.dll"));
                            Console.WriteLine(fileInfosN[i].FullName+" > "+ Application.StartupPath +"\\"+fileInfosN[i].Name+".dll");
                            File.Move(fileInfosN[i].FullName, Application.StartupPath +"\\"+fileInfosN[i].Name+".dll");
                        }
                    }
                    catch(Exception exFile)
                    {
                        Console.Error.Write(exFile.ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public static FileInfo[] GetDLLFiles(string pathToFolder)
        {
            try
            {
                List<FileInfo> fileInfos = new List<FileInfo>();
                DirectoryInfo directoryInfo = new DirectoryInfo(pathToFolder);
                foreach(FileInfo fileInfo in directoryInfo.GetFiles())
                {
                    if(fileInfo.Extension == ".dll")
                    {
                        fileInfos.Add(fileInfo);
                    }
                }
                return fileInfos.ToArray();
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
            return null;
        }

        static bool CheckingFileDLLVersion(string pathToNewFile, string pathToCurrent)
        {
            try
            {
                FileVersionInfo fileVersionInfoN = FileVersionInfo.GetVersionInfo(pathToNewFile);
                FileVersionInfo fileVersionInfoC = FileVersionInfo.GetVersionInfo(pathToCurrent);
                if(fileVersionInfoN.FileMajorPart > fileVersionInfoC.FileMajorPart)
                {
                    return true;
                }
                else
                {
                    if(fileVersionInfoN.FileMinorPart > fileVersionInfoC.FileMinorPart)
                    {
                        return true;
                    }
                    else
                    {
                        if(fileVersionInfoN.FileBuildPart > fileVersionInfoC.FileBuildPart)
                        {
                            return true;
                        }
                        else
                        {
                            if(fileVersionInfoN.FilePrivatePart > fileVersionInfoC.FilePrivatePart)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
            return false;
        }

        static readonly string pathOldLib = AppFolders.Updater +"Old_libraries\\";

        static void MoveOldLib()
        {
            try
            {
                if (Directory.Exists(pathOldLib))
                    Directory.Delete(pathOldLib,true);

                Directory.CreateDirectory(pathOldLib);
                DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath);
                foreach(var file in directoryInfo.GetFiles())
                {
                    if(file.Extension == "_Old.dll")
                    {
                        File.Move(file.FullName, pathOldLib+file.Name);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
