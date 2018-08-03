using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;

namespace ActiveBackup
{
    public partial class ActiveBackup : Form
    {
        private static int maxPercentage = 0;
        private static int minPercentage = 0;
        private static string watchedPath = "";
        private static string backupPath = "";
        private static List<string> whiteList = new List<string>();

        Thread discWatcher;

        public ActiveBackup()
        {
            InitializeComponent();
            discWatcher = new Thread(new ThreadStart(WatchForBackup));
        }

        private void TxtFolder_DoubleClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = fbd.SelectedPath;
                    watchedPath = fbd.SelectedPath;
                }
            }
        }

        private void TxtBackup_DoubleClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtBackup.Text = fbd.SelectedPath;
                    backupPath = fbd.SelectedPath;
                    SetAccessRule(backupPath);
                    Environment.SetEnvironmentVariable("BackupPath", backupPath);
                }
            }
        }

        private void TxtWhiteList_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string item in ofd.FileNames)
                    {
                        whiteList.Add(item);
                        txtWhiteList.Text += item;
                        txtWhiteList.Text += "\r\n";
                    }
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            maxPercentage = (int)maxPercent.Value;
            minPercentage = (int)minPercent.Value;
            discWatcher.Start();
        }

        private void WatchForBackup()
        {
            while (true)
            {
                ActualizeProgBar();
                if (IsSizeInRange() == 1)
                {
                    Backup();
                }
                Thread.Sleep(1000);
            }
        }

        private void Backup()
        {
            if ((100 - GetPercentageOfFreeSpace()) >= minPercentage)
            {
                string[] allFiles = Directory.GetFiles(watchedPath, "*.*", SearchOption.AllDirectories);
                foreach (String file in allFiles)
                {
                    if ((IsSizeInRange() != -1) && (!whiteList.Contains(file)))
                    {
                        File.SetAttributes(file, FileAttributes.Normal);
                        string temp = file.Remove(0, 3);
                        Directory.CreateDirectory(Path.GetDirectoryName(Environment.GetEnvironmentVariable("BackupPath") + "\\" + temp));
                        File.Move(file, Environment.GetEnvironmentVariable("BackupPath") + "\\" + temp);
                        ActualizeProgBar();
                    }
                }
            }
        }

        private void SetAccessRule(string directory)
        {
            DirectorySecurity sec = Directory.GetAccessControl(directory);
            FileSystemAccessRule accRule = new FileSystemAccessRule(Environment.UserDomainName + "\\" + Environment.UserName, FileSystemRights.FullControl, AccessControlType.Allow);
            sec.AddAccessRule(accRule);
        }

        private int IsSizeInRange()
        {
            int inRange = 0;
            int occupiedSpace = 100 - GetPercentageOfFreeSpace();

            if (occupiedSpace < maxPercentage && occupiedSpace > minPercentage)
            {
                inRange = 0;
            }
            else if (occupiedSpace >= maxPercentage)
            {
                inRange = 1;
            }
            else if (occupiedSpace <= minPercentage)
            {
                inRange = -1;
            }
            
            return inRange;
        }

        private int GetPercentageOfFreeSpace()
        {
            int percentage = 0;
            DriveInfo driveInfo = new DriveInfo(watchedPath[0].ToString());
            long freeSpace = driveInfo.AvailableFreeSpace;
            long totalSize = driveInfo.TotalSize;
            string tempLong = (100 * freeSpace / totalSize).ToString();
            percentage = Convert.ToInt32(tempLong);
            return percentage;
        }

        private void ActualizeProgBar()
        {
            progBar.BeginInvoke(new Action(() =>
            {
                progBar.Value = 100 - GetPercentageOfFreeSpace();
            }));
            lblProgress.BeginInvoke(new Action(() =>
            {
                lblProgress.Text = (100 - GetPercentageOfFreeSpace()).ToString() + "%";
            }));
            
        }

        private void ActiveBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (discWatcher.IsAlive)
            {
                discWatcher.Abort();
            }
        }

    }
}
