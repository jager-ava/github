namespace Demo.TcpServer1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tsmiStart = new ToolStripMenuItem();
            tsmiClose = new ToolStripMenuItem();
            tbPort = new ToolStripMenuItem();
            tbPort1 = new ToolStripMenuItem();
            tbLog = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiStart, tsmiClose, tbPort });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1030, 39);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiStart
            // 
            tsmiStart.Name = "tsmiStart";
            tsmiStart.Size = new Size(130, 35);
            tsmiStart.Text = "开始监听";
            tsmiStart.Click += tsmiStart_Click;
            // 
            // tsmiClose
            // 
            tsmiClose.Name = "tsmiClose";
            tsmiClose.Size = new Size(130, 35);
            tsmiClose.Text = "停止监听";
            tsmiClose.Click += tsmiClose_Click;
            // 
            // tbPort
            // 
            tbPort.DropDownItems.AddRange(new ToolStripItem[] { tbPort1 });
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(106, 35);
            tbPort.Text = "端口号";
            // 
            // tbPort1
            // 
            tbPort1.Name = "tbPort1";
            tbPort1.Size = new Size(217, 44);
            tbPort1.Text = "60000";
            // 
            // tbLog
            // 
            tbLog.Dock = DockStyle.Fill;
            tbLog.Location = new Point(0, 39);
            tbLog.Name = "tbLog";
            tbLog.Size = new Size(1030, 532);
            tbLog.TabIndex = 1;
            tbLog.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 571);
            Controls.Add(tbLog);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiStart;
        private ToolStripMenuItem tsmiClose;
        private ToolStripMenuItem tbPort;
        private ToolStripMenuItem tbPort1;
        private RichTextBox tbLog;
    }
}
