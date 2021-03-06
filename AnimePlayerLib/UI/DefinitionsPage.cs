using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        DefinitionsPage definitionsPage;
        public void GetAllDefinitions()
        {
            Task.Run(() =>
            {
                if(!Directory.Exists(AppFolders.UpdatedDefined))
                {
                    return;
                }
                DirectoryInfo directoryInfo = new DirectoryInfo(AppFolders.UpdatedDefined_PlaceAndTime);
                TreeNode treeNode = new TreeNode("Miejsce i czas");
                foreach(var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new TreeNode(item.Name.Replace(".dat", ""));
                    treeNodeItem.Tag = item.FullName;
                    treeNode.Nodes.Add(treeNodeItem);
                }
                this.Invoke(() =>
                {
                    treeView1.Nodes.Add(treeNode);
                });

                directoryInfo = new DirectoryInfo(AppFolders.UpdatedDefined_Species);
                treeNode = new TreeNode("Gatunki");
                foreach(var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new TreeNode(item.Name.Replace(".dat",""));
                    treeNodeItem.Tag = item.FullName;
                    treeNode.Nodes.Add(treeNodeItem);
                }
                this.Invoke(() =>
                {
                    treeView1.Nodes.Add(treeNode);
                });

                directoryInfo = new DirectoryInfo(AppFolders.UpdatedDefined_TargetGroups);
                treeNode = new TreeNode("Grupa docelowa");
                foreach(var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new TreeNode(item.Name.Replace(".dat", ""));
                    treeNodeItem.Tag = item.FullName;
                    treeNode.Nodes.Add(treeNodeItem);
                }
                this.Invoke(() =>
                {
                    treeView1.Nodes.Add(treeNode);
                });

                directoryInfo = new DirectoryInfo(AppFolders.UpdatedDefined_TypesOfCharacters);
                treeNode = new TreeNode("Rodzaje postaci");
                foreach(var item in directoryInfo.GetFiles())
                {
                    TreeNode treeNodeItem = new TreeNode(item.Name.Replace(".dat", ""));
                    treeNodeItem.Tag = item.FullName;
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

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null)
            {
                return;
            }

            if (e.Node.Tag == null)
            {
                return;
            }

            if (!File.Exists(e.Node.Tag.ToString()))
            {
                return;
            }

            Definition definition = (Definition)SerializationAndDeserialization.Deserialization(e.Node.Tag.ToString());

            label1.Text = definition.Name+"\nOpis:\n"+definition.Description;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
            {
                return;
            }

            if (e.Node.Tag == null)
            {
                return;
            }

            if (!File.Exists(e.Node.Tag.ToString()))
            {
                return;
            }

            Definition definition = (Definition)SerializationAndDeserialization.Deserialization(e.Node.Tag.ToString());

            label1.Text = definition.Name+"\nOpis:\n"+definition.Description;
        }

        private void buttonCloseDefinitionsPage_Click(object sender, EventArgs e)
        {
            definitionsPage.Dispose();
        }

        private void buttonFindDefinion_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode treeNode = treeView1.Nodes.Find(textBoxFind.Text, true)[0];

                if (treeNode.Tag == null)
                {
                    return;
                }

                if (!File.Exists(treeNode.Tag.ToString()))
                {
                    return;
                }

                Definition definition = (Definition)SerializationAndDeserialization.Deserialization(treeNode.Tag.ToString());

                label1.Text = definition.Name+"\nOpis:\n"+definition.Description;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
    }
}
