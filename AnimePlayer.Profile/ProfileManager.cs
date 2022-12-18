using AnimePlayer.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AnimePlayer.Profile
{
    public static class ProfileManager
    {
        public enum DefaultAnimeList:int
        {
            Watching = 0,
            Ended=1,
            OnHold=2,
            Dropped=3,
            PlanToWatch =4
        }

        public static List<string> defaultLists = new()
        {
            "Oglądane",
            "Zakończone",
            "W oczekiwaniu",
            "Porzucone",
            "Planowane"
        };

        public static List<ProfileIAnimeList> profileIAnimeLists = new();

        private static ProfileClass CurrentProfile;
        public static string PathToProfiles = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\AnimePlayer\\Profiles\\";

        public static void Init(ProfileClass profileClass)
        {
            try
            {
                if(profileClass == null)
                {
                    return;
                }
                CurrentProfile = profileClass;
                if(!Directory.Exists(PathToProfiles+CurrentProfile.Name))
                {
                    Directory.CreateDirectory(PathToProfiles+CurrentProfile.Name);
                }
                if(!Directory.Exists(PathToProfiles+CurrentProfile.Name+"\\Lists"))
                {
                    Directory.CreateDirectory(PathToProfiles+CurrentProfile.Name + "\\Lists");
                }
                if(ChecikingAllDefaultLists()== false)
                {
                    CreateDefaultAnimeLists();
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public static bool ChecikingAllDefaultLists()
        {
            try
            {
                if (CurrentProfile == null)
                {
                    return false;
                }
                if (!Directory.Exists(PathToProfiles + CurrentProfile.Name + "\\Lists"))
                {
                    return false;
                }
                Dictionary<string,bool> dict = new Dictionary<string, bool>()
                {
                    { "Oglądane",false },
                    { "Zakończone", false},
                    { "W oczekiwaniu",false },
                    { "Porzucone", false },
                    { "Planowane", false }
                };

                DirectoryInfo directoryInfo = new DirectoryInfo(PathToProfiles + CurrentProfile.Name + "\\Lists");
                foreach(FileInfo file in directoryInfo.GetFiles())
                {
                    foreach (var item in dict)
                    {
                        ProfileIAnimeList alist = (ProfileIAnimeList)SerializationAndDeserialization.DeserializationJson(
                            file.FullName,typeof(ProfileIAnimeList));
                        if (alist != null)
                        {
                            if(alist.Name == item.Key)
                            {
                                dict[item.Key] = true;
                            }
                        }
                    }
                }

                int max = dict.Count;
                int c = 0;
                foreach(bool val in dict.Values)
                {
                    if(val)
                    {
                        c++;
                    }
                }
                if(c >= max)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return false;
        }

        public static string GetPathCurrentProfile()
        {
            if(CurrentProfile == null)
            {
                return null;
            }
            return PathToProfiles + CurrentProfile.Name + "\\";
        }

        public static void CreateDefaultAnimeLists()
        {
            try
            {
                foreach(string name in defaultLists)
                {
                    CreateAnimeList(name, "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.ToString());
            }
        }

        public static void CreateAnimeList(string name, string description)
        {
            try
            {
                string path = GetPathCurrentProfile() + "\\Lists\\";
                path += Guid.NewGuid().ToString();
                ProfileIAnimeList profileIAnimeList = new ProfileIAnimeList();
                profileIAnimeList.Name = name;
                profileIAnimeList.Description = description;
                profileIAnimeList.itemToLists = new List<ItemToList>();
                SerializationAndDeserialization.SerializationJson(profileIAnimeList, path, typeof(ProfileIAnimeList));
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public static List<ProfileIAnimeList> GetAllAnimeList()
        {
            try
            {
                List<ProfileIAnimeList> allList = new List<ProfileIAnimeList>();
                DirectoryInfo directoryInfo = new DirectoryInfo(PathToProfiles + CurrentProfile.Name + "\\Lists");
                foreach(var file in directoryInfo.GetFiles())
                {
                    ProfileIAnimeList animeList = (ProfileIAnimeList)
                        SerializationAndDeserialization.DeserializationJson(file.FullName,
                        typeof(ProfileIAnimeList));
                    if(animeList != null)
                    {
                        allList.Add(animeList);
                    }
                }
                return allList;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
            return null;
        }

        private static ProfileIAnimeList GetWatchingAnimeList()
        {
            try
            {
                //coming soon
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
            return null;
        }
    }
}
