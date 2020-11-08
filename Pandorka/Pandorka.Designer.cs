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
            this.DoButton = new System.Windows.Forms.Button();
            this.GameTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseGameTypeLabel = new System.Windows.Forms.Label();
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
            this.FolderWithGamesTextBox.Text = "D:\\Games\\!SegaNes\\112GAME";
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
            this.DestinationFolderTextBox.Text = "D:\\Games\\!SegaNes";
            this.DestinationFolderTextBox.Click += new System.EventHandler(this.DestinationFolderTextBox_Click);
            // 
            // DoButton
            // 
            this.DoButton.AutoSize = true;
            this.DoButton.Location = new System.Drawing.Point(168, 226);
            this.DoButton.Name = "DoButton";
            this.DoButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DoButton.Size = new System.Drawing.Size(233, 40);
            this.DoButton.TabIndex = 4;
            this.DoButton.Text = "Do";
            this.DoButton.UseVisualStyleBackColor = true;
            this.DoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameTypeComboBox
            // 
            this.GameTypeComboBox.FormattingEnabled = true;
            this.GameTypeComboBox.Items.AddRange(new object[] {
            "*.zip Final Burn Alpha 0.2.97.42 Modified by Moorechip (fba42) \"FBA_SDL_main\",\"FB" +
                "A_compatible\" (0 type)",
            "*.chd, *.cdi, *.iso, *.elf, *.cue, *.gdi, *.lst, *.bin, *.dat, *.zip, *.7z  libre" +
                "tro_reicast (DC) retro_arch_main\r (18 type)"});
            this.GameTypeComboBox.Location = new System.Drawing.Point(15, 110);
            this.GameTypeComboBox.MaxDropDownItems = 20;
            this.GameTypeComboBox.Name = "GameTypeComboBox";
            this.GameTypeComboBox.Size = new System.Drawing.Size(535, 21);
            this.GameTypeComboBox.TabIndex = 5;
            // 
            // ChooseGameTypeLabel
            // 
            this.ChooseGameTypeLabel.AutoSize = true;
            this.ChooseGameTypeLabel.Location = new System.Drawing.Point(12, 91);
            this.ChooseGameTypeLabel.Name = "ChooseGameTypeLabel";
            this.ChooseGameTypeLabel.Size = new System.Drawing.Size(103, 13);
            this.ChooseGameTypeLabel.TabIndex = 6;
            this.ChooseGameTypeLabel.Text = "Choose games type:";
            // 
            // Pandorka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(566, 278);
            this.Controls.Add(this.ChooseGameTypeLabel);
            this.Controls.Add(this.GameTypeComboBox);
            this.Controls.Add(this.DoButton);
            this.Controls.Add(this.DestinationFolderTextBox);
            this.Controls.Add(this.DestinationFolderLabel);
            this.Controls.Add(this.FolderWithGamesTextBox);
            this.Controls.Add(this.FolderWithGamesLabel);
            this.MaximumSize = new System.Drawing.Size(582, 317);
            this.MinimumSize = new System.Drawing.Size(582, 317);
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
        private System.Windows.Forms.Button DoButton;
        private System.Windows.Forms.ComboBox GameTypeComboBox;
        private System.Windows.Forms.Label ChooseGameTypeLabel;
    }
}

