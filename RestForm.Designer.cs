namespace WindowsFormsApplication1
{
    partial class RestForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestForm));
            this.lblLongRest = new System.Windows.Forms.Label();
            this.icoTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuiDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiAllowLongRest = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLongRestEndsIn = new System.Windows.Forms.Label();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.mnuTrayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLongRest
            // 
            this.lblLongRest.AutoSize = true;
            this.lblLongRest.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLongRest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLongRest.Location = new System.Drawing.Point(142, 21);
            this.lblLongRest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLongRest.Name = "lblLongRest";
            this.lblLongRest.Size = new System.Drawing.Size(104, 49);
            this.lblLongRest.TabIndex = 0;
            this.lblLongRest.Text = "REST";
            this.lblLongRest.Visible = false;
            // 
            // icoTray
            // 
            this.icoTray.ContextMenuStrip = this.mnuTrayMenu;
            this.icoTray.Icon = ((System.Drawing.Icon)(resources.GetObject("icoTray.Icon")));
            this.icoTray.Text = "Save Eyes";
            this.icoTray.Visible = true;
            // 
            // mnuTrayMenu
            // 
            this.mnuTrayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiDisable,
            this.mnuiExit,
            this.mnuiAllowLongRest});
            this.mnuTrayMenu.Name = "contextMenuStrip1";
            this.mnuTrayMenu.Size = new System.Drawing.Size(183, 82);
            // 
            // mnuiDisable
            // 
            this.mnuiDisable.Name = "mnuiDisable";
            this.mnuiDisable.Size = new System.Drawing.Size(182, 26);
            this.mnuiDisable.Text = "Disable";
            this.mnuiDisable.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // mnuiExit
            // 
            this.mnuiExit.Name = "mnuiExit";
            this.mnuiExit.Size = new System.Drawing.Size(182, 26);
            this.mnuiExit.Text = "Exit";
            this.mnuiExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuiAllowLongRest
            // 
            this.mnuiAllowLongRest.Checked = true;
            this.mnuiAllowLongRest.CheckOnClick = true;
            this.mnuiAllowLongRest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuiAllowLongRest.Name = "mnuiAllowLongRest";
            this.mnuiAllowLongRest.Size = new System.Drawing.Size(182, 26);
            this.mnuiAllowLongRest.Text = "Allow long rest ";
            this.mnuiAllowLongRest.Click += new System.EventHandler(this.mnuiAllowLongRest_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(129, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 125);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblRestEndsIn
            // 
            this.lblLongRestEndsIn.AutoSize = true;
            this.lblLongRestEndsIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLongRestEndsIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLongRestEndsIn.Location = new System.Drawing.Point(155, 294);
            this.lblLongRestEndsIn.Name = "lblRestEndsIn";
            this.lblLongRestEndsIn.Size = new System.Drawing.Size(76, 29);
            this.lblLongRestEndsIn.TabIndex = 2;
            this.lblLongRestEndsIn.Text = "05:00";
            // 
            // timerSeconds
            // 
            this.timerSeconds.Interval = 1000;
            this.timerSeconds.Tick += new System.EventHandler(this.timerSeconds_Tick);
            // 
            // RestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(389, 332);
            this.ControlBox = false;
            this.Controls.Add(this.lblLongRestEndsIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLongRest);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RestForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.mnuTrayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLongRest;
        private System.Windows.Forms.NotifyIcon icoTray;
        private System.Windows.Forms.ContextMenuStrip mnuTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuiDisable;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuiExit;
        private System.Windows.Forms.ToolStripMenuItem mnuiAllowLongRest;
        private System.Windows.Forms.Label lblLongRestEndsIn;
        private System.Windows.Forms.Timer timerSeconds;
    }
}

