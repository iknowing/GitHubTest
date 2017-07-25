namespace GitHubTest
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.btnTest = new System.Windows.Forms.Button();
            this.tBox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLogo = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerLocalTime = new System.Windows.Forms.Timer(this.components);
            this.tsslLocalTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(589, 77);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(0, 0);
            this.tBox.Multiline = true;
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(583, 479);
            this.tBox.TabIndex = 1;
            this.tBox.Text = "Hello everyone!!!";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage,
            this.tsslLogo,
            this.tsslLocalTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 482);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(777, 29);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslMessage
            // 
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(104, 24);
            this.tsslMessage.Text = "Hello GitHub";
            // 
            // tsslLogo
            // 
            this.tsslLogo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsslLogo.Name = "tsslLogo";
            this.tsslLogo.Size = new System.Drawing.Size(499, 24);
            this.tsslLogo.Spring = true;
            this.tsslLogo.Text = "HANGZHOU ONTIME I.T. CO.,LTD";
            // 
            // timerLocalTime
            // 
            this.timerLocalTime.Enabled = true;
            this.timerLocalTime.Interval = 1000;
            this.timerLocalTime.Tick += new System.EventHandler(this.timerLocalTime_Tick);
            // 
            // tsslLocalTime
            // 
            this.tsslLocalTime.Name = "tsslLocalTime";
            this.tsslLocalTime.Size = new System.Drawing.Size(159, 24);
            this.tsslLocalTime.Text = "2017-07-25 13:45:41";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 511);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.btnTest);
            this.Name = "main";
            this.Text = "GitHubTest";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
        private System.Windows.Forms.ToolStripStatusLabel tsslLogo;
        private System.Windows.Forms.Timer timerLocalTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslLocalTime;
    }
}

