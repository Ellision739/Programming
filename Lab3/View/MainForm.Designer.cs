namespace Lab3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControlRectangles = new TabControl();
            tabPage1 = new TabPage();
            groupBoxRectangles = new GroupBox();
            IDBox = new TextBox();
            labelID = new Label();
            CenterBox = new TextBox();
            CenterLabel = new Label();
            resultLabel = new Label();
            rememberButton = new Button();
            RectanglesBox = new ListBox();
            findButton = new Button();
            ColorLabel = new Label();
            ColorBox = new TextBox();
            WidthLabel = new Label();
            WidthBox = new TextBox();
            LenghtLabel = new Label();
            LengthBox = new TextBox();
            tabPage2 = new TabPage();
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
            tabPage3 = new TabPage();
            RectanglesBoxPaint = new ListBox();
            DeleteRectangleButton = new Button();
            AddRectangleButton = new Button();
            RectanglesPanel = new Panel();
            HeightBoxPaint = new TextBox();
            WidthBoxPaint = new TextBox();
            YBoxPaint = new TextBox();
            XBoxPaint = new TextBox();
            IDBoxPaint = new TextBox();
            HeightLabelPaint = new Label();
            WidthLabelPaint = new Label();
            YLabelPaint = new Label();
            XLabelPaint = new Label();
            IDLabelPaint = new Label();
            SelectedLabelPaint = new Label();
            RectanglesLabelPaint = new Label();
            ErrorLabel = new Label();
            tabControlRectangles.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBoxRectangles.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBoxMovies.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRectangles
            // 
            tabControlRectangles.Controls.Add(tabPage1);
            tabControlRectangles.Controls.Add(tabPage2);
            tabControlRectangles.Controls.Add(tabPage3);
            tabControlRectangles.Location = new Point(12, 12);
            tabControlRectangles.Name = "tabControlRectangles";
            tabControlRectangles.SelectedIndex = 0;
            tabControlRectangles.Size = new Size(855, 504);
            tabControlRectangles.TabIndex = 0;
            tabControlRectangles.Text = "Rectangles";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBoxRectangles);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(847, 476);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Classes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxRectangles
            // 
            groupBoxRectangles.Controls.Add(IDBox);
            groupBoxRectangles.Controls.Add(labelID);
            groupBoxRectangles.Controls.Add(CenterBox);
            groupBoxRectangles.Controls.Add(CenterLabel);
            groupBoxRectangles.Controls.Add(resultLabel);
            groupBoxRectangles.Controls.Add(rememberButton);
            groupBoxRectangles.Controls.Add(RectanglesBox);
            groupBoxRectangles.Controls.Add(findButton);
            groupBoxRectangles.Controls.Add(ColorLabel);
            groupBoxRectangles.Controls.Add(ColorBox);
            groupBoxRectangles.Controls.Add(WidthLabel);
            groupBoxRectangles.Controls.Add(WidthBox);
            groupBoxRectangles.Controls.Add(LenghtLabel);
            groupBoxRectangles.Controls.Add(LengthBox);
            groupBoxRectangles.Location = new Point(25, 6);
            groupBoxRectangles.Name = "groupBoxRectangles";
            groupBoxRectangles.Size = new Size(816, 474);
            groupBoxRectangles.TabIndex = 0;
            groupBoxRectangles.TabStop = false;
            groupBoxRectangles.Text = "Rectangles";
            // 
            // IDBox
            // 
            IDBox.Location = new Point(175, 224);
            IDBox.Name = "IDBox";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(110, 23);
            IDBox.TabIndex = 13;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(174, 206);
            labelID.Name = "labelID";
            labelID.Size = new Size(21, 15);
            labelID.TabIndex = 12;
            labelID.Text = "ID:";
            // 
            // CenterBox
            // 
            CenterBox.Location = new Point(175, 180);
            CenterBox.Name = "CenterBox";
            CenterBox.ReadOnly = true;
            CenterBox.Size = new Size(110, 23);
            CenterBox.TabIndex = 11;
            // 
            // CenterLabel
            // 
            CenterLabel.AutoSize = true;
            CenterLabel.Location = new Point(174, 162);
            CenterLabel.Name = "CenterLabel";
            CenterLabel.Size = new Size(45, 15);
            CenterLabel.TabIndex = 10;
            CenterLabel.Text = "Center:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(175, 258);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 9;
            // 
            // rememberButton
            // 
            rememberButton.Location = new Point(19, 250);
            rememberButton.Name = "rememberButton";
            rememberButton.Size = new Size(149, 23);
            rememberButton.TabIndex = 8;
            rememberButton.Text = "Remember values";
            rememberButton.UseVisualStyleBackColor = true;
            rememberButton.Click += rememberButton_Click;
            // 
            // RectanglesBox
            // 
            RectanglesBox.FormattingEnabled = true;
            RectanglesBox.ItemHeight = 15;
            RectanglesBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectanglesBox.Location = new Point(19, 30);
            RectanglesBox.Name = "RectanglesBox";
            RectanglesBox.Size = new Size(149, 214);
            RectanglesBox.TabIndex = 7;
            RectanglesBox.SelectedIndexChanged += RectanglesBox_SelectedIndexChanged;
            // 
            // findButton
            // 
            findButton.Location = new Point(19, 279);
            findButton.Name = "findButton";
            findButton.Size = new Size(149, 23);
            findButton.TabIndex = 6;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(174, 118);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(39, 15);
            ColorLabel.TabIndex = 5;
            ColorLabel.Text = "Color:";
            // 
            // ColorBox
            // 
            ColorBox.Location = new Point(174, 136);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new Size(111, 23);
            ColorBox.TabIndex = 4;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(174, 74);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(42, 15);
            WidthLabel.TabIndex = 3;
            WidthLabel.Text = "Width:";
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(174, 92);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(111, 23);
            WidthBox.TabIndex = 2;
            // 
            // LenghtLabel
            // 
            LenghtLabel.AutoSize = true;
            LenghtLabel.Location = new Point(174, 30);
            LenghtLabel.Name = "LenghtLabel";
            LenghtLabel.Size = new Size(47, 15);
            LenghtLabel.TabIndex = 1;
            LenghtLabel.Text = "Lenght:";
            // 
            // LengthBox
            // 
            LengthBox.Location = new Point(174, 48);
            LengthBox.Name = "LengthBox";
            LengthBox.Size = new Size(111, 23);
            LengthBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBoxMovies);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(847, 476);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movie";
            tabPage2.UseVisualStyleBackColor = true;
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
            groupBoxMovies.Location = new Point(6, 6);
            groupBoxMovies.Name = "groupBoxMovies";
            groupBoxMovies.Size = new Size(835, 464);
            groupBoxMovies.TabIndex = 0;
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
            findMovie.Click += findMovie_Click;
            // 
            // rememberValuesMovie
            // 
            rememberValuesMovie.Location = new Point(15, 272);
            rememberValuesMovie.Name = "rememberValuesMovie";
            rememberValuesMovie.Size = new Size(179, 23);
            rememberValuesMovie.TabIndex = 11;
            rememberValuesMovie.Text = "Remember values";
            rememberValuesMovie.UseVisualStyleBackColor = true;
            rememberValuesMovie.Click += rememberValuesMovie_Click;
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
            // tabPage3
            // 
            tabPage3.Controls.Add(ErrorLabel);
            tabPage3.Controls.Add(RectanglesBoxPaint);
            tabPage3.Controls.Add(DeleteRectangleButton);
            tabPage3.Controls.Add(AddRectangleButton);
            tabPage3.Controls.Add(RectanglesPanel);
            tabPage3.Controls.Add(HeightBoxPaint);
            tabPage3.Controls.Add(WidthBoxPaint);
            tabPage3.Controls.Add(YBoxPaint);
            tabPage3.Controls.Add(XBoxPaint);
            tabPage3.Controls.Add(IDBoxPaint);
            tabPage3.Controls.Add(HeightLabelPaint);
            tabPage3.Controls.Add(WidthLabelPaint);
            tabPage3.Controls.Add(YLabelPaint);
            tabPage3.Controls.Add(XLabelPaint);
            tabPage3.Controls.Add(IDLabelPaint);
            tabPage3.Controls.Add(SelectedLabelPaint);
            tabPage3.Controls.Add(RectanglesLabelPaint);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(847, 476);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rectangles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // RectanglesBoxPaint
            // 
            RectanglesBoxPaint.FormattingEnabled = true;
            RectanglesBoxPaint.ItemHeight = 15;
            RectanglesBoxPaint.Location = new Point(16, 34);
            RectanglesBoxPaint.Name = "RectanglesBoxPaint";
            RectanglesBoxPaint.Size = new Size(308, 154);
            RectanglesBoxPaint.TabIndex = 16;
            RectanglesBoxPaint.SelectedIndexChanged += RectanglesBoxPaint_SelectedIndexChanged;
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.FlatAppearance.BorderSize = 0;
            DeleteRectangleButton.FlatStyle = FlatStyle.Flat;
            DeleteRectangleButton.Image = (Image)resources.GetObject("DeleteRectangleButton.Image");
            DeleteRectangleButton.Location = new Point(216, 198);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(43, 36);
            DeleteRectangleButton.TabIndex = 15;
            DeleteRectangleButton.UseVisualStyleBackColor = true;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.FlatAppearance.BorderSize = 0;
            AddRectangleButton.FlatStyle = FlatStyle.Flat;
            AddRectangleButton.Image = (Image)resources.GetObject("AddRectangleButton.Image");
            AddRectangleButton.Location = new Point(60, 198);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(38, 36);
            AddRectangleButton.TabIndex = 14;
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click_1;
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(351, 6);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(490, 464);
            RectanglesPanel.TabIndex = 13;
            // 
            // HeightBoxPaint
            // 
            HeightBoxPaint.Location = new Point(71, 392);
            HeightBoxPaint.Name = "HeightBoxPaint";
            HeightBoxPaint.Size = new Size(100, 23);
            HeightBoxPaint.TabIndex = 12;
            // 
            // WidthBoxPaint
            // 
            WidthBoxPaint.Location = new Point(71, 363);
            WidthBoxPaint.Name = "WidthBoxPaint";
            WidthBoxPaint.Size = new Size(100, 23);
            WidthBoxPaint.TabIndex = 11;
            // 
            // YBoxPaint
            // 
            YBoxPaint.Location = new Point(71, 334);
            YBoxPaint.Name = "YBoxPaint";
            YBoxPaint.Size = new Size(100, 23);
            YBoxPaint.TabIndex = 10;
            // 
            // XBoxPaint
            // 
            XBoxPaint.Location = new Point(71, 305);
            XBoxPaint.Name = "XBoxPaint";
            XBoxPaint.Size = new Size(100, 23);
            XBoxPaint.TabIndex = 9;
            // 
            // IDBoxPaint
            // 
            IDBoxPaint.Location = new Point(71, 276);
            IDBoxPaint.Name = "IDBoxPaint";
            IDBoxPaint.Size = new Size(100, 23);
            IDBoxPaint.TabIndex = 8;
            // 
            // HeightLabelPaint
            // 
            HeightLabelPaint.AutoSize = true;
            HeightLabelPaint.Location = new Point(19, 392);
            HeightLabelPaint.Name = "HeightLabelPaint";
            HeightLabelPaint.Size = new Size(46, 15);
            HeightLabelPaint.TabIndex = 7;
            HeightLabelPaint.Text = "Height:";
            // 
            // WidthLabelPaint
            // 
            WidthLabelPaint.AutoSize = true;
            WidthLabelPaint.Location = new Point(23, 366);
            WidthLabelPaint.Name = "WidthLabelPaint";
            WidthLabelPaint.Size = new Size(42, 15);
            WidthLabelPaint.TabIndex = 6;
            WidthLabelPaint.Text = "Width:";
            // 
            // YLabelPaint
            // 
            YLabelPaint.AutoSize = true;
            YLabelPaint.Location = new Point(48, 337);
            YLabelPaint.Name = "YLabelPaint";
            YLabelPaint.Size = new Size(17, 15);
            YLabelPaint.TabIndex = 5;
            YLabelPaint.Text = "Y:";
            // 
            // XLabelPaint
            // 
            XLabelPaint.AutoSize = true;
            XLabelPaint.Location = new Point(48, 309);
            XLabelPaint.Name = "XLabelPaint";
            XLabelPaint.Size = new Size(17, 15);
            XLabelPaint.TabIndex = 4;
            XLabelPaint.Text = "X:";
            // 
            // IDLabelPaint
            // 
            IDLabelPaint.AutoSize = true;
            IDLabelPaint.Location = new Point(45, 279);
            IDLabelPaint.Name = "IDLabelPaint";
            IDLabelPaint.Size = new Size(20, 15);
            IDLabelPaint.TabIndex = 3;
            IDLabelPaint.Text = "Id:";
            // 
            // SelectedLabelPaint
            // 
            SelectedLabelPaint.AutoSize = true;
            SelectedLabelPaint.Location = new Point(16, 253);
            SelectedLabelPaint.Name = "SelectedLabelPaint";
            SelectedLabelPaint.Size = new Size(109, 15);
            SelectedLabelPaint.TabIndex = 2;
            SelectedLabelPaint.Text = "Selected Rectangle:";
            // 
            // RectanglesLabelPaint
            // 
            RectanglesLabelPaint.AutoSize = true;
            RectanglesLabelPaint.Location = new Point(16, 16);
            RectanglesLabelPaint.Name = "RectanglesLabelPaint";
            RectanglesLabelPaint.Size = new Size(67, 15);
            RectanglesLabelPaint.TabIndex = 1;
            RectanglesLabelPaint.Text = "Rectangles:";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(225, 246);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 15);
            ErrorLabel.TabIndex = 17;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 528);
            Controls.Add(tabControlRectangles);
            Name = "MainForm";
            Text = "Programming Demo";
            tabControlRectangles.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBoxRectangles.ResumeLayout(false);
            groupBoxRectangles.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBoxMovies.ResumeLayout(false);
            groupBoxMovies.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlRectangles;
        private TabPage tabPage1;
        private GroupBox groupBoxRectangles;
        private ListBox RectanglesBox;
        private Button findButton;
        private Label ColorLabel;
        private TextBox ColorBox;
        private Label WidthLabel;
        private TextBox WidthBox;
        private Label LenghtLabel;
        private TextBox LengthBox;
        private Label resultLabel;
        private Button rememberButton;
        private TabPage tabPage2;
        private GroupBox groupBoxMovies;
        private ListBox MoviesBox;
        private Label NameLabel;
        private TextBox ratingBox;
        private TextBox genreBox;
        private TextBox yearBox;
        private TextBox durationBox;
        private TextBox nameBoxMovies;
        private Label DurationLabel;
        private Label RatingLabel;
        private Label GenreLabel;
        private Label YearLabel;
        private Button findMovie;
        private Button rememberValuesMovie;
        private Label resultLabelMovies;
        private TextBox CenterBox;
        private Label CenterLabel;
        private TextBox IDBox;
        private Label labelID;
        private TabPage tabPage3;
        private Label SelectedLabelPaint;
        private Label RectanglesLabelPaint;
        private Label IDLabelPaint;
        private Label WidthLabelPaint;
        private Label YLabelPaint;
        private Label XLabelPaint;
        private TextBox IDBoxPaint;
        private Label HeightLabelPaint;
        private TextBox XBoxPaint;
        private TextBox YBoxPaint;
        private TextBox HeightBoxPaint;
        private TextBox WidthBoxPaint;
        private Panel RectanglesPanel;
        private Button DeleteRectangleButton;
        private Button AddRectangleButton;
        private ListBox RectanglesBoxPaint;
        private Label ErrorLabel;
    }
}
