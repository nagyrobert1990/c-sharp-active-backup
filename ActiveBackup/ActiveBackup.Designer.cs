namespace ActiveBackup
{
    partial class ActiveBackup
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
            this.lblSelectedFldr = new System.Windows.Forms.Label();
            this.lblSelectedBackup = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.progBarFolder = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectedFldr
            // 
            this.lblSelectedFldr.AutoSize = true;
            this.lblSelectedFldr.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSelectedFldr.Location = new System.Drawing.Point(12, 34);
            this.lblSelectedFldr.Name = "lblSelectedFldr";
            this.lblSelectedFldr.Size = new System.Drawing.Size(81, 13);
            this.lblSelectedFldr.TabIndex = 0;
            this.lblSelectedFldr.Text = "Selected Folder";
            // 
            // lblSelectedBackup
            // 
            this.lblSelectedBackup.AutoSize = true;
            this.lblSelectedBackup.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSelectedBackup.Location = new System.Drawing.Point(386, 34);
            this.lblSelectedBackup.Name = "lblSelectedBackup";
            this.lblSelectedBackup.Size = new System.Drawing.Size(89, 13);
            this.lblSelectedBackup.TabIndex = 1;
            this.lblSelectedBackup.Text = "Selected Backup";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(15, 51);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(300, 20);
            this.txtFolder.TabIndex = 2;
            this.txtFolder.DoubleClick += new System.EventHandler(this.TxtFolder_DoubleClick);
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(389, 51);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.ReadOnly = true;
            this.txtBackup.Size = new System.Drawing.Size(300, 20);
            this.txtBackup.TabIndex = 3;
            this.txtBackup.DoubleClick += new System.EventHandler(this.TxtBackup_DoubleClick);
            // 
            // progBarFolder
            // 
            this.progBarFolder.Location = new System.Drawing.Point(15, 77);
            this.progBarFolder.Maximum = 90;
            this.progBarFolder.Minimum = 30;
            this.progBarFolder.Name = "progBarFolder";
            this.progBarFolder.Size = new System.Drawing.Size(300, 23);
            this.progBarFolder.TabIndex = 4;
            this.progBarFolder.Value = 30;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(135, 82);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActiveBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 312);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progBarFolder);
            this.Controls.Add(this.txtBackup);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblSelectedBackup);
            this.Controls.Add(this.lblSelectedFldr);
            this.Name = "ActiveBackup";
            this.Text = "ActiveBackup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActiveBackup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedFldr;
        private System.Windows.Forms.Label lblSelectedBackup;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.ProgressBar progBarFolder;
        private System.Windows.Forms.Label lblProgress;
    }
}

