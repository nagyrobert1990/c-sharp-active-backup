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
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblWhiteList = new System.Windows.Forms.Label();
            this.txtWhiteList = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.maxPercent = new System.Windows.Forms.NumericUpDown();
            this.minPercent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.maxPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectedFldr
            // 
            this.lblSelectedFldr.AutoSize = true;
            this.lblSelectedFldr.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSelectedFldr.Location = new System.Drawing.Point(9, 80);
            this.lblSelectedFldr.Name = "lblSelectedFldr";
            this.lblSelectedFldr.Size = new System.Drawing.Size(81, 13);
            this.lblSelectedFldr.TabIndex = 0;
            this.lblSelectedFldr.Text = "Selected Folder";
            // 
            // lblSelectedBackup
            // 
            this.lblSelectedBackup.AutoSize = true;
            this.lblSelectedBackup.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSelectedBackup.Location = new System.Drawing.Point(386, 80);
            this.lblSelectedBackup.Name = "lblSelectedBackup";
            this.lblSelectedBackup.Size = new System.Drawing.Size(89, 13);
            this.lblSelectedBackup.TabIndex = 1;
            this.lblSelectedBackup.Text = "Selected Backup";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(12, 97);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(300, 20);
            this.txtFolder.TabIndex = 2;
            this.txtFolder.DoubleClick += new System.EventHandler(this.TxtFolder_DoubleClick);
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(389, 97);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.ReadOnly = true;
            this.txtBackup.Size = new System.Drawing.Size(300, 20);
            this.txtBackup.TabIndex = 3;
            this.txtBackup.DoubleClick += new System.EventHandler(this.TxtBackup_DoubleClick);
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(12, 12);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(677, 33);
            this.progBar.TabIndex = 4;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(338, 22);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(24, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "0 %";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhiteList
            // 
            this.lblWhiteList.AutoSize = true;
            this.lblWhiteList.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblWhiteList.Location = new System.Drawing.Point(9, 137);
            this.lblWhiteList.Name = "lblWhiteList";
            this.lblWhiteList.Size = new System.Drawing.Size(54, 13);
            this.lblWhiteList.TabIndex = 7;
            this.lblWhiteList.Text = "White List";
            // 
            // txtWhiteList
            // 
            this.txtWhiteList.Location = new System.Drawing.Point(12, 153);
            this.txtWhiteList.Multiline = true;
            this.txtWhiteList.Name = "txtWhiteList";
            this.txtWhiteList.ReadOnly = true;
            this.txtWhiteList.Size = new System.Drawing.Size(300, 110);
            this.txtWhiteList.TabIndex = 8;
            this.txtWhiteList.DoubleClick += new System.EventHandler(this.TxtWhiteList_DoubleClick);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.Location = new System.Drawing.Point(13, 52);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMin.Location = new System.Drawing.Point(386, 153);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(34, 13);
            this.lblMin.TabIndex = 10;
            this.lblMin.Text = "min %";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMax.Location = new System.Drawing.Point(554, 153);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(37, 13);
            this.lblMax.TabIndex = 11;
            this.lblMax.Text = "max %";
            // 
            // maxPercent
            // 
            this.maxPercent.Location = new System.Drawing.Point(557, 170);
            this.maxPercent.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.maxPercent.Name = "maxPercent";
            this.maxPercent.Size = new System.Drawing.Size(90, 20);
            this.maxPercent.TabIndex = 13;
            this.maxPercent.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // minPercent
            // 
            this.minPercent.Location = new System.Drawing.Point(389, 170);
            this.minPercent.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.minPercent.Name = "minPercent";
            this.minPercent.Size = new System.Drawing.Size(90, 20);
            this.minPercent.TabIndex = 12;
            this.minPercent.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ActiveBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 312);
            this.Controls.Add(this.maxPercent);
            this.Controls.Add(this.minPercent);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtWhiteList);
            this.Controls.Add(this.lblWhiteList);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.txtBackup);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblSelectedBackup);
            this.Controls.Add(this.lblSelectedFldr);
            this.Name = "ActiveBackup";
            this.Text = "ActiveBackup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActiveBackup_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.maxPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedFldr;
        private System.Windows.Forms.Label lblSelectedBackup;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblWhiteList;
        private System.Windows.Forms.TextBox txtWhiteList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown maxPercent;
        private System.Windows.Forms.NumericUpDown minPercent;
    }
}

