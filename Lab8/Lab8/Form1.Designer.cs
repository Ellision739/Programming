namespace Lab8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SongsBox = new ListBox();
            AddButton = new Button();
            SaveButton = new Button();
            DeleteButton = new Button();
            SongsGroupBox = new GroupBox();
            GenreComboBox = new ComboBox();
            DurationTextBox = new TextBox();
            ArtistNameTextBox = new TextBox();
            SongTitleTextBox = new TextBox();
            GenreLabel = new Label();
            DurationLabel = new Label();
            ArtistNameLabel = new Label();
            SongTitleLabel = new Label();
            InfoLabel = new Label();
            SaveLabel = new Label();
            SongsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SongsBox
            // 
            SongsBox.FormattingEnabled = true;
            SongsBox.ItemHeight = 15;
            SongsBox.Location = new Point(12, 12);
            SongsBox.Name = "SongsBox";
            SongsBox.Size = new Size(304, 439);
            SongsBox.TabIndex = 0;
            SongsBox.SelectedIndexChanged += SongsBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Location = new Point(12, 457);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(50, 50);
            AddButton.TabIndex = 1;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Location = new Point(68, 457);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(50, 50);
            SaveButton.TabIndex = 2;
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += EditingButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(124, 457);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(50, 50);
            DeleteButton.TabIndex = 3;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SongsGroupBox
            // 
            SongsGroupBox.Controls.Add(GenreComboBox);
            SongsGroupBox.Controls.Add(DurationTextBox);
            SongsGroupBox.Controls.Add(ArtistNameTextBox);
            SongsGroupBox.Controls.Add(SongTitleTextBox);
            SongsGroupBox.Controls.Add(GenreLabel);
            SongsGroupBox.Controls.Add(DurationLabel);
            SongsGroupBox.Controls.Add(ArtistNameLabel);
            SongsGroupBox.Controls.Add(SongTitleLabel);
            SongsGroupBox.Location = new Point(322, 12);
            SongsGroupBox.Name = "SongsGroupBox";
            SongsGroupBox.Size = new Size(547, 169);
            SongsGroupBox.TabIndex = 4;
            SongsGroupBox.TabStop = false;
            SongsGroupBox.Text = "Selected Song";
            // 
            // GenreComboBox
            // 
            GenreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Items.AddRange(new object[] { "Synthpop", "Rock", "Pop", "Rap", "Classic", "Indie", "Alternative", "Metal", "Chanson", "HipHop", "Ska", "Trap", "Patriotic" });
            GenreComboBox.Location = new Point(97, 120);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(192, 23);
            GenreComboBox.TabIndex = 7;
            GenreComboBox.SelectedIndexChanged += GenreComboBox_SelectedIndexChanged;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(97, 91);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(192, 23);
            DurationTextBox.TabIndex = 6;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // ArtistNameTextBox
            // 
            ArtistNameTextBox.Location = new Point(97, 62);
            ArtistNameTextBox.Name = "ArtistNameTextBox";
            ArtistNameTextBox.Size = new Size(420, 23);
            ArtistNameTextBox.TabIndex = 5;
            ArtistNameTextBox.TextChanged += ArtistNameTextBox_TextChanged;
            // 
            // SongTitleTextBox
            // 
            SongTitleTextBox.Location = new Point(97, 33);
            SongTitleTextBox.Name = "SongTitleTextBox";
            SongTitleTextBox.Size = new Size(420, 23);
            SongTitleTextBox.TabIndex = 4;
            SongTitleTextBox.TextChanged += SongTitleTextBox_TextChanged;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(50, 123);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(41, 15);
            GenreLabel.TabIndex = 3;
            GenreLabel.Text = "Genre:";
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(35, 94);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(56, 15);
            DurationLabel.TabIndex = 2;
            DurationLabel.Text = "Duration:";
            // 
            // ArtistNameLabel
            // 
            ArtistNameLabel.AutoSize = true;
            ArtistNameLabel.Location = new Point(20, 65);
            ArtistNameLabel.Name = "ArtistNameLabel";
            ArtistNameLabel.Size = new Size(71, 15);
            ArtistNameLabel.TabIndex = 1;
            ArtistNameLabel.Text = "Artist name:";
            // 
            // SongTitleLabel
            // 
            SongTitleLabel.AutoSize = true;
            SongTitleLabel.Location = new Point(31, 36);
            SongTitleLabel.Name = "SongTitleLabel";
            SongTitleLabel.Size = new Size(60, 15);
            SongTitleLabel.TabIndex = 0;
            SongTitleLabel.Text = "Song title:";
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(279, 475);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(590, 15);
            InfoLabel.TabIndex = 5;
            InfoLabel.Text = "Неверное значение: Продолжительность должна быть положительным числом, не превышающим 7200";
            // 
            // SaveLabel
            // 
            SaveLabel.AutoSize = true;
            SaveLabel.Location = new Point(529, 184);
            SaveLabel.Name = "SaveLabel";
            SaveLabel.Size = new Size(0, 15);
            SaveLabel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 520);
            Controls.Add(SaveLabel);
            Controls.Add(InfoLabel);
            Controls.Add(SongsGroupBox);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(AddButton);
            Controls.Add(SongsBox);
            Name = "Form1";
            Text = "Songs Application";
            SongsGroupBox.ResumeLayout(false);
            SongsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox SongsBox;
        private Button AddButton;
        private Button SaveButton;
        private Button DeleteButton;
        private GroupBox SongsGroupBox;
        private ComboBox GenreComboBox;
        private TextBox DurationTextBox;
        private TextBox ArtistNameTextBox;
        private TextBox SongTitleTextBox;
        private Label GenreLabel;
        private Label DurationLabel;
        private Label ArtistNameLabel;
        private Label SongTitleLabel;
        private Label InfoLabel;
        private Label SaveLabel;
    }
}
