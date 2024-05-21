
namespace SaveBackup
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
            this.SaveLocalButton = new System.Windows.Forms.Button();
            this.BackupLocalButton = new System.Windows.Forms.Button();
            this.SaveLocalLabel = new System.Windows.Forms.Label();
            this.BackupLocalLabel = new System.Windows.Forms.Label();
            this.SaveBackupButton = new System.Windows.Forms.Button();
            this.SaveBackupTips = new System.Windows.Forms.Label();
            this.FileLocalSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveLocalButton
            // 
            this.SaveLocalButton.Location = new System.Drawing.Point(142, 73);
            this.SaveLocalButton.Name = "SaveLocalButton";
            this.SaveLocalButton.Size = new System.Drawing.Size(75, 23);
            this.SaveLocalButton.TabIndex = 0;
            this.SaveLocalButton.Text = "存檔位置";
            this.SaveLocalButton.UseVisualStyleBackColor = true;
            this.SaveLocalButton.Click += new System.EventHandler(this.SaveLocalButton_Click);
            // 
            // BackupLocalButton
            // 
            this.BackupLocalButton.Location = new System.Drawing.Point(142, 132);
            this.BackupLocalButton.Name = "BackupLocalButton";
            this.BackupLocalButton.Size = new System.Drawing.Size(75, 23);
            this.BackupLocalButton.TabIndex = 1;
            this.BackupLocalButton.Text = "備份位置";
            this.BackupLocalButton.UseVisualStyleBackColor = true;
            this.BackupLocalButton.Click += new System.EventHandler(this.BackupLocalButton_Click);
            // 
            // SaveLocalLabel
            // 
            this.SaveLocalLabel.AutoSize = true;
            this.SaveLocalLabel.Location = new System.Drawing.Point(247, 73);
            this.SaveLocalLabel.Name = "SaveLocalLabel";
            this.SaveLocalLabel.Size = new System.Drawing.Size(33, 12);
            this.SaveLocalLabel.TabIndex = 2;
            this.SaveLocalLabel.Text = "label1";
            // 
            // BackupLocalLabel
            // 
            this.BackupLocalLabel.AutoSize = true;
            this.BackupLocalLabel.Location = new System.Drawing.Point(247, 132);
            this.BackupLocalLabel.Name = "BackupLocalLabel";
            this.BackupLocalLabel.Size = new System.Drawing.Size(33, 12);
            this.BackupLocalLabel.TabIndex = 3;
            this.BackupLocalLabel.Text = "label2";
            // 
            // SaveBackupButton
            // 
            this.SaveBackupButton.Location = new System.Drawing.Point(286, 219);
            this.SaveBackupButton.Name = "SaveBackupButton";
            this.SaveBackupButton.Size = new System.Drawing.Size(75, 23);
            this.SaveBackupButton.TabIndex = 4;
            this.SaveBackupButton.Text = "執行備份";
            this.SaveBackupButton.UseVisualStyleBackColor = true;
            this.SaveBackupButton.Click += new System.EventHandler(this.SaveBackupButton_Click);
            // 
            // SaveBackupTips
            // 
            this.SaveBackupTips.AutoSize = true;
            this.SaveBackupTips.Location = new System.Drawing.Point(455, 219);
            this.SaveBackupTips.Name = "SaveBackupTips";
            this.SaveBackupTips.Size = new System.Drawing.Size(33, 12);
            this.SaveBackupTips.TabIndex = 5;
            this.SaveBackupTips.Text = "label3";
            // 
            // FileLocalSaveButton
            // 
            this.FileLocalSaveButton.Location = new System.Drawing.Point(142, 219);
            this.FileLocalSaveButton.Name = "FileLocalSaveButton";
            this.FileLocalSaveButton.Size = new System.Drawing.Size(75, 23);
            this.FileLocalSaveButton.TabIndex = 6;
            this.FileLocalSaveButton.Text = "button1";
            this.FileLocalSaveButton.UseVisualStyleBackColor = true;
            this.FileLocalSaveButton.Click += new System.EventHandler(this.FileLocalSaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FileLocalSaveButton);
            this.Controls.Add(this.SaveBackupTips);
            this.Controls.Add(this.SaveBackupButton);
            this.Controls.Add(this.BackupLocalLabel);
            this.Controls.Add(this.SaveLocalLabel);
            this.Controls.Add(this.BackupLocalButton);
            this.Controls.Add(this.SaveLocalButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveLocalButton;
        private System.Windows.Forms.Button BackupLocalButton;
        private System.Windows.Forms.Label SaveLocalLabel;
        private System.Windows.Forms.Label BackupLocalLabel;
        private System.Windows.Forms.Button SaveBackupButton;
        private System.Windows.Forms.Label SaveBackupTips;
        private System.Windows.Forms.Button FileLocalSaveButton;
    }
}

