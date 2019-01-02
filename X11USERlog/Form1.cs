using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Diagnostics;
using System.IO;
              



namespace X11USERlog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //按下开始按钮
        private void btn_start_Click(object sender, EventArgs e)
        {
            
            //参数检测及解析系统检测
            if (param_check() < 0)
            {
                return;
            }

            //数据库连接检测
            if (mysql_link_check() < 0)
            {
                return;
            }

            //启动解析任务
            //Thread t = new Thread(exec_decode_userlog);//创建了线程还未开启
			//t.Start("start");//用来给函数传递参数，开启线程

            string argvText = String.Format("uyehuser {0} {1}  {2} {3}", tb_host.Text, tb_username.Text, tb_passwd.Text, tb_datadir.Text);

            BackgroundWorker doWorker = new BackgroundWorker();
            doWorker.DoWork += exec_decode_userlog;
            doWorker.WorkerReportsProgress = true;
            doWorker.ProgressChanged += BGWorker_ProgressChanged;
            doWorker.RunWorkerAsync(argvText);


        }


      

        private void btn_datadir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
               tb_datadir.Text = folderBrowserDialog1.SelectedPath;
            }

        }




        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorker bgWorker = sender as BackgroundWorker;
            int type = 0;
            type = e.ProgressPercentage;
            //MessageBox.Show(""+ type);
            if (type > 0)
            {
                com_focus_ctl(1);
            }
            else 
            {
                com_focus_ctl(0);
            }
            
        }


        private void exec_decode_userlog(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgWorker = sender as BackgroundWorker;
            //string argvText = String.Format("uyehuser {0} {1}  {2} {3}",tb_host.Text, tb_username.Text, tb_passwd.Text, tb_datadir.Text);
            string argvText = (string)e.Argument;
            //System.Diagnostics.Process.Start(Application.StartupPath + "test.exe  " + argvText).WaitForExit();
            //MessageBox.Show(Application.StartupPath + "\\test.exe  "+ argvText);

            //参数输入失焦
            //com_focus_ctl(0);
            bgWorker.ReportProgress(0);
            System.Diagnostics.Process.Start(Application.StartupPath + "\\usertool.exe" , argvText).WaitForExit();
            MessageBox.Show("解析成功");
            //参数输入获取焦点
            //com_focus_ctl(1);
            bgWorker.ReportProgress(1);

        }


        //参数控件焦点控制
        private void com_focus_ctl(int type)
        {
            if (type > 0)
            {
                //获取焦点
                tb_host.Enabled = true;
                tb_username.Enabled = true;
                tb_passwd.Enabled = true;
                btn_datadir.Enabled = true;
                btn_start.Enabled = true;
            }
            else
            { 
                //失去焦点
                tb_host.Enabled = false;
                tb_username.Enabled = false;
                tb_passwd.Enabled = false;
                btn_datadir.Enabled = false;
                btn_start.Enabled = false;
            }
        }

        

        //输入参数检测及解析系统检测
        private int param_check()
        {
            //数据库主机检测
            if (tb_host.Text == "")
            {
                MessageBox.Show("请填写主机名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            //数据库用户名检测
            if (tb_username.Text == "")
            {
                MessageBox.Show("请填写用户名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -2;
            }
            //数据库密码检测
            if (tb_passwd.Text == "")
            {
                MessageBox.Show("请填写密码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -3;
            }

            //数据目录检测
            if (tb_datadir.Text == "")
            {
                MessageBox.Show("请选择要解析的数据目录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -4;
            }

            //工具是否存在检测
            if (!File.Exists(Application.StartupPath + "\\usertool.exe"))
            {
                MessageBox.Show("解析系统不存在...", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -5;
            }

            return 0;

        }


        //数据库连接检测实现
        private int mysql_link_check()
        { 
            string connStr = String.Format("server={0};user id={1}; password={2}; port={3}; database=uyehdb; pooling=false; charset=utf8",
            tb_host.Text, tb_username.Text, tb_passwd.Text, 3306);
            MySqlConnection mysqlconn;
            int ret = 0;

            try 
             
            {

                mysqlconn = new MySqlConnection(connStr);

                mysqlconn.Open();
                //MessageBox.Show("连接数据库成功!");
                
                mysqlconn.Close();
             
            }
            catch (MySqlException ex) 
            {
             
                MessageBox.Show( "Error connecting to the server: " + ex.Message , "数据库连接失败", MessageBoxButtons.OK , MessageBoxIcon.Error);
                ret = -1;
            }
             
            return ret;
        }
    }
}


