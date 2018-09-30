using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


            String fu = "select * from fu";
            DataSet Datafu = new DataSet();
            SqlConnection constr;
            constr = new SqlConnection("server=.;database=fuzi;integrated security = SSPI");
            constr.Open();
            SqlDataAdapter sqlfu = new SqlDataAdapter(fu, constr);
            sqlfu.Fill(Datafu, "1");

            foreach (DataRow row in Datafu.Tables["1"].Rows)
            {
                string name = row[0].ToString();
               
                treeView1.Nodes.Add(name);
            }

        }

        //string zi = "select zi.name,zi.text from zi inner join  fu on zi.name = fu.name where fu.name='" + name + "'";
        //SqlDataAdapter sqlzi = new SqlDataAdapter(zi, constr);
        //sqlzi.Fill(Datazi, "1");
        //foreach (DataRow row1 in Datazi.Tables["1"].Rows)
        //{
        //    string lablezi = row1[0].ToString();
        //    string textzi = row1[1].ToString();
        //    Console.WriteLine(lablezi + "    " + textzi);
        //}



        //Console.WriteLine(xxx.lablezi + "+++" + xxx.textzi);



        //String zi = "select * from zi where name='" + name + "'";
        //SqlDataAdapter sqlzi = new SqlDataAdapter(zi, constr);
        //sqlfu.Fill(Datazi, "1");

        //foreach (DataRow row1 in Datazi.Tables["1"].Rows)
        //{
        //    String lablefu = row1[2].ToString();
        //    String name = row1[1].ToString();
        //    int sum = int.Parse1(row[3].ToString());

        //}

     
        private void addgen_Click(object sender, EventArgs e)
        {
            
            Form2 addfjd = new Form2();
          
            addfjd.Show();
           
            //rename_Click(sender, e);
            //String s = treeView1.SelectedNode.Text;
            //TreeNode nd = new TreeNode(s);

            //treeView1.SelectedNode = nd;

            //treeView1.Nodes.Add(s);
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

        private void addzi_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)//判断是否存在选择节点
            {
                TreeNode nd = new TreeNode("默认标题");
                treeView1.SelectedNode.Nodes.Add(nd);
                treeView1.SelectedNode = nd;
                rename_Click(sender, e);

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

        private void remove_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)//判断是否存在选择节点
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);







            }
            else
            {
                MessageBox.Show("请选择节点后操作");
            }
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
