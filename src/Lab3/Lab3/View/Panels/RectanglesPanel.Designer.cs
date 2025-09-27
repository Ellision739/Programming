namespace Lab3.View.Panels
{
    partial class RectanglesPanel
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
            groupBoxRectangles.SuspendLayout();
            SuspendLayout();
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
            groupBoxRectangles.Location = new Point(0, 0);
            groupBoxRectangles.Name = "groupBoxRectangles";
            groupBoxRectangles.Size = new Size(317, 333);
            groupBoxRectangles.TabIndex = 1;
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
            // RectanglesPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxRectangles);
            Name = "RectanglesPanel";
            Size = new Size(320, 337);
            groupBoxRectangles.ResumeLayout(false);
            groupBoxRectangles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRectangles;
        private TextBox IDBox;
        private Label labelID;
        private TextBox CenterBox;
        private Label CenterLabel;
        private Label resultLabel;
        private Button rememberButton;
        private ListBox RectanglesBox;
        private Button findButton;
        private Label ColorLabel;
        private TextBox ColorBox;
        private Label WidthLabel;
        private TextBox WidthBox;
        private Label LenghtLabel;
        private TextBox LengthBox;
    }
}
