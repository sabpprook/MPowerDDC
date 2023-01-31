namespace MPowerDDC
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Power_SW = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HDMI_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HDMI_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DisplayPort_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayPort_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_GetMonitor = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "MPowerDDC";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Power_SW,
            this.toolStripSeparator1,
            this.HDMI_1,
            this.HDMI_2,
            this.toolStripSeparator2,
            this.DisplayPort_1,
            this.DisplayPort_2,
            this.toolStripSeparator3,
            this.tool_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 154);
            // 
            // Power_SW
            // 
            this.Power_SW.Name = "Power_SW";
            this.Power_SW.Size = new System.Drawing.Size(195, 22);
            this.Power_SW.Text = "PowerOff (Alt+Esc)";
            this.Power_SW.Click += new System.EventHandler(this.Power_SW_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // HDMI_1
            // 
            this.HDMI_1.Name = "HDMI_1";
            this.HDMI_1.Size = new System.Drawing.Size(195, 22);
            this.HDMI_1.Tag = "HDMI_1";
            this.HDMI_1.Text = "HDMI_1 (Alt+1)";
            this.HDMI_1.Click += new System.EventHandler(this.InputSelect_Click);
            // 
            // HDMI_2
            // 
            this.HDMI_2.Name = "HDMI_2";
            this.HDMI_2.Size = new System.Drawing.Size(195, 22);
            this.HDMI_2.Tag = "HDMI_2";
            this.HDMI_2.Text = "HDMI_2 (Alt+2)";
            this.HDMI_2.Click += new System.EventHandler(this.InputSelect_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // DisplayPort_1
            // 
            this.DisplayPort_1.Name = "DisplayPort_1";
            this.DisplayPort_1.Size = new System.Drawing.Size(195, 22);
            this.DisplayPort_1.Tag = "DisplayPort_1";
            this.DisplayPort_1.Text = "DisplayPort_1  (Alt+3)";
            this.DisplayPort_1.Click += new System.EventHandler(this.InputSelect_Click);
            // 
            // DisplayPort_2
            // 
            this.DisplayPort_2.Name = "DisplayPort_2";
            this.DisplayPort_2.Size = new System.Drawing.Size(195, 22);
            this.DisplayPort_2.Tag = "DisplayPort_2";
            this.DisplayPort_2.Text = "DisplayPort_2  (Alt+4)";
            this.DisplayPort_2.Click += new System.EventHandler(this.InputSelect_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // tool_Exit
            // 
            this.tool_Exit.Name = "tool_Exit";
            this.tool_Exit.Size = new System.Drawing.Size(195, 22);
            this.tool_Exit.Text = "Exit";
            this.tool_Exit.Click += new System.EventHandler(this.tool_Exit_Click);
            // 
            // timer_GetMonitor
            // 
            this.timer_GetMonitor.Enabled = true;
            this.timer_GetMonitor.Interval = 3000;
            this.timer_GetMonitor.Tick += new System.EventHandler(this.timer_GetMonitor_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HDMI_1;
        private System.Windows.Forms.ToolStripMenuItem HDMI_2;
        private System.Windows.Forms.ToolStripMenuItem DisplayPort_1;
        private System.Windows.Forms.ToolStripMenuItem DisplayPort_2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tool_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timer_GetMonitor;
        private System.Windows.Forms.ToolStripMenuItem Power_SW;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

