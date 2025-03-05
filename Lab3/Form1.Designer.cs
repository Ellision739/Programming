namespace Lab3
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            resultLabel = new Label();
            rememberButton = new Button();
            RectanglesBox = new ListBox();
            findButton = new Button();
            label3 = new Label();
            ColorBox = new TextBox();
            label2 = new Label();
            WidthBox = new TextBox();
            label1 = new Label();
            LengthBox = new TextBox();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            resultLabelMovies = new Label();
            findMovie = new Button();
            rememberValuesMovie = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ratingBox = new TextBox();
            genreBox = new TextBox();
            yearBox = new TextBox();
            durationBox = new TextBox();
            nameBoxMovies = new TextBox();
            MoviesBox = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Classes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resultLabel);
            groupBox1.Controls.Add(rememberButton);
            groupBox1.Controls.Add(RectanglesBox);
            groupBox1.Controls.Add(findButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ColorBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(WidthBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LengthBox);
            groupBox1.Location = new Point(25, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(716, 386);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rectangles";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(175, 162);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 9;
            // 
            // rememberButton
            // 
            rememberButton.Location = new Point(174, 192);
            rememberButton.Name = "rememberButton";
            rememberButton.Size = new Size(111, 23);
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
            findButton.Location = new Point(174, 221);
            findButton.Name = "findButton";
            findButton.Size = new Size(111, 23);
            findButton.TabIndex = 6;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 118);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Color:";
            // 
            // ColorBox
            // 
            ColorBox.Location = new Point(174, 136);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new Size(111, 23);
            ColorBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 74);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Width:";
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(174, 92);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(111, 23);
            WidthBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Lenght:";
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
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movie";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(resultLabelMovies);
            groupBox2.Controls.Add(findMovie);
            groupBox2.Controls.Add(rememberValuesMovie);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(ratingBox);
            groupBox2.Controls.Add(genreBox);
            groupBox2.Controls.Add(yearBox);
            groupBox2.Controls.Add(durationBox);
            groupBox2.Controls.Add(nameBoxMovies);
            groupBox2.Controls.Add(MoviesBox);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(756, 386);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Movies";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(200, 208);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 10;
            label8.Text = "Rating:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(200, 163);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 9;
            label7.Text = "Genre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 119);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 8;
            label6.Text = "Year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 72);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 7;
            label5.Text = "Duration Min:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 22);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Name:";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private ListBox RectanglesBox;
        private Button findButton;
        private Label label3;
        private TextBox ColorBox;
        private Label label2;
        private TextBox WidthBox;
        private Label label1;
        private TextBox LengthBox;
        private Label resultLabel;
        private Button rememberButton;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private ListBox MoviesBox;
        private Label label4;
        private TextBox ratingBox;
        private TextBox genreBox;
        private TextBox yearBox;
        private TextBox durationBox;
        private TextBox nameBoxMovies;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button findMovie;
        private Button rememberValuesMovie;
        private Label resultLabelMovies;
    }
}
