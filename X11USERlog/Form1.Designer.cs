namespace X11USERlog
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_passwd = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_host = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_datadir = new System.Windows.Forms.TextBox();
            this.btn_datadir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用U03_X11用户行为解析器";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_passwd);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.tb_host);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(37, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1.MYSQL数据库连接";
            // 
            // tb_passwd
            // 
            this.tb_passwd.Location = new System.Drawing.Point(122, 104);
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.PasswordChar = '*';
            this.tb_passwd.Size = new System.Drawing.Size(147, 26);
            this.tb_passwd.TabIndex = 1;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(122, 67);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(147, 26);
            this.tb_username.TabIndex = 1;
            // 
            // tb_host
            // 
            this.tb_host.Location = new System.Drawing.Point(122, 33);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(147, 26);
            this.tb_host.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(31, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "密      码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(31, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "用  户  名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(31, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "数据库主机：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_datadir);
            this.groupBox2.Controls.Add(this.btn_datadir);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox2.Location = new System.Drawing.Point(37, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2.加载数据";
            // 
            // tb_datadir
            // 
            this.tb_datadir.Location = new System.Drawing.Point(34, 35);
            this.tb_datadir.Name = "tb_datadir";
            this.tb_datadir.ReadOnly = true;
            this.tb_datadir.Size = new System.Drawing.Size(480, 26);
            this.tb_datadir.TabIndex = 1;
            // 
            // btn_datadir
            // 
            this.btn_datadir.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_datadir.Location = new System.Drawing.Point(534, 33);
            this.btn_datadir.Name = "btn_datadir";
            this.btn_datadir.Size = new System.Drawing.Size(66, 28);
            this.btn_datadir.TabIndex = 0;
            this.btn_datadir.Text = "浏览";
            this.btn_datadir.UseVisualStyleBackColor = true;
            this.btn_datadir.Click += new System.EventHandler(this.btn_datadir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_start);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox3.Location = new System.Drawing.Point(410, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3.开始";
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_start.Location = new System.Drawing.Point(49, 34);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(178, 90);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "开始解析";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(277, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "制作不易，且行且珍惜";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F);
            this.label6.Location = new System.Drawing.Point(244, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "author: qimi ,date:2019.01.05";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F);
            this.label7.Location = new System.Drawing.Point(269, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "Copyright ：2018-2028";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "U03_X11用户行为解析器v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_passwd;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_datadir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tb_datadir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

