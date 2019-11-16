using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public partial class Form1 : Form
    {
        Form oldForm;
        Panel oldPanel;
        public Form1()
        {
            InitializeComponent();
            treeView1.Nodes[0].Expand();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Tag.ToString()== "1")
            {
                var glebWiF = new gleb();
                SetPanel(glebWiF, glebWiF.panel1);
            }
            if (e.Node.Tag.ToString() == "3")
            {
                var dimaWiF = new dima();
                SetPanel(dimaWiF, dimaWiF.panel1);
            }
            if (e.Node.Tag.ToString() == "2")
            {
                var van = new van();
                SetPanel(van, van.panel1);
            }
        }
        private void SetPanel(Form parentForm , Panel parentPanel)
        {
            if (oldForm != null)
            {
                oldPanel.Parent = oldForm;
            }
            parentPanel.Parent = panelControl;
            oldForm = parentForm;
            oldPanel = parentPanel;
        }
    }
}
