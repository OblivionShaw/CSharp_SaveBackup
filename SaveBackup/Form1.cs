using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using SaveBackup.Properties;

namespace SaveBackup
{
    public partial class Form1 : Form
    {
        private string sourcePath;
        private string backupPath;

        private void Form1_Load(object sender, EventArgs e)
        {
            sourcePath = Properties.Settings.Default.SourcePath;
            backupPath = Properties.Settings.Default.BackupPath;
            SaveLocalLabel.Text = sourcePath;
            BackupLocalLabel.Text = backupPath;
        }

        public Form1()
        {
            InitializeComponent();
        }
      

        private void SaveLocalButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    sourcePath = fbd.SelectedPath;
                    SaveLocalLabel.Text = sourcePath;

                    // 保存設定
                    Properties.Settings.Default.SourcePath = sourcePath;
                    Properties.Settings.Default.Save();
                    //Properties.Settings.Default.Reload();
                    //Properties.Settings.Default.Upgrade();
                    //Application.Restart();

                    // 讀取並顯示設定
                    string savedSourcePath = Properties.Settings.Default.SourcePath;
                    Debug.WriteLine("Saved SourcePath: " + savedSourcePath);
                }
            }
        }

        private void BackupLocalButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    backupPath = fbd.SelectedPath;
                    BackupLocalLabel.Text = backupPath;

                    // 保存設定
                    Properties.Settings.Default.BackupPath = backupPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void SaveBackupButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var file in Directory.GetFiles(sourcePath))
                {
                    File.Copy(file, Path.Combine(backupPath, Path.GetFileName(file)), true);
                }
                SaveBackupTips.Text = "備份成功";
            }
            catch (Exception ex)
            {
                SaveBackupTips.Text = "備份失敗: " + ex.Message;
            }

        }

        private void FileLocalSaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SourcePath = sourcePath;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.BackupPath = backupPath;
            Properties.Settings.Default.Save();
        }
    }
}
