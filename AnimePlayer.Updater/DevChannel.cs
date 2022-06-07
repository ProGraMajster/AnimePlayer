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
        public static bool Update = false;
        static readonly string link = @"https://github.com/ProGraMajster/AnimePlayer/archive/refs/heads/master.zip";
        static string textContentUpdate;
        public static void Start()
        {
            try
            {
                textContentUpdate = "Zmainy:\n";
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
                            Update = true;
                        }
                    }
                    catch(Exception exFile)
                    {
                        Console.Error.Write(exFile.ToString());
                    }
                }

                if(Update)
                {
                    DialogResult dialogResult = NewMessageBox.NewMessageBox.ShowDialog("Zainstalowano aktualizację programu" +
                        " Czy chcesz zrestartować program teraz (aby skorzystać z nowej wersji)? \n\n" +textContentUpdate,
                        "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    if(dialogResult == DialogResult.Yes)
                    {
                        fileInfosN = GetDLLFiles(repo_path);
                        fileInfosC = GetDLLFiles(Application.StartupPath);
                        for (int i = 0; i < fileInfosN.Length; i++)
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
                            catch (Exception exFile)
                            {
                                Console.Error.Write(exFile.ToString());
                            }
                        }
                        File.WriteAllText(AppFolders.Updater+"update", "1");
                        Environment.Exit(0);
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
                textContentUpdate += fileVersionInfoC.OriginalFilename+" v"+ fileVersionInfoC.FileVersion +" > "+
                    fileVersionInfoN.OriginalFilename+" v"+fileVersionInfoN.FileVersion+"\n";
                Console.Write(fileVersionInfoC.OriginalFilename+" v"+ fileVersionInfoC.FileVersion +" > "+
                    fileVersionInfoN.OriginalFilename+" v"+fileVersionInfoN.FileVersion+"\n");
                if(fileVersionInfoN.ProductName != fileVersionInfoC.ProductName)
                {
                    return false;
                }
                if (fileVersionInfoN.FileMajorPart > fileVersionInfoC.FileMajorPart)
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
                        File.Move(file.FullName, pathOldLib+file.Name, true);
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
