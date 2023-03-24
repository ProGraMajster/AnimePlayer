using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AnimePlayer.Class;
using AnimePlayer.Core;

namespace AnimePlayerLibrary.UI
{
    public partial class DefinitionsPage : UserControl
    {
        public DefinitionsPage()
        {
            InitializeComponent();
            definitionsPage = (DefinitionsPage)this;
        }

        readonly DefinitionsPage definitionsPage;
        public void GetAllDefinitions()
        {
            _=Task.Run(() =>
            {
                if (!Directory.Exists(AppFolders.UpdatedDefined))
                {
                    return;
                }
                DirectoryInfo directoryInfo = new(AppFolders.UpdatedDefined_PlaceAndTime);
                TreeNode treeNode = new("Miejsce i czas");
                foreach (var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new(item.Name.Replace(".dat", ""))
                    {
                        Tag = item.FullName
                    };
                    treeNode.Nodes.Add(treeNodeItem);
                }
                this.Invoke(() =>
                {
                    treeView1.Nodes.Add(treeNode);
                });

                directoryInfo = new DirectoryInfo(AppFolders.UpdatedDefined_Species);
                treeNode = new TreeNode("Gatunki");
                foreach (var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new(item.Name.Replace(".dat", ""))
                    {
                        Tag = item.FullName
                    };
                    treeNode.Nodes.Add(treeNodeItem);
                }
                this.Invoke(() =>
                {
                    treeView1.Nodes.Add(treeNode);
                });

                directoryInfo = new DirectoryInfo(AppFolders.UpdatedDefined_TargetGroups);
                treeNode = new TreeNode("Grupa docelowa");
                foreach (var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new(item.Name.Replace(".dat", ""))
                    {
                        Tag = item.FullName
                    };
                    treeNode.Nodes.Add(treeNodeItem);
                }
                this.Invoke(() =>
                {
                    treeView1.Nodes.Add(treeNode);
                });

                directoryInfo = new DirectoryInfo(AppFolders.UpdatedDefined_TypesOfCharacters);
                treeNode = new TreeNode("Rodzaje postaci");
                foreach (var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new(item.Name.Replace(".dat", ""))
                    {
                        Tag = item.FullName
                    };
                    treeNode.Nodes.Add(treeNodeItem);
                }
                this.Invoke(() =>
                {
                    treeView1.Nodes.Add(treeNode);
                });
            });
        }

        private void DefinitionsPage_Load(object sender, EventArgs e)
        {
            GetAllDefinitions();
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            panelF.Hide();
            label1.Show();

            if (e.Node == null)
            {
                return;
            }

            if(e.Node.Text ==  "Miejsce i czas")
            {
                label1.Text = "Miejsce i czas\nOpis:\n" +
                    "Miejsce i/bądź czas, w którym rozgrywa się dane anime lub manga," +
                    " może to być np. średniowieczna Europa, kosmos itp.\n\n" +e.Node.Nodes.Count +"Tagi(ów)";
            }
            else if(e.Node.Text=="Gatunki")
            {
                label1.Text = "Gatunki\nOpis:\n" +
                    "Gatunki najczęściej występujące w anime i mandze\n\n"+e.Node.Nodes.Count +"Tagi(ów)"; ;
            }
            else if(e.Node.Text=="Grupa docelowa")
            {
                label1.Text = "Grupa docelowa\nOpis:\n" +
                    "Grupy, do których adresowane są serie, zawierają głównie grupy wiekowe\n\n"+e.Node.Nodes.Count +"Tagi(ów)"; ;
            }
            else if(e.Node.Text == "Rodzaje postaci")
            {
                label1.Text = "Rodzaje postaci\nOpis:\n" +
                    "Typy postaci występujące w anime i mandze, do tej kategorii mogą należeć np. wampiry lub postacie chibi\n\n"+e.Node.Nodes.Count +"Tagi(ów)"; ;
            }
            else
            {
                if (e.Node.Tag == null)
                {
                    return;
                }
                if (!File.Exists(e.Node.Tag.ToString()))
                {
                    return;
                }
                Definition definition = (Definition)SerializationAndDeserialization
                    .DeserializationJsonEx(e.Node.Tag.ToString(),typeof(Definition));
                label1.Text = definition.Name+"\nOpis:\n"+definition.Description;
            }
            
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            panelF.Hide();
            label1.Show();
            if (e.Node == null)
            {
                return;
            }


            if (e.Node.Text ==  "Miejsce i czas")
            {
                label1.Text = "Miejsce i czas\nOpis:\n" +
                    "Miejsce i/bądź czas, w którym rozgrywa się dane anime lub manga," +
                    " może to być np. średniowieczna Europa, kosmos itp.\n\n" +e.Node.Nodes.Count +"Tagi(ów)";
            }
            else if (e.Node.Text=="Gatunki")
            {
                label1.Text = "Gatunki\nOpis:\n" +
                    "Gatunki najczęściej występujące w anime i mandze\n\n"+e.Node.Nodes.Count +"Tagi(ów)"; ;
            }
            else if (e.Node.Text=="Grupa docelowa")
            {
                label1.Text = "Grupa docelowa\nOpis:\n" +
                    "Grupy, do których adresowane są serie, zawierają głównie grupy wiekowe\n\n"+e.Node.Nodes.Count +"Tagi(ów)"; ;
            }
            else if (e.Node.Text == "Rodzaje postaci")
            {
                label1.Text = "Rodzaje postaci\nOpis:\n" +
                    "Typy postaci występujące w anime i mandze, do tej kategorii mogą należeć np. wampiry lub postacie chibi\n\n"+e.Node.Nodes.Count +"Tagi(ów)"; ;
            }
            else
            {
                if (e.Node.Tag == null)
                {
                    return;
                }
                if (!File.Exists(e.Node.Tag.ToString()))
                {
                    return;
                }
                Definition definition = (Definition)SerializationAndDeserialization
                    .DeserializationJsonEx(e.Node.Tag.ToString(), typeof(Definition));
                label1.Text = definition.Name+"\nOpis:\n"+definition.Description;
            }
        }

        private void ButtonCloseDefinitionsPage_Click(object sender, EventArgs e)
        {
            definitionsPage.Dispose();
        }

        private void ButtonFindDefinion_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Hide();
                panelF.Show();
                panelF.BringToFront();
                treeView2.Nodes.Clear();
                if (!Directory.Exists(AppFolders.UpdatedDefined))
                {
                    return;
                }
                DirectoryInfo directoryInfo = new(AppFolders.UpdatedDefined_PlaceAndTime);
                TreeNode treeNode = new("Miejsce i czas");
                foreach (var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new(item.Name.Replace(".dat", ""))
                    {
                        Tag = item.FullName
                    };
                    Definition definition = (Definition)SerializationAndDeserialization.DeserializationJsonEx(item.FullName, typeof(Definition));
                    if(definition.Name.Contains(textBoxFind.Text))
                    {
                        treeNode.Nodes.Add(treeNodeItem);
                    }
                }
                this.Invoke(() =>
                {
                    treeView2.Nodes.Add(treeNode);
                });

                directoryInfo = new DirectoryInfo(AppFolders.UpdatedDefined_Species);
                treeNode = new TreeNode("Gatunki");
                foreach (var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new(item.Name.Replace(".dat", ""))
                    {
                        Tag = item.FullName
                    };
                    Definition definition = (Definition)SerializationAndDeserialization.DeserializationJsonEx(item.FullName, typeof(Definition));
                    if (definition.Name.Contains(textBoxFind.Text))
                    {
                        treeNode.Nodes.Add(treeNodeItem);
                    }
                }
                this.Invoke(() =>
                {
                    treeView2.Nodes.Add(treeNode);
                });

                directoryInfo = new DirectoryInfo(AppFolders.UpdatedDefined_TargetGroups);
                treeNode = new TreeNode("Grupa docelowa");
                foreach (var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new(item.Name.Replace(".dat", ""))
                    {
                        Tag = item.FullName
                    };
                    Definition definition = (Definition)SerializationAndDeserialization.DeserializationJsonEx(item.FullName, typeof(Definition));
                    if (definition.Name.Contains(textBoxFind.Text))
                    {
                        treeNode.Nodes.Add(treeNodeItem);
                    }
                }
                this.Invoke(() =>
                {
                    treeView2.Nodes.Add(treeNode);
                });

                directoryInfo = new DirectoryInfo(AppFolders.UpdatedDefined_TypesOfCharacters);
                treeNode = new TreeNode("Rodzaje postaci");
                foreach (var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new(item.Name.Replace(".dat", ""))
                    {
                        Tag = item.FullName
                    };
                    Definition definition = (Definition)SerializationAndDeserialization.DeserializationJsonEx(item.FullName, typeof(Definition));
                    if (definition.Name.Contains(textBoxFind.Text))
                    {
                        treeNode.Nodes.Add(treeNodeItem);
                    }
                }
                this.Invoke(() =>
                {
                    treeView2.Nodes.Add(treeNode);
                });
            }
            catch(Exception ex)
            {   
                Console.Error.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
            {
                return;
            }


            if (e.Node.Text == "Miejsce i czas")
            {
                label3.Text = "Miejsce i czas\nOpis:\n" +
                    "Miejsce i/bądź czas, w którym rozgrywa się dane anime lub manga," +
                    " może to być np. średniowieczna Europa, kosmos itp.\n\n" + e.Node.Nodes.Count + "Tagi(ów)";
            }
            else if (e.Node.Text == "Gatunki")
            {
                label3.Text = "Gatunki\nOpis:\n" +
                    "Gatunki najczęściej występujące w anime i mandze\n\n" + e.Node.Nodes.Count + "Tagi(ów)"; ;
            }
            else if (e.Node.Text == "Grupa docelowa")
            {
                label3.Text = "Grupa docelowa\nOpis:\n" +
                    "Grupy, do których adresowane są serie, zawierają głównie grupy wiekowe\n\n" + e.Node.Nodes.Count + "Tagi(ów)"; ;
            }
            else if (e.Node.Text == "Rodzaje postaci")
            {
                label3.Text = "Rodzaje postaci\nOpis:\n" +
                    "Typy postaci występujące w anime i mandze, do tej kategorii mogą należeć np. wampiry lub postacie chibi\n\n" + e.Node.Nodes.Count + "Tagi(ów)"; ;
            }
            else
            {
                if (e.Node.Tag == null)
                {
                    return;
                }
                if (!File.Exists(e.Node.Tag.ToString()))
                {
                    return;
                }
                Definition definition = (Definition)SerializationAndDeserialization.DeserializationJsonEx(e.Node.Tag.ToString(), typeof(Definition));
                label3.Text = definition.Name + "\nOpis:\n" + definition.Description;
            }
        }

        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null)
            {
                return;
            }

            if (e.Node.Text == "Miejsce i czas")
            {
                label3.Text = "Miejsce i czas\nOpis:\n" +
                    "Miejsce i/bądź czas, w którym rozgrywa się dane anime lub manga," +
                    " może to być np. średniowieczna Europa, kosmos itp.\n\n" + e.Node.Nodes.Count + "Tagi(ów)";
            }
            else if (e.Node.Text == "Gatunki")
            {
                label3.Text = "Gatunki\nOpis:\n" +
                    "Gatunki najczęściej występujące w anime i mandze\n\n" + e.Node.Nodes.Count + "Tagi(ów)"; ;
            }
            else if (e.Node.Text == "Grupa docelowa")
            {
                label3.Text = "Grupa docelowa\nOpis:\n" +
                    "Grupy, do których adresowane są serie, zawierają głównie grupy wiekowe\n\n" + e.Node.Nodes.Count + "Tagi(ów)"; ;
            }
            else if (e.Node.Text == "Rodzaje postaci")
            {
                label3.Text = "Rodzaje postaci\nOpis:\n" +
                    "Typy postaci występujące w anime i mandze, do tej kategorii mogą należeć np. wampiry lub postacie chibi\n\n" + e.Node.Nodes.Count + "Tagi(ów)"; ;
            }
            else
            {
                if (e.Node.Tag == null)
                {
                    return;
                }
                if (!File.Exists(e.Node.Tag.ToString()))
                {
                    return;
                }
                Definition definition = (Definition)SerializationAndDeserialization.DeserializationJsonEx(e.Node.Tag.ToString(), typeof(Definition));
                label3.Text = definition.Name + "\nOpis:\n" + definition.Description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelF.Hide();
            label1.Show();
        }
    }
}
