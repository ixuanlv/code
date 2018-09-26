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
            this.addgentext = new System.Windows.Forms.TextBox();
            this.addzitext = new System.Windows.Forms.TextBox();
            this.addzi = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.addgen.Location = new System.Drawing.Point(161, 35);
            this.addgen.Name = "addgen";
            this.addgen.Size = new System.Drawing.Size(75, 23);
            this.addgen.TabIndex = 2;
            this.addgen.Text = "添加根节点";
            this.addgen.UseVisualStyleBackColor = true;
            this.addgen.Click += new System.EventHandler(this.addgen_Click);
            // 
            // addgentext
            // 
            this.addgentext.Location = new System.Drawing.Point(38, 36);
            this.addgentext.Name = "addgentext";
            this.addgentext.Size = new System.Drawing.Size(100, 21);
            this.addgentext.TabIndex = 3;
            // 
            // addzitext
            // 
            this.addzitext.Location = new System.Drawing.Point(267, 36);
            this.addzitext.Name = "addzitext";
            this.addzitext.Size = new System.Drawing.Size(100, 21);
            this.addzitext.TabIndex = 4;
            // 
            // addzi
            // 
            this.addzi.Location = new System.Drawing.Point(398, 35);
            this.addzi.Name = "addzi";
            this.addzi.Size = new System.Drawing.Size(75, 23);
            this.addzi.TabIndex = 5;
            this.addzi.Text = "添加子节点";
            this.addzi.UseVisualStyleBackColor = true;
            this.addzi.Click += new System.EventHandler(this.addzi_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(309, 76);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(536, 458);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 560);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.addzi);
            this.Controls.Add(this.addzitext);
            this.Controls.Add(this.addgentext);
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
        private System.Windows.Forms.TextBox addgentext;
        private System.Windows.Forms.TextBox addzitext;
        private System.Windows.Forms.Button addzi;
        private System.Windows.Forms.TextBox textBox3;
    }
}

