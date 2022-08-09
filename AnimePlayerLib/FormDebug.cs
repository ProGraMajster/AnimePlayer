using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AnimePlayerLibrary
{
    public partial class FormDebug : Form
    {
        public FormDebug()
        {
            InitializeComponent();
        }

        public Form form;

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    propertyGrid1.SelectedObject = form.Controls.Find(textBox1.Text, true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void BWLoadListControls_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                richTextBoxListControls.Clear();
                treeView1.Nodes.Clear();
                if (form != null)
                {
                    TreeNode treeNode = new()
                    {
                        Text = form.Name,
                        ToolTipText = form.Name + " | " + form.GetType().ToString()
                    };
                    foreach (Control ctn in form.Controls)
                    {
                        TreeNode sub = new()
                        {
                            Text = ctn.Name,
                            ToolTipText = ctn.Name + " | " + ctn.GetType().ToString()
                        };
                        this.Invoke(new Action(() => richTextBoxListControls.Text += ctn.Name+Environment.NewLine));
                        if(ctn.Controls.Count > 0)
                        {
                            GetControlsName(ctn,sub);
                        }
                        treeNode.Nodes.Add(sub);
                    }
                    this.Invoke(new Action(() => treeView1.Nodes.Add(treeNode)));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        int v = 0;

        public void GetControlsName(Control c, TreeNode node)
        {
            v++;
            foreach (Control ctn in c.Controls)
            {
                TreeNode sub = new();
                if(ctn.Name.Length > 0)
                {
                    sub.Text = ctn.Name;
                    sub.ToolTipText = ctn.Name+" -- "+ctn.GetType().ToString();
                }
                else
                {
                    sub.Text = "<NoName>";
                }
                this.Invoke(new Action(() => richTextBoxListControls.Text += GetTab(v)+ctn.Name + Environment.NewLine));
                if (ctn.Controls.Count > 0)
                {
                    GetControlsName(ctn, sub);
                }
                node.Nodes.Add(sub);
            }
            v--;
            if(v<0)
            {
                v = 0;
            }
        }

        public static string GetTab(int t)
        {
            string r = null;
            for(int i = 0; i < t; i++)
            {
                r += "| ";
            }
            return r;
        }

        private void FormDebug_Load(object sender, EventArgs e)
        {
            bWLoadListControls.RunWorkerAsync();
            if(form != null)
            {
                count = form.Controls.Count;
            }
            timerCheckCountControlsInForm.Start();
        }

        int count;

        private void TimerCheckCountControlsInForm_Tick(object sender, EventArgs e)
        {
            if(form != null)
            {
                if(count != form.Controls.Count)
                {
                    bWLoadListControls.RunWorkerAsync();
                }
            }
        }

        private void RichTextBoxListControls_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F5:
                    {
                        if(!bWLoadListControls.IsBusy)
                        {
                            bWLoadListControls.RunWorkerAsync();
                        }
                        break;
                    }
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void ButtonSaveConsoleLogs_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void FormDebug_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                try
                {

                    richTextBoxListControls.Clear();
                    treeView1.Nodes.Clear();
                    if (form != null)
                    {
                        TreeNode treeNode = new()
                        {
                            Text = form.Name,
                            ToolTipText = form.Name + " -- " + form.GetType().ToString()
                        };
                        foreach (Control ctn in form.Controls)
                        {
                            TreeNode sub = new()
                            {
                                Text = ctn.Name,
                                ToolTipText = ctn.Name + " -- " + ctn.GetType().ToString()
                            };
                            this.Invoke(new Action(() => richTextBoxListControls.Text += ctn.Name + Environment.NewLine));
                            if (ctn.Controls.Count > 0)
                            {
                                GetControlsName(ctn, sub);
                            }
                            treeNode.Nodes.Add(sub);
                        }
                        this.Invoke(new Action(() => treeView1.Nodes.Add(treeNode)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void TreeView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                propertyGrid1.SelectedObject = form.Controls.Find(treeView1.SelectedNode.Text, true);
                textBox1.Text = treeView1.SelectedNode.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
    }
}
