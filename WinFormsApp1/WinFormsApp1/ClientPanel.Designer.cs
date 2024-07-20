namespace WinFormsApp1
{
    partial class ClientPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientPanel));
            groupBox1 = new GroupBox();
            propertyGrid1 = new PropertyGrid();
            toolStrip1 = new ToolStrip();
            btnConnect = new ToolStripButton();
            btnDisconnect = new ToolStripButton();
            groupBox2 = new GroupBox();
            tbrecv = new RichTextBox();
            groupBox3 = new GroupBox();
            tbSend = new RichTextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(propertyGrid1);
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 702);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "连接信息";
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.Location = new Point(3, 75);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(286, 624);
            propertyGrid1.TabIndex = 0;
            propertyGrid1.Click += propertyGrid1_Click_2;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnConnect, btnDisconnect });
            toolStrip1.Location = new Point(3, 34);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(286, 41);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnConnect
            // 
            btnConnect.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnConnect.Image = (Image)resources.GetObject("btnConnect.Image");
            btnConnect.ImageTransparentColor = Color.Magenta;
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(66, 35);
            btnConnect.Text = "连接";
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDisconnect.Image = (Image)resources.GetObject("btnDisconnect.Image");
            btnDisconnect.ImageTransparentColor = Color.Magenta;
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(66, 35);
            btnDisconnect.Text = "断开";
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbrecv);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(292, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(735, 578);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "日志";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // tbrecv
            // 
            tbrecv.Dock = DockStyle.Fill;
            tbrecv.Location = new Point(3, 34);
            tbrecv.Name = "tbrecv";
            tbrecv.ReadOnly = true;
            tbrecv.Size = new Size(729, 541);
            tbrecv.TabIndex = 0;
            tbrecv.Text = "";
            tbrecv.TextChanged += tbrecv_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbSend);
            groupBox3.Controls.Add(button1);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(292, 578);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(735, 124);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "输入框";
            // 
            // tbSend
            // 
            tbSend.Dock = DockStyle.Fill;
            tbSend.Location = new Point(3, 34);
            tbSend.Name = "tbSend";
            tbSend.Size = new Size(640, 87);
            tbSend.TabIndex = 0;
            tbSend.Text = "";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(643, 34);
            button1.Name = "button1";
            button1.Size = new Size(89, 87);
            button1.TabIndex = 1;
            button1.Text = "发送";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClientPanel
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "ClientPanel";
            Size = new Size(1027, 702);
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PropertyGrid propertyGrid1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnConnect;
        private ToolStripButton btnDisconnect;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RichTextBox tbSend;
        private RichTextBox tbrecv;
        private Button button1;
    }
}
