namespace Lab3.View.Panels
{
    partial class MoviePanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxMovies = new GroupBox();
            resultLabelMovies = new Label();
            findMovie = new Button();
            rememberValuesMovie = new Button();
            RatingLabel = new Label();
            GenreLabel = new Label();
            YearLabel = new Label();
            DurationLabel = new Label();
            NameLabel = new Label();
            ratingBox = new TextBox();
            genreBox = new TextBox();
            yearBox = new TextBox();
            durationBox = new TextBox();
            nameBoxMovies = new TextBox();
            MoviesBox = new ListBox();
            groupBoxMovies.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMovies
            // 
            groupBoxMovies.Controls.Add(resultLabelMovies);
            groupBoxMovies.Controls.Add(findMovie);
            groupBoxMovies.Controls.Add(rememberValuesMovie);
            groupBoxMovies.Controls.Add(RatingLabel);
            groupBoxMovies.Controls.Add(GenreLabel);
            groupBoxMovies.Controls.Add(YearLabel);
            groupBoxMovies.Controls.Add(DurationLabel);
            groupBoxMovies.Controls.Add(NameLabel);
            groupBoxMovies.Controls.Add(ratingBox);
            groupBoxMovies.Controls.Add(genreBox);
            groupBoxMovies.Controls.Add(yearBox);
            groupBoxMovies.Controls.Add(durationBox);
            groupBoxMovies.Controls.Add(nameBoxMovies);
            groupBoxMovies.Controls.Add(MoviesBox);
            groupBoxMovies.Location = new Point(3, 3);
            groupBoxMovies.Name = "groupBoxMovies";
            groupBoxMovies.Size = new Size(324, 362);
            groupBoxMovies.TabIndex = 1;
            groupBoxMovies.TabStop = false;
            groupBoxMovies.Text = "Movies";
            // 
            // resultLabelMovies
            // 
            resultLabelMovies.AutoSize = true;
            resultLabelMovies.Location = new Point(217, 276);
            resultLabelMovies.Name = "resultLabelMovies";
            resultLabelMovies.Size = new Size(0, 15);
            resultLabelMovies.TabIndex = 13;
            // 
            // findMovie
            // 
            findMovie.Location = new Point(15, 301);
            findMovie.Name = "findMovie";
            findMovie.Size = new Size(179, 23);
            findMovie.TabIndex = 12;
            findMovie.Text = "Find";
            findMovie.UseVisualStyleBackColor = true;
            findMovie.Click += findMovie_Click_1;
            // 
            // rememberValuesMovie
            // 
            rememberValuesMovie.Location = new Point(15, 272);
            rememberValuesMovie.Name = "rememberValuesMovie";
            rememberValuesMovie.Size = new Size(179, 23);
            rememberValuesMovie.TabIndex = 11;
            rememberValuesMovie.Text = "Remember values";
            rememberValuesMovie.UseVisualStyleBackColor = true;
            rememberValuesMovie.Click += rememberValuesMovie_Click_1;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(200, 208);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(44, 15);
            RatingLabel.TabIndex = 10;
            RatingLabel.Text = "Rating:";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(200, 163);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(41, 15);
            GenreLabel.TabIndex = 9;
            GenreLabel.Text = "Genre:";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(200, 119);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(32, 15);
            YearLabel.TabIndex = 8;
            YearLabel.Text = "Year:";
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(200, 72);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(80, 15);
            DurationLabel.TabIndex = 7;
            DurationLabel.Text = "Duration Min:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(200, 22);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name:";
            // 
            // ratingBox
            // 
            ratingBox.Location = new Point(200, 226);
            ratingBox.Name = "ratingBox";
            ratingBox.Size = new Size(100, 23);
            ratingBox.TabIndex = 5;
            // 
            // genreBox
            // 
            genreBox.Location = new Point(200, 180);
            genreBox.Name = "genreBox";
            genreBox.Size = new Size(100, 23);
            genreBox.TabIndex = 4;
            // 
            // yearBox
            // 
            yearBox.Location = new Point(200, 137);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(100, 23);
            yearBox.TabIndex = 3;
            // 
            // durationBox
            // 
            durationBox.Location = new Point(200, 90);
            durationBox.Name = "durationBox";
            durationBox.Size = new Size(100, 23);
            durationBox.TabIndex = 2;
            // 
            // nameBoxMovies
            // 
            nameBoxMovies.Location = new Point(200, 43);
            nameBoxMovies.Name = "nameBoxMovies";
            nameBoxMovies.Size = new Size(100, 23);
            nameBoxMovies.TabIndex = 1;
            // 
            // MoviesBox
            // 
            MoviesBox.FormattingEnabled = true;
            MoviesBox.ItemHeight = 15;
            MoviesBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            MoviesBox.Location = new Point(15, 22);
            MoviesBox.Name = "MoviesBox";
            MoviesBox.Size = new Size(179, 244);
            MoviesBox.TabIndex = 0;
            MoviesBox.SelectedIndexChanged += MoviesBox_SelectedIndexChanged;
            // 
            // MoviePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxMovies);
            Name = "MoviePanel";
            Size = new Size(331, 370);
            groupBoxMovies.ResumeLayout(false);
            groupBoxMovies.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMovies;
        private Label resultLabelMovies;
        private Button findMovie;
        private Button rememberValuesMovie;
        private Label RatingLabel;
        private Label GenreLabel;
        private Label YearLabel;
        private Label DurationLabel;
        private Label NameLabel;
        private TextBox ratingBox;
        private TextBox genreBox;
        private TextBox yearBox;
        private TextBox durationBox;
        private TextBox nameBoxMovies;
        private ListBox MoviesBox;
    }
}
