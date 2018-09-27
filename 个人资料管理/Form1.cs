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
        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.LabelEdit = true;
           
        }

        private void addgen_Click(object sender, EventArgs e)
        {
            //text.Visible = false;
            //Form2 gen = new Form2();
            //gen.Show();
            treeView1.Nodes.Add("新建文件");
            //treeView1.LabelEdit = true;
            //treeView1.SelectedNode.BeginEdit();

        }

        private void addzi_Click(object sender, EventArgs e)
        {
            //Form3 zi = new Form3();
            //zi.Show();
            //text.Visible = false;
            if (treeView1.SelectedNode != null)//判断是否存在选择节点
            {
                treeView1.SelectedNode.Nodes.Add("新建文件");
            }
            else
            {
                MessageBox.Show("请选择节点后操作");
            }
           
           // treeView1.SelectedNode.BeginEdit();
        }


        private void rename_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)//判断是否存在选择节点
            {
                treeView1.SelectedNode.BeginEdit();
            }
            else
            {
                MessageBox.Show("请选择节点后操作");
            }
        }

        private void addtext_Click(object sender, EventArgs e)
        {
            text.Visible = true;
        }





        //private void treeView1_MouseClick(object sender, MouseEventArgs e)
        //{
        //        TreeView tv = (TreeView)sender;//获取treeview
        //        if (e.Button == MouseButtons.Right)//判断是否鼠标右键
        //        {
        //             tv.SelectedNode.BeginEdit();
        //        }
        //}


        //private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        //{
        //    string newTxt = e.Label;//获取新文本
        //    string id = e.Node.Text;//获取原来的文本

        //    //进行你的更新操作
        //}


    }



   
}
