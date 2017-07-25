using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubTest
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Test program!!!");
            this.tBox.Text += "\r\nWelcome to China!!!\r\n";
        }

        private void timerLocalTime_Tick(object sender, EventArgs e)
        {
            this.tsslLocalTime.Text = DateTime.Now.ToString();
        }
    }
}
