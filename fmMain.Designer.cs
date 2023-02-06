namespace MPowerDDC
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip_Power = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_HDMI_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_HDMI_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_DisplayPort_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_DisplayPort_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip_VGA_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_DVI_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "Monitor Power";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Power,
            this.toolStripSeparator1,
            this.toolStrip_DisplayPort_1,
            this.toolStrip_DisplayPort_2,
            this.toolStripSeparator2,
            this.toolStrip_HDMI_1,
            this.toolStrip_HDMI_2,
            this.toolStripSeparator3,
            this.toolStrip_VGA_1,
            this.toolStrip_DVI_1,
            this.toolStripSeparator4,
            this.toolStrip_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 226);
            // 
            // toolStrip_Power
            // 
            this.toolStrip_Power.Image = global::MPowerDDC.Properties.Resources.Power;
            this.toolStrip_Power.Name = "toolStrip_Power";
            this.toolStrip_Power.ShortcutKeyDisplayString = "(Alt+Esc)";
            this.toolStrip_Power.Size = new System.Drawing.Size(217, 22);
            this.toolStrip_Power.Tag = "PowerSwitch";
            this.toolStrip_Power.Text = "Power Off";
            this.toolStrip_Power.Click += new System.EventHandler(this.toolStrip_Power_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // toolStrip_HDMI_1
            // 
            this.toolStrip_HDMI_1.Image = global::MPowerDDC.Properties.Resources.HDMI;
            this.toolStrip_HDMI_1.Name = "toolStrip_HDMI_1";
            this.toolStrip_HDMI_1.ShortcutKeyDisplayString = "(Shift+F3)";
            this.toolStrip_HDMI_1.Size = new System.Drawing.Size(217, 22);
            this.toolStrip_HDMI_1.Text = "HDMI_1";
            this.toolStrip_HDMI_1.Click += new System.EventHandler(this.toolStrip_Source_Click);
            // 
            // toolStrip_HDMI_2
            // 
            this.toolStrip_HDMI_2.Image = global::MPowerDDC.Properties.Resources.HDMI;
            this.toolStrip_HDMI_2.Name = "toolStrip_HDMI_2";
            this.toolStrip_HDMI_2.ShortcutKeyDisplayString = "(Shift+F4)";
            this.toolStrip_HDMI_2.Size = new System.Drawing.Size(217, 22);
            this.toolStrip_HDMI_2.Text = "HDMI_2";
            this.toolStrip_HDMI_2.Click += new System.EventHandler(this.toolStrip_Source_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // toolStrip_DisplayPort_1
            // 
            this.toolStrip_DisplayPort_1.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_DisplayPort_1.Image")));
            this.toolStrip_DisplayPort_1.Name = "toolStrip_DisplayPort_1";
            this.toolStrip_DisplayPort_1.ShortcutKeyDisplayString = "(Shift+F1)";
            this.toolStrip_DisplayPort_1.Size = new System.Drawing.Size(217, 22);
            this.toolStrip_DisplayPort_1.Text = "DisplayPort_1";
            this.toolStrip_DisplayPort_1.Click += new System.EventHandler(this.toolStrip_Source_Click);
            // 
            // toolStrip_DisplayPort_2
            // 
            this.toolStrip_DisplayPort_2.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_DisplayPort_2.Image")));
            this.toolStrip_DisplayPort_2.Name = "toolStrip_DisplayPort_2";
            this.toolStrip_DisplayPort_2.ShortcutKeyDisplayString = "(Shift+F2)";
            this.toolStrip_DisplayPort_2.Size = new System.Drawing.Size(217, 22);
            this.toolStrip_DisplayPort_2.Text = "DisplayPort_2";
            this.toolStrip_DisplayPort_2.Click += new System.EventHandler(this.toolStrip_Source_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(214, 6);
            // 
            // toolStrip_Exit
            // 
            this.toolStrip_Exit.Name = "toolStrip_Exit";
            this.toolStrip_Exit.Size = new System.Drawing.Size(217, 22);
            this.toolStrip_Exit.Text = "Exit";
            this.toolStrip_Exit.Click += new System.EventHandler(this.toolStrip_Exit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip_VGA_1
            // 
            this.toolStrip_VGA_1.Image = global::MPowerDDC.Properties.Resources.VGA;
            this.toolStrip_VGA_1.Name = "toolStrip_VGA_1";
            this.toolStrip_VGA_1.ShortcutKeyDisplayString = "(Shift+F5)";
            this.toolStrip_VGA_1.Size = new System.Drawing.Size(217, 22);
            this.toolStrip_VGA_1.Text = "VGA_1";
            // 
            // toolStrip_DVI_1
            // 
            this.toolStrip_DVI_1.Image = global::MPowerDDC.Properties.Resources.DVI;
            this.toolStrip_DVI_1.Name = "toolStrip_DVI_1";
            this.toolStrip_DVI_1.ShortcutKeyDisplayString = "(Shift+F6)";
            this.toolStrip_DVI_1.Size = new System.Drawing.Size(217, 22);
            this.toolStrip_DVI_1.Text = "DVI_1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(214, 6);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmMain";
            this.Opacity = 0D;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.Shown += new System.EventHandler(this.fmMain_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Power;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_HDMI_1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_HDMI_2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_DisplayPort_1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_DisplayPort_2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Exit;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_VGA_1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_DVI_1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

