using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveBackup
{
    public partial class ActiveBackup : Form
    {
        static readonly int maxFolderSize = 90;
        static readonly int minFolderSize = 30;

        Thread th;

        public ActiveBackup()
        {
            InitializeComponent();
        }

        private void TxtFolder_DoubleClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = fbd.SelectedPath;

                    lblProgress.Text = "";
                    progBarFolder.Value = 30;

                    th = new Thread(() => InvokeMethod(fbd.SelectedPath));
                    th.Start();
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
                }
            }
        }

        private void InvokeMethod(string filePath)
        {
            while (true)
            {
                GiveSizeToProgBar(filePath);
                Thread.Sleep(1000);
            }
        }

        private void GiveSizeToProgBar(string filePath)
        {
            long dirSize = GetDirectorySize(filePath);
            if (IsSizeInRange(filePath) == 0)
            {
                lblProgress.Text = dirSize.ToString() + " kb";
                progBarFolder.Value = (int)dirSize;
            }
        }

        private int IsSizeInRange(string filePath)
        {
            int inRange = 0;
            long dirSize = GetDirectorySize(filePath);

            if (dirSize < maxFolderSize && dirSize > minFolderSize)
            {
                inRange = 0;
            }
            else if (dirSize >= maxFolderSize)
            {
                inRange = 1;
            }
            else if (dirSize <= minFolderSize)
            {
                inRange = -1;
            }
            
            return inRange;
        }

        //kbytes
        private long GetDirectorySize(string filePath)
        {
            var files = Directory.EnumerateFiles(filePath);

            var currentSize = (from file in files let fileInfo = new FileInfo(file) select fileInfo.Length).Sum();

            var directories = Directory.EnumerateDirectories(filePath);

            var subDirSize = (from directory in directories select GetDirectorySize(directory)).Sum();

            return (currentSize + subDirSize)/1024;
        }

        private void ActiveBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            th.Abort();
        }
    }
}
