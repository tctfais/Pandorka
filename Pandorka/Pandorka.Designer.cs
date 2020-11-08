namespace Pandorka
{
    partial class Pandorka
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FolderWithGamesLabel = new System.Windows.Forms.Label();
            this.FolderWithGamesTextBox = new System.Windows.Forms.TextBox();
            this.DestinationFolderLabel = new System.Windows.Forms.Label();
            this.DestinationFolderTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FolderWithGamesLabel
            // 
            this.FolderWithGamesLabel.AutoSize = true;
            this.FolderWithGamesLabel.Location = new System.Drawing.Point(12, 9);
            this.FolderWithGamesLabel.Name = "FolderWithGamesLabel";
            this.FolderWithGamesLabel.Size = new System.Drawing.Size(95, 13);
            this.FolderWithGamesLabel.TabIndex = 0;
            this.FolderWithGamesLabel.Text = "Folder with games:";
            // 
            // FolderWithGamesTextBox
            // 
            this.FolderWithGamesTextBox.Location = new System.Drawing.Point(15, 25);
            this.FolderWithGamesTextBox.Name = "FolderWithGamesTextBox";
            this.FolderWithGamesTextBox.Size = new System.Drawing.Size(535, 20);
            this.FolderWithGamesTextBox.TabIndex = 1;
            this.FolderWithGamesTextBox.Click += new System.EventHandler(this.FolderWithGamesTextBox_Click);
            // 
            // DestinationFolderLabel
            // 
            this.DestinationFolderLabel.AutoSize = true;
            this.DestinationFolderLabel.Location = new System.Drawing.Point(12, 48);
            this.DestinationFolderLabel.Name = "DestinationFolderLabel";
            this.DestinationFolderLabel.Size = new System.Drawing.Size(92, 13);
            this.DestinationFolderLabel.TabIndex = 2;
            this.DestinationFolderLabel.Text = "Destination folder:";
            // 
            // DestinationFolderTextBox
            // 
            this.DestinationFolderTextBox.Location = new System.Drawing.Point(15, 64);
            this.DestinationFolderTextBox.Name = "DestinationFolderTextBox";
            this.DestinationFolderTextBox.Size = new System.Drawing.Size(535, 20);
            this.DestinationFolderTextBox.TabIndex = 3;
            this.DestinationFolderTextBox.Click += new System.EventHandler(this.DestinationFolderTextBox_Click);
            // 
            // Pandorka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 263);
            this.Controls.Add(this.DestinationFolderTextBox);
            this.Controls.Add(this.DestinationFolderLabel);
            this.Controls.Add(this.FolderWithGamesTextBox);
            this.Controls.Add(this.FolderWithGamesLabel);
            this.Name = "Pandorka";
            this.Text = "Pandorka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FolderWithGamesLabel;
        private System.Windows.Forms.TextBox FolderWithGamesTextBox;
        private System.Windows.Forms.Label DestinationFolderLabel;
        private System.Windows.Forms.TextBox DestinationFolderTextBox;
    }
}

