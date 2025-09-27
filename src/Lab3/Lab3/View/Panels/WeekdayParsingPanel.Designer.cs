namespace Lab3.View.Panels
{
    public partial class WeekdayParsingPanel
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
            WeekdayParsingBox = new GroupBox();
            ParseButton = new Button();
            ParsResultLabel = new Label();
            DayOfWeekParsBox = new TextBox();
            labelTypeParsing = new Label();
            WeekdayParsingBox.SuspendLayout();
            SuspendLayout();
            // 
            // WeekdayParsingBox
            // 
            WeekdayParsingBox.Controls.Add(ParseButton);
            WeekdayParsingBox.Controls.Add(ParsResultLabel);
            WeekdayParsingBox.Controls.Add(DayOfWeekParsBox);
            WeekdayParsingBox.Controls.Add(labelTypeParsing);
            WeekdayParsingBox.Location = new Point(3, 3);
            WeekdayParsingBox.Name = "WeekdayParsingBox";
            WeekdayParsingBox.Size = new Size(425, 161);
            WeekdayParsingBox.TabIndex = 0;
            WeekdayParsingBox.TabStop = false;
            WeekdayParsingBox.Text = "Weekday Parsing";
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(249, 48);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(75, 23);
            ParseButton.TabIndex = 3;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParsResultLabel
            // 
            ParsResultLabel.AutoSize = true;
            ParsResultLabel.Location = new Point(26, 92);
            ParsResultLabel.Name = "ParsResultLabel";
            ParsResultLabel.Size = new Size(0, 15);
            ParsResultLabel.TabIndex = 2;
            // 
            // DayOfWeekParsBox
            // 
            DayOfWeekParsBox.Location = new Point(26, 48);
            DayOfWeekParsBox.Name = "DayOfWeekParsBox";
            DayOfWeekParsBox.Size = new Size(217, 23);
            DayOfWeekParsBox.TabIndex = 1;
            // 
            // labelTypeParsing
            // 
            labelTypeParsing.AutoSize = true;
            labelTypeParsing.Location = new Point(26, 30);
            labelTypeParsing.Name = "labelTypeParsing";
            labelTypeParsing.Size = new Size(125, 15);
            labelTypeParsing.TabIndex = 0;
            labelTypeParsing.Text = "Type value for parsing:";
            // 
            // WeekdayParsingPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WeekdayParsingBox);
            Name = "WeekdayParsingPanel";
            Size = new Size(431, 168);
            WeekdayParsingBox.ResumeLayout(false);
            WeekdayParsingBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox WeekdayParsingBox;
        private Button ParseButton;
        private Label ParsResultLabel;
        private TextBox DayOfWeekParsBox;
        private Label labelTypeParsing;
    }
}
