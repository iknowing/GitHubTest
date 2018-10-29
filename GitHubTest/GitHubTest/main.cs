using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubTest
{
    public partial class main : Form
    {
        private delegate void ReadDataCallBack(Form1 frm);
        private ReadDataCallBack readDataCallBack;

        public main()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This is a Test program!!!");
            this.tBox.Text += "\r\nWelcome to China!!!\r\n";
            this.tBox.Text += DateTime.Now.ToString();

            Form1 frmShowWarning = new Form1();//Form1为要弹出的窗体（提示框），  
            Invoke(readDataCallBack, frmShowWarning);

        }

        private void timerLocalTime_Tick(object sender, EventArgs e)
        {
            tsslLocalTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void main_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
                this.ShowInTaskbar = false;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;
            //    //使关闭时窗口向右下角缩小的效果
            //    this.WindowState = FormWindowState.Minimized;
            //}
            DialogResult result = MessageBox.Show("是否确认退出程序？\r\n点击否最小化至托盘", "退出", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
                //使关闭时窗口向右下角缩小的效果
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            readDataCallBack = new ReadDataCallBack(ShowForm);
        }
        public void ShowForm(Form1 frm)
        {
            Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - frm.Width, Screen.PrimaryScreen.WorkingArea.Height);
            frm.PointToScreen(p);
            frm.Location = p;
            frm.Show();
            for (int i = 0; i <= frm.Height; i++)
            {
                frm.Location = new Point(p.X, p.Y - i);
                Thread.Sleep(10);//将线程沉睡时间调的越小升起的越快  
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Form1 frmShowWarning = new Form1();//Form1为要弹出的窗体（提示框），  
            //Invoke(readDataCallBack, frmShowWarning);

            ThreadStart threadStart = new ThreadStart(Showfrm);
            Thread thread = new Thread(threadStart);
            thread.IsBackground = true;
            thread.Start();
        }
        public void Showfrm()
        {
            //Form1 frm = new Form1();
            //Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - frm.Width, Screen.PrimaryScreen.WorkingArea.Height);
            //frm.PointToScreen(p);
            //frm.Location = p;
            //frm.Show();
            //for (int i = 0; i <= frm.Height; i++)
            //{
            //    frm.Location = new Point(p.X, p.Y - i);
            //    Thread.Sleep(5);//将线程沉睡时间调的越小升起的越快  
            //}
            ////while(true)
            //{
            //    Thread.Sleep(5);
            //}
            MethodInvoker mi = new MethodInvoker(this.Showfrm1);
            this.BeginInvoke(mi);
        }
        public void Showfrm1()
        {
            Form1 frm = new Form1();
            Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - frm.Width, Screen.PrimaryScreen.WorkingArea.Height);
            frm.PointToScreen(p);
            frm.Location = p;
            frm.Show();
            for (int i = 0; i <= frm.Height; i++)
            {
                frm.Location = new Point(p.X, p.Y - i);
                Thread.Sleep(5);//将线程沉睡时间调的越小升起的越快  
            }
            //while(true)
            {
                Thread.Sleep(5);
            }
        }
        }
    }
