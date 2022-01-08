using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace AnimePlayerLibrary
{
    public class Tcolor
    {
        public string name { get; set; }
        public string sbackcolor { get; set; }
        public string sforecolor { get; set; }
        public Color bcolor { get; set; }
        public Color fcolor { get; set; }
    }

    public class ThemeChanger
    {
        public Form form;
        List<Tcolor> colorsTheme;
        AutoCompleteStringCollection autoCSC_find;
        ThemeChangerColors tchColors;
        public ThemeChanger(Form _form, ThemeChangerColors colors, AutoCompleteStringCollection _autoCSC_find= null)
        {
            form = _form;
            colorsTheme = new List<Tcolor>();
            if(_autoCSC_find != null)
            {
                autoCSC_find = _autoCSC_find;
            }
            if(colors != null)
            {
                tchColors = colors;
            }
        }


        public void LoadThemeFile(string path)
        {
            if (path == null)
            {
                return;
            }

            try
            {
                string[] content = File.ReadAllText(path).Split(';');
                int limits = 0;
                for (int i = 0; i < content.Length; i++)
                {
                    limits = i;
                    content[i] = content[i].Replace("\n", "").Replace("\r", "").Replace("\t", "");
                }

                bool end = false;
                int position = 0;
                while (end != true)
                {
                    if (position == limits)
                    {
                        end = true;
                    }

                    if (content[position] == "ColorStyle")
                    {
                        Tcolor tcolor = new Tcolor();
                        position++;
                        if (content[position] == "Name")
                        {
                            position++;
                            tcolor.name = content[position];
                            position++;
                            if (content[position] == "BackColor")
                            {
                                position++;
                                if (content[position].Contains(":"))
                                {
                                    tcolor.sbackcolor = content[position].Split(':')[1];
                                }
                                else
                                {
                                    tcolor.sbackcolor = content[position];
                                }
                                position++;
                                if (content[position] == "ForeColor")
                                {
                                    position++;
                                    if (content[position].Contains(":"))
                                    {
                                        tcolor.sforecolor = content[position].Split(':')[1];
                                    }
                                    else
                                    {
                                        tcolor.sforecolor = content[position];
                                    }
                                    SetColorinClass(tcolor);
                                    colorsTheme.Add(tcolor);
                                }
                            }
                            else if (content[position] == "Argb")
                            {
                                position++;
                                string[] ar = content[position].Split(',');
                                tcolor.bcolor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                                position++;
                                ar = content[position].Split(',');
                                tcolor.fcolor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            }
                        }
                    }
                    else if (content[position] == "SetColorAllControls")
                    {
                        position++;
                        Tcolor tcolor = colorsTheme.FindAll(x => x.name == content[position])[0];
                        foreach (Control c in form.Controls)
                        {
                            SetColorOnControl(c, tcolor);
                        }
                    }
                    else if(content[position] == "Control")
                    {
                        position++;
                        string nameCtn = content[position];
                        position++;
                        if(content[position] == "SetAllColorStyle")
                        {
                            position++;
                            Function_Control_useColorStyle(content,position, nameCtn, true);
                        }
                        else if(content[position] == "SetAllColorStyle2")
                        {
                            position++;
                            Function_Control_useColorStyle(content,position, nameCtn);
                        }
                        else if(content[position] == "AllButtons")
                        {
                            position++;
                            if (content[position] == "MouseDownBackColor")
                            {
                                try
                                {
                                    position++;
                                    string[] ar = content[position].Split(':');
                                    if (ar[0] == "Value")
                                    {
                                        if (ar[1].StartsWith("+"))
                                        {
                                            ar[1] = ar[1].Replace("+", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a;
                                            int b;
                                            int g;
                                            int r;
                                            foreach (Button btn in GetControlFromName(nameCtn).Controls.OfType<Button>())
                                            {
                                                a = btn.BackColor.A;
                                                b = btn.BackColor.B;
                                                g = btn.BackColor.G;
                                                r = btn.BackColor.R;
                                                if ((a + cVCH) < 255)
                                                {
                                                    a = a + cVCH;
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, r, g, b);
                                                }
                                                if ((r + cVCH) < 255)
                                                {
                                                    r = r + cVCH;
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, 255, g, b);
                                                }
                                                if ((g + cVCH) < 255)
                                                {
                                                    g = g + cVCH;
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, 255, b);
                                                }
                                                if ((b + cVCH) < 255)
                                                {
                                                    b = b + cVCH;
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, 255);
                                                }
                                            }
                                        }
                                        else if (ar[1].StartsWith("-"))
                                        {
                                            ar[1] = ar[1].Replace("-", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a;
                                            int b;
                                            int g;
                                            int r;
                                            foreach (Button btn in GetControlFromName(nameCtn).Controls.OfType<Button>())
                                            {
                                                a = btn.BackColor.A;
                                                b = btn.BackColor.B;
                                                g = btn.BackColor.G;
                                                r = btn.BackColor.R;
                                                if ((a - cVCH) > 0)
                                                {
                                                    a = a - cVCH;
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, r, g, b);
                                                }
                                                if ((r - cVCH) > 0)
                                                {
                                                    r = r - cVCH;
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, 0, g, b);
                                                }
                                                if ((g - cVCH) > 0)
                                                {
                                                    g = g - cVCH;
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, 0, b);
                                                }
                                                if ((b - cVCH) > 0)
                                                {
                                                    b = b - cVCH;
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, 0);
                                                }
                                            }
                                        }
                                    }
                                    else if(ar[0] == "Argb")
                                    {
                                        string[] sparse = ar[1].Split(',');
                                        Color colorNew = Color.FromArgb(int.Parse(sparse[0]), int.Parse(sparse[1]), int.Parse(sparse[2]), int.Parse(sparse[3]));
                                        foreach (Button btn in GetControlFromName(nameCtn).Controls.OfType<Button>())
                                        {
                                            btn.FlatAppearance.MouseDownBackColor = colorNew;
                                        }
                                    }
                                }
                                catch (Exception exFlat)
                                {
                                    Console.WriteLine(exFlat.ToString());
                                }
                            }
                            else if (content[position] == "MouseOverBackColor")
                            {
                                try
                                {
                                    position++;
                                    string[] ar = content[position].Split(':');
                                    if (ar[0] == "Value")
                                    {
                                        if (ar[1].StartsWith("+"))
                                        {
                                            ar[1] = ar[1].Replace("+", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a;
                                            int b;
                                            int g;
                                            int r;
                                            foreach(Button btn in GetControlFromName(nameCtn).Controls.OfType<Button>())
                                            {
                                                a = btn.BackColor.A;
                                                b = btn.BackColor.B;
                                                g = btn.BackColor.G;
                                                r = btn.BackColor.R;
                                                if ((a + cVCH) < 255)
                                                {
                                                    a = a + cVCH;
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, r, g, b);
                                                }
                                                if ((r + cVCH) < 255)
                                                {
                                                    r = r + cVCH;
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, 255, g, b);
                                                }
                                                if ((g + cVCH) < 255)
                                                {
                                                    g = g + cVCH;
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, 255, b);
                                                }
                                                if ((b + cVCH) < 255)
                                                {
                                                    b = b + cVCH;
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, 255);
                                                }
                                            }
                                        }
                                        else if (ar[1].StartsWith("-"))
                                        {
                                            ar[1] = ar[1].Replace("-", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a;
                                            int b;
                                            int g;
                                            int r;
                                            foreach (Button btn in GetControlFromName(nameCtn).Controls.OfType<Button>())
                                            {
                                                a = btn.BackColor.A;
                                                b = btn.BackColor.B;
                                                g = btn.BackColor.G;
                                                r = btn.BackColor.R;
                                                if ((a - cVCH) > 0)
                                                {
                                                    a = a - cVCH;
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, r, g, b);
                                                }
                                                if ((r - cVCH) > 0)
                                                {
                                                    r = r - cVCH;
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, 0, g, b);
                                                }
                                                if ((g - cVCH) > 0)
                                                {
                                                    g = g - cVCH;
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, 0, b);
                                                }
                                                if ((b - cVCH) > 0)
                                                {
                                                    b = b - cVCH;
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                }
                                                else
                                                {
                                                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, 0);
                                                }
                                            }
                                        }
                                    }
                                    else if (ar[0] == "Argb")
                                    {
                                        string[] sparse = ar[1].Split(',');
                                        Color colorNew = Color.FromArgb(int.Parse(sparse[0]), int.Parse(sparse[1]), int.Parse(sparse[2]), int.Parse(sparse[3]));
                                        foreach (Button btn in GetControlFromName(nameCtn).Controls.OfType<Button>())
                                        {
                                            btn.FlatAppearance.MouseOverBackColor = colorNew;
                                        }
                                    }
                                }
                                catch (Exception exFlat)
                                {
                                    Console.WriteLine(exFlat.ToString());
                                }
                            }
                            else if (content[position] == "BorderColor")
                            {
                                position++;
                                if (content[position] == "Argb")
                                {
                                    try
                                    {
                                        position++;
                                        string[] ar = content[position].Split(',');
                                        foreach (Button btn in GetControlFromName(nameCtn).Controls.OfType<Button>())
                                        {
                                            btn.FlatAppearance.BorderColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                                        }
                                    }
                                    catch (Exception exArgb)
                                    {
                                        Console.WriteLine(exArgb.ToString());
                                    }
                                }
                            }
                            else if (content[position] == "BorderSize")
                            {
                                try
                                {
                                    position++;
                                    foreach (Button btn in GetControlFromName(nameCtn).Controls.OfType<Button>())
                                        btn.FlatAppearance.BorderSize =int.Parse(content[position]);
                                }
                                catch (Exception exBorderSize)
                                {
                                    Console.WriteLine("exBorderSize > \n" + exBorderSize.ToString());
                                }
                            }
                        }
                        else if(content[position] =="BackImage")
                        {
                            try
                            {
                                position++;
                                Control c = GetControlFromName(nameCtn);
                                c.BackgroundImage = Image.FromFile(content[position]);
                                position++;
                                if(content[position] == "BackgroundImageLayout")
                                {
                                    position++;                                    
                                    if(content[position] =="None")
                                    {
                                        c.BackgroundImageLayout = ImageLayout.None;
                                    }
                                    else if(content[position] =="Center")
                                    {
                                        c.BackgroundImageLayout = ImageLayout.Center;
                                    }
                                    else if(content[position] == "Tile")
                                    {
                                        c.BackgroundImageLayout = ImageLayout.Tile;
                                    }
                                    else if(content[position] == "Stretch")
                                    {
                                        c.BackgroundImageLayout = ImageLayout.Stretch;
                                    }
                                    else if(content[position] == "Zoom")
                                    {
                                        c.BackgroundImageLayout = ImageLayout.Zoom;
                                    }

                                }
                                else
                                {
                                    position--;
                                }
                            }
                            catch(Exception exBackImage)
                            {
                                Console.WriteLine(exBackImage.ToString());
                            }
                        }
                    }
                    else if(content[position]=="AllControlsFromNameSetBackColor")
                    {
                        try
                        {
                            position++;
                            string nameCtn = content[position];
                            position++;
                            string[] a = content[position].Split(',');
                            Color colorNew = Color.FromArgb(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3]));
                            foreach(Control c in form.Controls.Find(nameCtn, true))
                            {
                                c.BackColor = colorNew;
                            }
                        }
                        catch (Exception exACFNSBC)
                        {
                            Console.WriteLine(exACFNSBC.ToString());
                        }
                    }
                    else if(content[position] == "Button")
                    {
                        position++;
                        string nameCtn = content[position];
                        Button btn = (Button)GetControlFromName(nameCtn);
                        position++;
                        if (content[position] == "FlatAppearnce")
                        {
                            position++;
                            if (content[position] == "MouseDownBackColor")
                            {
                                try
                                {
                                    position++;
                                    string[] ar = content[position].Split(':');
                                    if (ar[0] == "Value")
                                    {
                                        if (ar[1].StartsWith("+"))
                                        {
                                            ar[1] = ar[1].Replace("+", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a = btn.BackColor.A;
                                            int b = btn.BackColor.B;
                                            int g = btn.BackColor.G;
                                            int r = btn.BackColor.R;
                                            if ((a + cVCH) < 255)
                                            {
                                                a = a + cVCH;
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, r, g, b);
                                            }
                                            if ((r + cVCH) < 255)
                                            {
                                                r = r + cVCH;
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, 255, g, b);
                                            }
                                            if ((g + cVCH) < 255)
                                            {
                                                g = g + cVCH;
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, 255, b);
                                            }
                                            if ((b + cVCH) < 255)
                                            {
                                                b = b + cVCH;
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, 255);
                                            }
                                        }
                                        else if (ar[1].StartsWith("-"))
                                        {
                                            ar[1] = ar[1].Replace("-", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a = btn.BackColor.A;
                                            int b = btn.BackColor.B;
                                            int g = btn.BackColor.G;
                                            int r = btn.BackColor.R;
                                            if ((a - cVCH) > 0)
                                            {
                                                a = a - cVCH;
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, r, g, b);
                                            }
                                            if ((r - cVCH) > 0)
                                            {
                                                r = r - cVCH;
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, 0, g, b);
                                            }
                                            if ((g - cVCH) > 0)
                                            {
                                                g = g - cVCH;
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, 0, b);
                                            }
                                            if ((b - cVCH) > 0)
                                            {
                                                b = b - cVCH;
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, 0);
                                            }
                                        }
                                    }
                                    else if(ar[0] == "Argb")
                                    {
                                        string[] sparse = ar[1].Split(',');
                                        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(int.Parse(sparse[0]),
                                            int.Parse(sparse[1]),
                                            int.Parse(sparse[2]),
                                            int.Parse(sparse[3]));
                                    }
                                }
                                catch (Exception exFlat)
                                {
                                    Console.WriteLine(exFlat.ToString());
                                }
                            }
                            else if (content[position] == "MouseOverBackColor")
                            {
                                try
                                {
                                    position++;
                                    string[] ar = content[position].Split(':');
                                    if (ar[0] == "Value")
                                    {
                                        if (ar[1].StartsWith("+"))
                                        {
                                            ar[1] = ar[1].Replace("+", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a = btn.BackColor.A;
                                            int b = btn.BackColor.B;
                                            int g = btn.BackColor.G;
                                            int r = btn.BackColor.R;
                                            if ((a + cVCH) < 255)
                                            {
                                                a = a + cVCH;
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, r, g, b);
                                            }
                                            if ((r + cVCH) < 255)
                                            {
                                                r = r + cVCH;
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, 255, g, b);
                                            }
                                            if ((g + cVCH) < 255)
                                            {
                                                g = g + cVCH;
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, 255, b);
                                            }
                                            if ((b + cVCH) < 255)
                                            {
                                                b = b + cVCH;
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, 255);
                                            }
                                        }
                                        else if (ar[1].StartsWith("-"))
                                        {
                                            ar[1] = ar[1].Replace("-", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a = btn.BackColor.A;
                                            int b = btn.BackColor.B;
                                            int g = btn.BackColor.G;
                                            int r = btn.BackColor.R;
                                            if ((a - cVCH) > 0)
                                            {
                                                a = a - cVCH;
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, r, g, b);
                                            }
                                            if ((r - cVCH) > 0)
                                            {
                                                r = r - cVCH;
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, 0, g, b);
                                            }
                                            if ((g - cVCH) > 0)
                                            {
                                                g = g - cVCH;
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, 0, b);
                                            }
                                            if ((b - cVCH) > 0)
                                            {
                                                b = b - cVCH;
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                            }
                                            else
                                            {
                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, 0);
                                            }
                                        }
                                    }
                                    else if (ar[0] == "Argb")
                                    {
                                        string[] sparse = ar[1].Split(',');
                                        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(int.Parse(sparse[0]),
                                            int.Parse(sparse[1]),
                                            int.Parse(sparse[2]),
                                            int.Parse(sparse[3]));
                                    }
                                }
                                catch (Exception exFlat)
                                {
                                    Console.WriteLine(exFlat.ToString());
                                }
                            }
                            else if(content[position] == "BorderColor")
                            {
                                position++;
                                if(content[position] =="Argb")
                                {
                                    try
                                    {
                                        position++;
                                        string[] ar = content[position].Split(',');
                                        btn.FlatAppearance.BorderColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                                    }
                                    catch(Exception exArgb)
                                    {
                                        Console.WriteLine(exArgb.ToString());
                                    }
                                }
                            }
                            else if(content[position] == "BorderSize")
                            {
                                try
                                {
                                    position++;
                                    btn.FlatAppearance.BorderSize = int.Parse(content[position]);
                                }
                                catch (Exception exBorderSize)
                                {
                                    Console.WriteLine("exBorderSize > \n"+exBorderSize.ToString());
                                }
                            }
                        }
                        
                    }
                    else if(content[position] == "Menu")
                    {
                        position++;
                        if(content[position] == "SetAllColorStyle")
                        {
                            try
                            {
                                position++;
                                Function_Control_useColorStyle(content,position,"panelMenu",true);
                                /*
                                Panel panel = form.Controls.Find("panelMenu", true).OfType<Panel>().First();
                                Tcolor tcolor = colorsTheme.FindAll(x => x.name == content[position])[0];
                                panel.BackColor = tcolor.bcolor;
                                panel.ForeColor = tcolor.fcolor;
                                foreach (Control c in panel.Controls)
                                {
                                    SetColorOnControl(c, tcolor);
                                }
                                */
                            }
                            catch(Exception eeSCS)
                            {
                                Console.WriteLine(eeSCS.ToString());
                            }
                        }
                        else if(content[position] == "SetBackImage")
                        {
                            try
                            {
                                position++;
                                Function_Control_SetBackImage(content, position, "panelMenu");
                                /*
                                Panel panel = form.Controls.Find("panelMenu", true).OfType<Panel>().First();
                                panel.BackgroundImage = Image.FromFile(content[position]);
                                */
                            }
                            catch(Exception exSetBackImage)
                            {
                                Console.WriteLine(exSetBackImage.ToString());
                            }
                        }
                        else if(content[position] == "buttonMenuClose")
                        {
                            position++;
                            if(content[ position]=="UseColorStyle")
                            {
                                position++;
                                Function_Control_useColorStyle(content, position, "buttonMenuClose");
                            }
                            else if(content[position] == "SetImage")
                            {
                                position++;
                                Function_Button_SetImage(content, position, "buttonMenuClose");
                            }
                            else if(content[position] == "SetBackImage")
                            {
                                position++;
                                Function_Control_SetBackImage(content, position, "buttonMenuClose");
                            }
                        }
                    }
                    else if(content[position]== "panelTop")
                    {
                        Control panel = GetControlFromName("panelTop");
                        position++;
                        if(content[position]== "roundedPanel1")
                        {
                            position++;
                            if (content[position] == "UseColorStyle")
                            {
                                position++;
                                Function_Control_useColorStyle(content, position, "roundedPanel1");
                                position++;
                                if(content[position] == "2UseColorStyle")
                                {
                                    position++;
                                    Tcolor tc = GetTcolorFromName(content[position]);
                                    if(tc != null)
                                    {
                                        RoundedPanel rp = form.Controls.Find("roundedPanel1", true).OfType<RoundedPanel>().First();
                                        if(rp != null)
                                        {
                                            rp.ExBackColor = tc.bcolor;
                                            rp.ColorEdges = tc.fcolor;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if(content[position]== "panelTopFinder")
                    {
                        Control panel = GetControlFromName("panelTopFinder");
                        position++;
                        if(content[position]== "roundedPanel2")
                        {
                            position++;
                            if (content[position] == "UseColorStyle")
                            {
                                position++;
                                Function_Control_useColorStyle(content, position, "roundedPanel2");
                                position++;
                                if(content[position] == "2UseColorStyle")
                                {
                                    position++;
                                    Tcolor tc = GetTcolorFromName(content[position]);
                                    if(tc != null)
                                    {
                                        RoundedPanel rp = form.Controls.Find("roundedPanel2", true).OfType<RoundedPanel>().First();
                                        if(rp != null)
                                        {
                                            rp.ExBackColor = tc.bcolor;
                                            rp.ColorEdges = tc.fcolor;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if(content[position] == "CtnPanel")
                    {
                        position++;
                        if (content[position] == "Panel")
                        {
                            position++;
                            if(content[position] == "BackColor")
                            {
                                position++;
                                if (content[position] == "Argb")
                                {
                                    try
                                    {
                                        position++;
                                        foreach (string s in autoCSC_find)
                                        {
                                            foreach (Control c in form.Controls.Find(s, true))
                                            {
                                                Function_Control_SetColorFromArgb(content, position, c, SetColor.BackColor);
                                            }
                                        }
                                    }
                                    catch (Exception exArgb)
                                    {
                                        Console.WriteLine(exArgb.ToString());
                                    }
                                    //Function_Control_SetColorFromArgb(content, position)
                                }
                            }
                            else if (content[position] == "ForeColor")
                            {
                                position++;
                                if (content[position] == "Argb")
                                {
                                    try
                                    {
                                        position++;
                                        foreach (string s in autoCSC_find)
                                        {
                                            foreach (Control c in form.Controls.Find(s, true))
                                            {
                                                Function_Control_SetColorFromArgb(content, position, c, SetColor.ForeColor);
                                            }
                                        }
                                    }
                                    catch (Exception exArgb)
                                    {
                                        Console.WriteLine(exArgb.ToString());
                                    }
                                    //Function_Control_SetColorFromArgb(content, position)
                                }
                            }
                        }
                        if (content[position] == "Button")
                        {
                            position++;
                            if(content[position] == "BackColor")
                            {
                                position++;
                                if (content[position] == "Argb")
                                {
                                    try
                                    {
                                        position++;
                                        foreach (string s in autoCSC_find)
                                        {
                                            foreach (Control c in form.Controls.Find(s, true))
                                            {
                                                if (c.Controls.Count > 0)
                                                {
                                                    foreach(Button b in c.Controls.OfType<Button>())
                                                    {
                                                        Function_Control_SetColorFromArgb(content, position, b, SetColor.BackColor);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception exArgb)
                                    {
                                        Console.WriteLine(exArgb.ToString());
                                    }
                                    //Function_Control_SetColorFromArgb(content, position)
                                }
                            }
                            else if (content[position] == "ForeColor")
                            {
                                position++;
                                if (content[position] == "Argb")
                                {
                                    try
                                    {
                                        position++;
                                        foreach (string s in autoCSC_find)
                                        {
                                            foreach (Control c in form.Controls.Find(s, true))
                                            {
                                                if (c.Controls.Count > 0)
                                                {
                                                    foreach (Button b in c.Controls.OfType<Button>())
                                                    {
                                                        Function_Control_SetColorFromArgb(content, position, b, SetColor.ForeColor);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception exArgb)
                                    {
                                        Console.WriteLine(exArgb.ToString());
                                    }
                                    //Function_Control_SetColorFromArgb(content, position)
                                }
                            }
                            else if (content[position] == "MouseDownBackColor")
                            {
                                try
                                {
                                    position++;
                                    string[] ar = content[position].Split(':');
                                    if (ar[0] == "Value")
                                    {
                                        if (ar[1].StartsWith("+"))
                                        {
                                            ar[1] = ar[1].Replace("+", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a;
                                            int b;
                                            int g;
                                            int r;
                                            foreach (string s in autoCSC_find)
                                            {
                                                foreach(Control c in GetArryControlsFromName(s))
                                                {
                                                    if (c != null)
                                                    {
                                                        foreach (Button btn in c.Controls.OfType<Button>())
                                                        {
                                                            a = btn.BackColor.A;
                                                            b = btn.BackColor.B;
                                                            g = btn.BackColor.G;
                                                            r = btn.BackColor.R;
                                                            if ((a + cVCH) < 255)
                                                            {
                                                                a = a + cVCH;
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, r, g, b);
                                                            }
                                                            if ((r + cVCH) < 255)
                                                            {
                                                                r = r + cVCH;
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, 255, g, b);
                                                            }
                                                            if ((g + cVCH) < 255)
                                                            {
                                                                g = g + cVCH;
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, 255, b);
                                                            }
                                                            if ((b + cVCH) < 255)
                                                            {
                                                                b = b + cVCH;
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, 255);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else if (ar[1].StartsWith("-"))
                                        {
                                            ar[1] = ar[1].Replace("-", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a;
                                            int b;
                                            int g;
                                            int r;
                                            foreach (string s in autoCSC_find)
                                            {
                                                foreach(Control c in GetArryControlsFromName(s))
                                                {
                                                    if (c != null)
                                                    {
                                                        foreach (Button btn in c.Controls.OfType<Button>())
                                                        {
                                                            a = btn.BackColor.A;
                                                            b = btn.BackColor.B;
                                                            g = btn.BackColor.G;
                                                            r = btn.BackColor.R;
                                                            if ((a - cVCH) > 0)
                                                            {
                                                                a = a - cVCH;
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, r, g, b);
                                                            }
                                                            if ((r - cVCH) > 0)
                                                            {
                                                                r = r - cVCH;
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, 0, g, b);
                                                            }
                                                            if ((g - cVCH) > 0)
                                                            {
                                                                g = g - cVCH;
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, 0, b);
                                                            }
                                                            if ((b - cVCH) > 0)
                                                            {
                                                                b = b - cVCH;
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(a, r, g, 0);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if(ar[0] == "Argb")
                                    {
                                        string[] sparse = ar[1].Split(',');
                                        Color colorNew = Color.FromArgb(int.Parse(sparse[0]), int.Parse(sparse[1]), int.Parse(sparse[2]), int.Parse(sparse[3]));
                                        foreach (string s in autoCSC_find)
                                        {
                                            foreach (Control c in GetArryControlsFromName(s))
                                            {
                                                if (c != null)
                                                {
                                                    foreach (Button btn in c.Controls.OfType<Button>())
                                                    {
                                                        btn.FlatAppearance.MouseDownBackColor= colorNew;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                catch (Exception exFlat)
                                {
                                    Console.WriteLine(exFlat.ToString());
                                }
                            }
                            else if (content[position] == "MouseOverBackColor")
                            {
                                try
                                {
                                    position++;
                                    string[] ar = content[position].Split(':');
                                    if (ar[0] == "Value")
                                    {
                                        if (ar[1].StartsWith("+"))
                                        {
                                            ar[1] = ar[1].Replace("+", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a;
                                            int b;
                                            int g;
                                            int r;
                                            foreach (string s in autoCSC_find)
                                            {
                                                foreach(Control c in GetArryControlsFromName(s))
                                                {
                                                    if (c != null)
                                                    {
                                                        foreach (Button btn in c.Controls.OfType<Button>())
                                                        {
                                                            a = btn.BackColor.A;
                                                            b = btn.BackColor.B;
                                                            g = btn.BackColor.G;
                                                            r = btn.BackColor.R;
                                                            if ((a + cVCH) < 255)
                                                            {
                                                                a = a + cVCH;
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, r, g, b);
                                                            }
                                                            if ((r + cVCH) < 255)
                                                            {
                                                                r = r + cVCH;
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, 255, g, b);
                                                            }
                                                            if ((g + cVCH) < 255)
                                                            {
                                                                g = g + cVCH;
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, 255, b);
                                                            }
                                                            if ((b + cVCH) < 255)
                                                            {
                                                                b = b + cVCH;
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, 255);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else if (ar[1].StartsWith("-"))
                                        {
                                            ar[1] = ar[1].Replace("-", "");
                                            int cVCH = int.Parse(ar[1]);
                                            int a;
                                            int b;
                                            int g;
                                            int r;
                                            foreach (string s in autoCSC_find)
                                            {
                                                foreach(Control c in GetArryControlsFromName(s))
                                                {
                                                    if (c != null)
                                                    {
                                                        foreach (Button btn in c.Controls.OfType<Button>())
                                                        {
                                                            a = btn.BackColor.A;
                                                            b = btn.BackColor.B;
                                                            g = btn.BackColor.G;
                                                            r = btn.BackColor.R;
                                                            if ((a - cVCH) > 0)
                                                            {
                                                                a = a - cVCH;
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, r, g, b);
                                                            }
                                                            if ((r - cVCH) > 0)
                                                            {
                                                                r = r - cVCH;
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, 0, g, b);
                                                            }
                                                            if ((g - cVCH) > 0)
                                                            {
                                                                g = g - cVCH;
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, 0, b);
                                                            }
                                                            if ((b - cVCH) > 0)
                                                            {
                                                                b = b - cVCH;
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, b);
                                                            }
                                                            else
                                                            {
                                                                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(a, r, g, 0);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (ar[0] == "Argb")
                                    {
                                        string[] sparse = ar[1].Split(',');
                                        Color colorNew = Color.FromArgb(int.Parse(sparse[0]), int.Parse(sparse[1]), int.Parse(sparse[2]), int.Parse(sparse[3]));
                                        foreach (string s in autoCSC_find)
                                        {
                                            foreach (Control c in GetArryControlsFromName(s))
                                            {
                                                if (c != null)
                                                {
                                                    foreach (Button btn in c.Controls.OfType<Button>())
                                                    {
                                                        btn.FlatAppearance.MouseOverBackColor = colorNew;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                catch (Exception exFlat)
                                {
                                    Console.WriteLine(exFlat.ToString());
                                }
                            }
                        }
                        if (content[position] == "PictureBox")
                        {
                            position++;
                            if(content[position] == "BackColor")
                            {
                                position++;
                                if (content[position] == "Argb")
                                {
                                    try
                                    {
                                        position++;
                                        foreach (string s in autoCSC_find)
                                        {
                                            foreach (Control c in form.Controls.Find(s, true))
                                            {
                                                if (c.Controls.Count > 0)
                                                {
                                                    foreach(PictureBox p in c.Controls.OfType<PictureBox>())
                                                    {
                                                        Function_Control_SetColorFromArgb(content, position, p, SetColor.BackColor);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception exArgb)
                                    {
                                        Console.WriteLine(exArgb.ToString());
                                    }
                                    //Function_Control_SetColorFromArgb(content, position)
                                }
                            }
                            else if (content[position] == "ForeColor")
                            {
                                position++;
                                if (content[position] == "Argb")
                                {
                                    try
                                    {
                                        position++;
                                        foreach (string s in autoCSC_find)
                                        {
                                            foreach (Control c in form.Controls.Find(s, true))
                                            {
                                                if (c.Controls.Count > 0)
                                                {
                                                    foreach (PictureBox p in c.Controls.OfType<PictureBox>())
                                                    {
                                                        Function_Control_SetColorFromArgb(content, position, p, SetColor.ForeColor);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception exArgb)
                                    {
                                        Console.WriteLine(exArgb.ToString());
                                    }
                                    //Function_Control_SetColorFromArgb(content, position)
                                }
                            }
                        }
                    }
                    else if (content[position] == "PageEpisode_Colors")
                    {
                        position++;
                        try
                        {
                            string[] ar = content[position].Split(',');
                            tchColors.PageEpisode_BackColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            position++;
                            ar = content[position].Split(',');
                            tchColors.PageEpisode_ForeColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            position++;
                            ar = content[position].Split(',');
                            tchColors.PageEpisode_BackColor2 = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                        }
                        catch (Exception exArgb)
                        {
                            Console.WriteLine(exArgb.ToString());
                        }
                    }
                    else if(content[position] == "Global")
                    {
                        position++;
                        if(content[position] =="ColorStyle")
                        {
                            try
                            {
                                position++;
                                Tcolor tc = GetTcolorFromName(content[position]);
                                form.BackColor = tc.bcolor;
                            }
                            catch(Exception exColorStyle)
                            {
                                Console.WriteLine(exColorStyle.ToString());
                            }
                        }
                    }
                    else if (content[position] == "CtnPanel_Colors")
                    {
                        position++;
                        try
                        {
                            string[] ar = content[position].Split(',');
                            tchColors.CtnPanel_MainBackColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            position++;
                            ar = content[position].Split(',');
                            tchColors.CtnPanel_MainForeColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            position++;
                            ar = content[position].Split(',');
                            tchColors.CtnPanel_ButtonBackColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            position++;
                            ar = content[position].Split(',');
                            tchColors.CtnPanel_ButtonForeColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            position++;
                            ar = content[position].Split(',');
                            tchColors.CtnPanel_ButtonMouseDownBackColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            position++;
                            ar = content[position].Split(',');
                            tchColors.CtnPanel_ButtonMouseOverBackColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                        }
                        catch (Exception exArgb)
                        {
                            Console.WriteLine(exArgb.ToString());
                        }
                    }
                    else if (content[position] == "PageItem_Colors")
                    {
                        position++;
                        try
                        {
                            string[] ar = content[position].Split(',');
                            tchColors.PageItem_BackColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            position++;
                            ar = content[position].Split(',');
                            tchColors.PageItem_BackColor2 = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            position++;
                            ar = content[position].Split(',');
                            tchColors.PageItem_BackColor3 = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            position++;
                            ar = content[position].Split(',');
                            tchColors.PageItem_BackColor4 = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                            position++;
                            ar = content[position].Split(',');
                            tchColors.PageItem_ForeColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                        }
                        catch (Exception exArgb)
                        {
                            Console.WriteLine(exArgb.ToString());
                        }
                    }
                    else if(content[position] == "panelStartPageSetNoBackColor")
                    {
                        panelStartPageSetNoBackColor();
                    }
                    position++;
                }
            }
            catch (Exception)
            {

            }
        }

        public Control GetControlFromName(string name)
        {
            try
            {
                Control ctn = form.Controls.Find(name, true).First();
                return ctn;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        public Control[] GetArryControlsFromName(string name)
        {
            try
            {
                Control[] ctns = form.Controls.Find(name, true);
                return ctns;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public Tcolor GetTcolorFromName(string name)
        {
            try
            {
                Tcolor tcolor = colorsTheme.FindAll(x => x.name == name)[0];
                return tcolor;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public void panelStartPageSetNoBackColor()
        {
            try
            {
                Control ctn = GetControlFromName("panelStartPage");
                ctn.BackColor = Color.Transparent;
                foreach(Panel p in ctn.Controls.OfType<Panel>())
                {
                    p.BackColor = Color.Transparent;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine();
            }
        }

        #region ThemeChanger Script Function

        public enum SetColor:int
        {
            BackColor = 0,
            ForeColor = 1
        }


        public void Function_Control_SetMouseOverBackColor(string[] c, int p, Button btn)
        {
            try
            {
                string[] ar = c[p].Split(',');
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
            }
            catch (Exception exArgb)
            {
                Console.WriteLine(exArgb.ToString());
            }
        }

        public void Function_Control_SetMouseDownBackColor(string[] c, int p, Button btn)
        {
            try
            {
                string[] ar = c[p].Split(',');
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
            }
            catch (Exception exArgb)
            {
                Console.WriteLine(exArgb.ToString());
            }
        }

        public void Function_Control_SetColorFromArgb(string[] c, int p, Control ctn, SetColor sc)
        {
            try
            {
                string[] ar = c[p].Split(',');
                if(sc == SetColor.BackColor)
                {
                    ctn.BackColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                }
                else if(sc == SetColor.ForeColor)
                {
                    ctn.ForeColor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                }
                
            }
            catch (Exception exArgb)
            {
                Console.WriteLine(exArgb.ToString());
            }
        }

        public void Function_Control_SetBackImage(string[] c,int p, string name)
        {
            try
            {
                Control ctn = form.Controls.Find(name, true)[0];
                ctn.BackgroundImage = Image.FromFile(c[p]);
                ctn.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception exSetBackImage)
            {
                Console.WriteLine(exSetBackImage.ToString());
            }
        }
        public void Function_Button_SetImage(string[] c, int p, string name)
        {
            try
            {
                Button btn = form.Controls.Find(name,true).OfType<Button>().First();
                btn.Image = Image.FromFile(c[p]);
            }
            catch (Exception exSetBackImage)
            {
                Console.WriteLine(exSetBackImage.ToString());
            }
        }

        public void Function_Control_useColorStyle(string[] c,int p, string name, bool OnCtnSetColor = false)
        {
            Control cfind = form.Controls.Find(name, true)[0];
            Tcolor tcolor = colorsTheme.FindAll(x => x.name == c[p])[0];
            if(OnCtnSetColor)
            {
                cfind.BackColor = tcolor.bcolor;
                cfind.ForeColor = tcolor.fcolor;
            }
            foreach (Control co in cfind.Controls)
            {
                SetColorOnControl(co, tcolor);
            }
        }

        #endregion ThemeChanger Script Function

        public void SetColorinClass(Tcolor tc)
        {
            try
            {
                (Color c, bool f) = Fname(tc.sbackcolor);
                if (f)
                {
                    tc.bcolor = c;
                }
                else
                {
                    string[] ar = tc.sbackcolor.Split(';');
                    tc.bcolor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                }

                (Color c2, bool f2) = Fname(tc.sforecolor);
                if (f2)
                {
                    tc.fcolor = c2;
                }
                else
                {
                    string[] ar = tc.sforecolor.Split(';');
                    tc.fcolor = Color.FromArgb(int.Parse(ar[0]), int.Parse(ar[1]), int.Parse(ar[2]), int.Parse(ar[3]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public (Color, bool) Fname(string n)
        {
            try
            {
                return (Color.FromName(n), true);

            }
            catch
            {
                return (Color.White, false);
            }
        }

        public void SetColorOnControl(Control ctn, Tcolor tc)
        {
            try
            {
                ctn.BackColor = tc.bcolor;
                ctn.ForeColor = tc.fcolor;
                if (ctn.Controls.Count > 0)
                {
                    foreach (Control c in ctn.Controls)
                    {
                        SetColorOnControl(c, tc);
                    }
                }
                ctn.BackColor = tc.bcolor;
                ctn.ForeColor = tc.fcolor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public static void SetForeColorOnControls(Control ctn, Color f)
        {
            try
            {
                ctn.ForeColor = f;
                if (ctn.Controls.Count > 0)
                {
                    foreach (Control c in ctn.Controls)
                    {
                        SetForeColorOnControls(c, f);
                    }
                }
                ctn.ForeColor= f;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void SetColorForeAndBackOnAllContorls(Control ctn,Color f,Color b)
        {
            try
            {
                foreach(Control c in ctn.Controls)
                {
                    c.BackColor = b;
                    c.ForeColor = f;
                    if(c.Controls.Count > 0)
                    {
                        SetColorForeAndBackOnAllContorls(c, f, b);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
