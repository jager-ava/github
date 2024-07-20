namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ApeFree.ApeForms.Core.Utils.StateColorSet stateColorSet2 = new ApeFree.ApeForms.Core.Utils.StateColorSet();
            menuStrip2 = new MenuStrip();
            新建ToolStripMenuItem = new ToolStripMenuItem();
            tsmiCreateTcpClient = new ToolStripMenuItem();
            tsmiCreateSerialClient = new ToolStripMenuItem();
            tab = new ApeFree.ApeForms.Core.Controls.SlideTabControl();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { 新建ToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(989, 39);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // 新建ToolStripMenuItem
            // 
            新建ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiCreateTcpClient, tsmiCreateSerialClient });
            新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            新建ToolStripMenuItem.Size = new Size(82, 35);
            新建ToolStripMenuItem.Text = "新建";
            // 
            // tsmiCreateTcpClient
            // 
            tsmiCreateTcpClient.Name = "tsmiCreateTcpClient";
            tsmiCreateTcpClient.Size = new Size(359, 44);
            tsmiCreateTcpClient.Text = "tcp客户端";
            tsmiCreateTcpClient.Click += tsmiCreateTcpClient_Click;
            // 
            // tsmiCreateSerialClient
            // 
            tsmiCreateSerialClient.Name = "tsmiCreateSerialClient";
            tsmiCreateSerialClient.Size = new Size(359, 44);
            tsmiCreateSerialClient.Text = "串口客户端";
            tsmiCreateSerialClient.Click += tsmiCreateSerialClient_Click;
            // 
            // tab
            // 
            tab.CloseAllPagesOptionText = "Close all";
            tab.ClosePageOptionText = "Close";
            tab.Dock = DockStyle.Fill;
            tab.Location = new Point(0, 39);
            tab.Margin = new Padding(8, 7, 8, 7);
            tab.Name = "tab";
            tab.Rate = 1;
            tab.Size = new Size(989, 522);
            stateColorSet2.GotFocusBackColor = Color.FromArgb(0, 122, 204);
            stateColorSet2.GotFocusForeColor = Color.White;
            stateColorSet2.LostFocusBackColor = Color.FromArgb(251, 251, 251);
            stateColorSet2.LostFocusForeColor = Color.FromArgb(30, 30, 30);
            stateColorSet2.MouseDownBackColor = Color.FromArgb(14, 97, 152);
            stateColorSet2.MouseDownForeColor = Color.White;
            stateColorSet2.MouseLeaveBackColor = Color.FromArgb(0, 122, 204);
            stateColorSet2.MouseLeaveForeColor = Color.White;
            stateColorSet2.MouseMoveBackColor = Color.FromArgb(82, 176, 239);
            stateColorSet2.MouseMoveForeColor = Color.White;
            tab.StateColorSet = stateColorSet2;
            tab.TabIndex = 2;
            tab.TitleDock = DockStyle.Top;
            tab.TitleLayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 561);
            Controls.Add(tab);
            Controls.Add(menuStrip2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem 新建ToolStripMenuItem;
        private ToolStripMenuItem tsmiCreateTcpClient;
        private ToolStripMenuItem tsmiCreateSerialClient;
        private ApeFree.ApeForms.Core.Controls.SlideTabControl tab;
    }
}