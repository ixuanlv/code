namespace 个人资料管理
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.addgen = new System.Windows.Forms.Button();
            this.addzi = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.rename = new System.Windows.Forms.Button();
            this.addtext = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(22, 76);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(244, 458);
            this.treeView1.TabIndex = 0;
            // 
            // addgen
            // 
            this.addgen.Location = new System.Drawing.Point(22, 35);
            this.addgen.Name = "addgen";
            this.addgen.Size = new System.Drawing.Size(75, 23);
            this.addgen.TabIndex = 2;
            this.addgen.Text = "添加根节点";
            this.addgen.UseVisualStyleBackColor = true;
            this.addgen.Click += new System.EventHandler(this.addgen_Click);
            // 
            // addzi
            // 
            this.addzi.Location = new System.Drawing.Point(119, 35);
            this.addzi.Name = "addzi";
            this.addzi.Size = new System.Drawing.Size(75, 23);
            this.addzi.TabIndex = 5;
            this.addzi.Text = "添加子节点";
            this.addzi.UseVisualStyleBackColor = true;
            this.addzi.Click += new System.EventHandler(this.addzi_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(309, 76);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(536, 458);
            this.text.TabIndex = 6;
            this.text.Visible = false;
            // 
            // rename
            // 
            this.rename.Location = new System.Drawing.Point(432, 35);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(75, 23);
            this.rename.TabIndex = 7;
            this.rename.Text = "重命名";
            this.rename.UseVisualStyleBackColor = true;
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // addtext
            // 
            this.addtext.Location = new System.Drawing.Point(332, 35);
            this.addtext.Name = "addtext";
            this.addtext.Size = new System.Drawing.Size(75, 23);
            this.addtext.TabIndex = 8;
            this.addtext.Text = "添加资料";
            this.addtext.UseVisualStyleBackColor = true;
            this.addtext.Click += new System.EventHandler(this.addtext_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(228, 35);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 9;
            this.remove.Text = "删除节点";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 560);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.addtext);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.text);
            this.Controls.Add(this.addzi);
            this.Controls.Add(this.addgen);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button addgen;
        private System.Windows.Forms.Button addzi;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.Button addtext;
        private System.Windows.Forms.Button remove;
    }
}

