using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 个人资料管理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void addgen_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(addgentext.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addzi_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(addzitext.Text);
        }
    }
}
