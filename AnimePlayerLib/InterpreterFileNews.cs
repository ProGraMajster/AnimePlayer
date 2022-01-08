using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerLibrary
{
    public static class InterpreterFileNews
    {
        public static void Start(Control output, string path, Panel panel2, bool local = false)
        {
            if(output == null)
            { return; }


            foreach(ListNews ln in SetFile(path))
            {
                PanelNews panelNews = new PanelNews(ln, panel2, local);
                panelNews.Show();
                output.Invoke((Action)(() => output.Controls.Add(panelNews)));
            }
        }

        public static List<ListNews> SetFile(string path)
        {
            List<ListNews> listNews = new List<ListNews>();
            if (path == null)
            {
                return listNews;
            }

            if(!File.Exists(path))
            {
                Console.WriteLine("public static List<ListNews> SetFile(string path) > \n File.Exists(path) > false");
                return listNews;
            }
            
            string[] content = File.ReadAllText(path).Split(';');
            int limits = 0;
            for (int i = 0; i < content.Length; i++)
            {
                limits = i;
                content[i] = content[i].Replace("\n", "").Replace("\r", "").Replace("\t", "");
            }
            try
            {
                bool end = false;
                int position = 0;
                while (end != true)
                {
                    if (position == limits)
                    {
                        end = true;
                    }

                    if (content[position] == "NewItem_ListNews")
                    {
                        ListNews news = new ListNews();
                        position++;
                        if(content[position] =="ID")
                        {
                            position++;
                            news.ID = content[position];
                            position++;
                            if (content[position] == "Title")
                            {
                                position++;
                                news.Title = content[position];
                                position++;
                                if (content[position] == "Descryption")
                                {
                                    position++;
                                    news.Descryption = content[position];
                                    position++;
                                    if (content[position] == "IconLink")
                                    {
                                        position++;
                                        news.IconLink = content[position];
                                        position++;
                                        if (content[position] == "ContentLink")
                                        {
                                            position++;
                                            if(content[position]=="null")
                                            {
                                                news.ContentLink = null;
                                            }
                                            else
                                            {
                                                news.ContentLink = content[position];
                                            }
                                            listNews.Add(news);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    position++;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SetFile>\n" + path);
                Console.WriteLine(ex.ToString());
            }
            return listNews;
        }
    }
}
