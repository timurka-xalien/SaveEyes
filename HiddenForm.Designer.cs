namespace SaveEyes
{
    partial class HiddenForm
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
            this.lblLongRestEndsIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLongRestEndsIn
            // 
            this.lblLongRestEndsIn.AutoSize = true;
            this.lblLongRestEndsIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLongRestEndsIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLongRestEndsIn.Location = new System.Drawing.Point(-1, -1);
            this.lblLongRestEndsIn.Name = "lblLongRestEndsIn";
            this.lblLongRestEndsIn.Size = new System.Drawing.Size(32, 18);
            this.lblLongRestEndsIn.TabIndex = 3;
            this.lblLongRestEndsIn.Text = "500";
            // 
            // HiddenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(100, 19);
            this.ControlBox = false;
            this.Controls.Add(this.lblLongRestEndsIn);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HiddenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLongRestEndsIn;
    }
}