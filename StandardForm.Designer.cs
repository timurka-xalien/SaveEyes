﻿namespace WindowsFormsApplication1
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
            this.mnuiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiLongRestNow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiLongRestIn5Minutes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiAllowLongRest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiLongRestSchemes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiLongRestScheme45_15 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiLongRestScheme25_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiLongRestScheme17_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiLongRestSchemeCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuiDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiReenableIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiReenableNever = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiReenableIn2Hours = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiReenableIn1Hour = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuiHiddenMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiSemiHiddenMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiLongRest = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictCat = new System.Windows.Forms.PictureBox();
            this.lblLongRestEndsIn = new System.Windows.Forms.Label();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.mnuiWorkModes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiAllowSitPose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiAllowStayPose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiAllowLayPose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiAllowExtraPose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblPose = new System.Windows.Forms.Label();
            this.mnuTrayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCat)).BeginInit();
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
            this.icoTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.icoTray.BalloonTipText = ".";
            this.icoTray.BalloonTipTitle = "Next long rest in";
            this.icoTray.ContextMenuStrip = this.mnuTrayMenu;
            this.icoTray.Icon = ((System.Drawing.Icon)(resources.GetObject("icoTray.Icon")));
            this.icoTray.Text = "Save Eyes";
            this.icoTray.Visible = true;
            this.icoTray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icoTray_MouseMove);
            // 
            // mnuTrayMenu
            // 
            this.mnuTrayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiReset,
            this.mnuiLongRestNow,
            this.mnuiLongRestIn5Minutes,
            this.mnuiAllowLongRest,
            this.mnuiLongRestSchemes,
            this.toolStripSeparator1,
            this.mnuiDisable,
            this.mnuiReenableIn,
            this.toolStripSeparator2,
            this.mnuiHiddenMode,
            this.mnuiSemiHiddenMode,
            this.toolStripSeparator4,
            this.mnuiWorkModes,
            this.toolStripSeparator3,
            this.mnuiExit});
            this.mnuTrayMenu.Name = "contextMenuStrip1";
            this.mnuTrayMenu.Size = new System.Drawing.Size(228, 342);
            // 
            // mnuiReset
            // 
            this.mnuiReset.Name = "mnuiReset";
            this.mnuiReset.Size = new System.Drawing.Size(227, 26);
            this.mnuiReset.Text = "Long Rest Reset";
            this.mnuiReset.Click += new System.EventHandler(this.mnuiReset_Click);
            // 
            // mnuiLongRestNow
            // 
            this.mnuiLongRestNow.Name = "mnuiLongRestNow";
            this.mnuiLongRestNow.Size = new System.Drawing.Size(227, 26);
            this.mnuiLongRestNow.Text = "Long Rest Now";
            this.mnuiLongRestNow.Click += new System.EventHandler(this.mnuiLongRestNow_Click);
            // 
            // mnuiLongRestIn5Minutes
            // 
            this.mnuiLongRestIn5Minutes.Name = "mnuiLongRestIn5Minutes";
            this.mnuiLongRestIn5Minutes.Size = new System.Drawing.Size(227, 26);
            this.mnuiLongRestIn5Minutes.Text = "Long Rest in 5 Minutes";
            this.mnuiLongRestIn5Minutes.Click += new System.EventHandler(this.mnuiLongRestIn5Minutes_Click);
            // 
            // mnuiAllowLongRest
            // 
            this.mnuiAllowLongRest.Checked = true;
            this.mnuiAllowLongRest.CheckOnClick = true;
            this.mnuiAllowLongRest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuiAllowLongRest.Name = "mnuiAllowLongRest";
            this.mnuiAllowLongRest.Size = new System.Drawing.Size(227, 26);
            this.mnuiAllowLongRest.Text = "Long Rest Allow";
            this.mnuiAllowLongRest.Click += new System.EventHandler(this.mnuiAllowLongRest_Click);
            // 
            // mnuiLongRestSchemes
            // 
            this.mnuiLongRestSchemes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiLongRestScheme45_15,
            this.mnuiLongRestScheme25_5,
            this.mnuiLongRestScheme17_3,
            this.mnuiLongRestSchemeCustom});
            this.mnuiLongRestSchemes.Name = "mnuiLongRestSchemes";
            this.mnuiLongRestSchemes.Size = new System.Drawing.Size(227, 26);
            this.mnuiLongRestSchemes.Text = "Long Rest Schemes";
            // 
            // mnuiLongRestScheme45_15
            // 
            this.mnuiLongRestScheme45_15.Name = "mnuiLongRestScheme45_15";
            this.mnuiLongRestScheme45_15.Size = new System.Drawing.Size(142, 26);
            this.mnuiLongRestScheme45_15.Text = "45/15";
            this.mnuiLongRestScheme45_15.CheckedChanged += new System.EventHandler(this.mnuiLongRestScheme45_15_CheckedChanged);
            this.mnuiLongRestScheme45_15.Click += new System.EventHandler(this.mnuiLongRestScheme_Clicked);
            // 
            // mnuiLongRestScheme25_5
            // 
            this.mnuiLongRestScheme25_5.Name = "mnuiLongRestScheme25_5";
            this.mnuiLongRestScheme25_5.Size = new System.Drawing.Size(142, 26);
            this.mnuiLongRestScheme25_5.Text = "25/5";
            this.mnuiLongRestScheme25_5.CheckedChanged += new System.EventHandler(this.mnuiLongRestScheme25_5_CheckedChanged);
            this.mnuiLongRestScheme25_5.Click += new System.EventHandler(this.mnuiLongRestScheme_Clicked);
            // 
            // mnuiLongRestScheme17_3
            // 
            this.mnuiLongRestScheme17_3.Name = "mnuiLongRestScheme17_3";
            this.mnuiLongRestScheme17_3.Size = new System.Drawing.Size(142, 26);
            this.mnuiLongRestScheme17_3.Text = "17/3";
            this.mnuiLongRestScheme17_3.CheckedChanged += new System.EventHandler(this.mnuiLongRestScheme17_3_CheckedChanged);
            this.mnuiLongRestScheme17_3.Click += new System.EventHandler(this.mnuiLongRestScheme_Clicked);
            // 
            // mnuiLongRestSchemeCustom
            // 
            this.mnuiLongRestSchemeCustom.Checked = true;
            this.mnuiLongRestSchemeCustom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuiLongRestSchemeCustom.Name = "mnuiLongRestSchemeCustom";
            this.mnuiLongRestSchemeCustom.Size = new System.Drawing.Size(142, 26);
            this.mnuiLongRestSchemeCustom.Text = "Custom";
            this.mnuiLongRestSchemeCustom.CheckedChanged += new System.EventHandler(this.mnuiLongRestSchemeCustom_CheckedChanged);
            this.mnuiLongRestSchemeCustom.Click += new System.EventHandler(this.mnuiLongRestScheme_Clicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // mnuiDisable
            // 
            this.mnuiDisable.Name = "mnuiDisable";
            this.mnuiDisable.Size = new System.Drawing.Size(227, 26);
            this.mnuiDisable.Text = "Disable";
            this.mnuiDisable.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // mnuiReenableIn
            // 
            this.mnuiReenableIn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiReenableNever,
            this.mnuiReenableIn2Hours,
            this.mnuiReenableIn1Hour});
            this.mnuiReenableIn.Name = "mnuiReenableIn";
            this.mnuiReenableIn.Size = new System.Drawing.Size(227, 26);
            this.mnuiReenableIn.Text = "Reenable in";
            // 
            // mnuiReenableNever
            // 
            this.mnuiReenableNever.Name = "mnuiReenableNever";
            this.mnuiReenableNever.Size = new System.Drawing.Size(224, 26);
            this.mnuiReenableNever.Text = "Never";
            this.mnuiReenableNever.CheckedChanged += new System.EventHandler(this.mnuiReenableNever_CheckedChanged);
            this.mnuiReenableNever.Click += new System.EventHandler(this.mnuiReenableSwitch_Click);
            // 
            // mnuiReenableIn2Hours
            // 
            this.mnuiReenableIn2Hours.Name = "mnuiReenableIn2Hours";
            this.mnuiReenableIn2Hours.Size = new System.Drawing.Size(224, 26);
            this.mnuiReenableIn2Hours.Text = "2 hours";
            this.mnuiReenableIn2Hours.CheckedChanged += new System.EventHandler(this.mnuiReenableIn2Hours_CheckedChanged);
            this.mnuiReenableIn2Hours.Click += new System.EventHandler(this.mnuiReenableSwitch_Click);
            // 
            // mnuiReenableIn1Hour
            // 
            this.mnuiReenableIn1Hour.Checked = true;
            this.mnuiReenableIn1Hour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuiReenableIn1Hour.Name = "mnuiReenableIn1Hour";
            this.mnuiReenableIn1Hour.Size = new System.Drawing.Size(224, 26);
            this.mnuiReenableIn1Hour.Text = "1 hour";
            this.mnuiReenableIn1Hour.CheckedChanged += new System.EventHandler(this.mnuiReenableIn1Hour_CheckedChanged);
            this.mnuiReenableIn1Hour.Click += new System.EventHandler(this.mnuiReenableSwitch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // mnuiHiddenMode
            // 
            this.mnuiHiddenMode.CheckOnClick = true;
            this.mnuiHiddenMode.Name = "mnuiHiddenMode";
            this.mnuiHiddenMode.Size = new System.Drawing.Size(227, 26);
            this.mnuiHiddenMode.Text = "Hidden Mode";
            this.mnuiHiddenMode.CheckedChanged += new System.EventHandler(this.mnuiHiddenMode_CheckedChanged);
            // 
            // mnuiSemiHiddenMode
            // 
            this.mnuiSemiHiddenMode.CheckOnClick = true;
            this.mnuiSemiHiddenMode.Name = "mnuiSemiHiddenMode";
            this.mnuiSemiHiddenMode.Size = new System.Drawing.Size(227, 26);
            this.mnuiSemiHiddenMode.Text = "Semi-hidden Mode";
            this.mnuiSemiHiddenMode.Click += new System.EventHandler(this.mnuiSemiHiddenMode_Click);
            // 
            // mnuiExit
            // 
            this.mnuiExit.Name = "mnuiExit";
            this.mnuiExit.Size = new System.Drawing.Size(227, 26);
            this.mnuiExit.Text = "Exit";
            this.mnuiExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuiLongRest
            // 
            this.mnuiLongRest.Name = "mnuiLongRest";
            this.mnuiLongRest.Size = new System.Drawing.Size(32, 19);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictCat
            // 
            this.pictCat.Location = new System.Drawing.Point(129, 104);
            this.pictCat.Name = "pictCat";
            this.pictCat.Size = new System.Drawing.Size(130, 125);
            this.pictCat.TabIndex = 1;
            this.pictCat.TabStop = false;
            // 
            // lblLongRestEndsIn
            // 
            this.lblLongRestEndsIn.AutoSize = true;
            this.lblLongRestEndsIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLongRestEndsIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLongRestEndsIn.Location = new System.Drawing.Point(155, 294);
            this.lblLongRestEndsIn.Name = "lblLongRestEndsIn";
            this.lblLongRestEndsIn.Size = new System.Drawing.Size(76, 29);
            this.lblLongRestEndsIn.TabIndex = 2;
            this.lblLongRestEndsIn.Text = "05:00";
            // 
            // timerSeconds
            // 
            this.timerSeconds.Interval = 1000;
            this.timerSeconds.Tick += new System.EventHandler(this.timerSeconds_Tick);
            // 
            // mnuiWorkModes
            // 
            this.mnuiWorkModes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiAllowSitPose,
            this.mnuiAllowStayPose,
            this.mnuiAllowLayPose,
            this.mnuiAllowExtraPose});
            this.mnuiWorkModes.Name = "mnuiWorkModes";
            this.mnuiWorkModes.Size = new System.Drawing.Size(227, 26);
            this.mnuiWorkModes.Text = "Work modes";
            // 
            // mnuiAllowSitPose
            // 
            this.mnuiAllowSitPose.Checked = true;
            this.mnuiAllowSitPose.CheckOnClick = true;
            this.mnuiAllowSitPose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuiAllowSitPose.Name = "mnuiAllowSitPose";
            this.mnuiAllowSitPose.Size = new System.Drawing.Size(224, 26);
            this.mnuiAllowSitPose.Tag = "SI";
            this.mnuiAllowSitPose.Text = "Allow Sit";
            // 
            // mnuiAllowStayPose
            // 
            this.mnuiAllowStayPose.Checked = true;
            this.mnuiAllowStayPose.CheckOnClick = true;
            this.mnuiAllowStayPose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuiAllowStayPose.Name = "mnuiAllowStayPose";
            this.mnuiAllowStayPose.Size = new System.Drawing.Size(224, 26);
            this.mnuiAllowStayPose.Tag = "ST";
            this.mnuiAllowStayPose.Text = "Allow Stay";
            // 
            // mnuiAllowLayPose
            // 
            this.mnuiAllowLayPose.Checked = true;
            this.mnuiAllowLayPose.CheckOnClick = true;
            this.mnuiAllowLayPose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuiAllowLayPose.Name = "mnuiAllowLayPose";
            this.mnuiAllowLayPose.Size = new System.Drawing.Size(224, 26);
            this.mnuiAllowLayPose.Tag = "LA";
            this.mnuiAllowLayPose.Text = "Allow Lay";
            // 
            // mnuiAllowExtraPose
            // 
            this.mnuiAllowExtraPose.Checked = true;
            this.mnuiAllowExtraPose.CheckOnClick = true;
            this.mnuiAllowExtraPose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuiAllowExtraPose.Name = "mnuiAllowExtraPose";
            this.mnuiAllowExtraPose.Size = new System.Drawing.Size(224, 26);
            this.mnuiAllowExtraPose.Tag = "EX";
            this.mnuiAllowExtraPose.Text = "Allow Extra";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(224, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(224, 6);
            // 
            // lblPose
            // 
            this.lblPose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPose.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPose.Location = new System.Drawing.Point(340, 9);
            this.lblPose.Name = "lblPose";
            this.lblPose.Size = new System.Drawing.Size(37, 23);
            this.lblPose.TabIndex = 3;
            this.lblPose.Text = "POSE";
            // 
            // RestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(389, 332);
            this.ControlBox = false;
            this.Controls.Add(this.lblPose);
            this.Controls.Add(this.lblLongRestEndsIn);
            this.Controls.Add(this.pictCat);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLongRest;
        private System.Windows.Forms.NotifyIcon icoTray;
        private System.Windows.Forms.ContextMenuStrip mnuTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuiDisable;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictCat;
        private System.Windows.Forms.ToolStripMenuItem mnuiExit;
        private System.Windows.Forms.ToolStripMenuItem mnuiAllowLongRest;
        private System.Windows.Forms.Label lblLongRestEndsIn;
        private System.Windows.Forms.Timer timerSeconds;
        private System.Windows.Forms.ToolStripMenuItem mnuiLongRestScheme45_15;
        private System.Windows.Forms.ToolStripMenuItem mnuiLongRestScheme25_5;
        private System.Windows.Forms.ToolStripMenuItem mnuiLongRestScheme17_3;
        private System.Windows.Forms.ToolStripMenuItem mnuiLongRest;
        private System.Windows.Forms.ToolStripMenuItem mnuiLongRestSchemes;
        private System.Windows.Forms.ToolStripMenuItem mnuiLongRestSchemeCustom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuiReset;
        private System.Windows.Forms.ToolStripMenuItem mnuiReenableIn;
        private System.Windows.Forms.ToolStripMenuItem mnuiReenableIn1Hour;
        private System.Windows.Forms.ToolStripMenuItem mnuiReenableIn2Hours;
        private System.Windows.Forms.ToolStripMenuItem mnuiReenableNever;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuiHiddenMode;
        private System.Windows.Forms.ToolStripMenuItem mnuiSemiHiddenMode;
        private System.Windows.Forms.ToolStripMenuItem mnuiLongRestNow;
        private System.Windows.Forms.ToolStripMenuItem mnuiLongRestIn5Minutes;
        private System.Windows.Forms.ToolStripMenuItem mnuiWorkModes;
        private System.Windows.Forms.ToolStripMenuItem mnuiAllowSitPose;
        private System.Windows.Forms.ToolStripMenuItem mnuiAllowStayPose;
        private System.Windows.Forms.ToolStripMenuItem mnuiAllowLayPose;
        private System.Windows.Forms.ToolStripMenuItem mnuiAllowExtraPose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label lblPose;
    }
}

