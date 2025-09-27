namespace Lab3.View.Panels
{
    partial class SeasonHandlePanel
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
            SeasonHandleBox = new GroupBox();
            GoButton = new Button();
            ResultSeasonLabel = new Label();
            SeasonsComboBox = new ComboBox();
            ChooseSeasonLabel = new Label();
            SeasonHandleBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonHandleBox
            // 
            SeasonHandleBox.Controls.Add(GoButton);
            SeasonHandleBox.Controls.Add(ResultSeasonLabel);
            SeasonHandleBox.Controls.Add(SeasonsComboBox);
            SeasonHandleBox.Controls.Add(ChooseSeasonLabel);
            SeasonHandleBox.Location = new Point(3, 3);
            SeasonHandleBox.Name = "SeasonHandleBox";
            SeasonHandleBox.Size = new Size(415, 168);
            SeasonHandleBox.TabIndex = 18;
            SeasonHandleBox.TabStop = false;
            SeasonHandleBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(209, 53);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(75, 23);
            GoButton.TabIndex = 3;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // ResultSeasonLabel
            // 
            ResultSeasonLabel.AutoSize = true;
            ResultSeasonLabel.Location = new Point(16, 94);
            ResultSeasonLabel.Name = "ResultSeasonLabel";
            ResultSeasonLabel.Size = new Size(0, 15);
            ResultSeasonLabel.TabIndex = 2;
            // 
            // SeasonsComboBox
            // 
            SeasonsComboBox.FormattingEnabled = true;
            SeasonsComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            SeasonsComboBox.Location = new Point(6, 53);
            SeasonsComboBox.Name = "SeasonsComboBox";
            SeasonsComboBox.Size = new Size(197, 23);
            SeasonsComboBox.TabIndex = 1;
            // 
            // ChooseSeasonLabel
            // 
            ChooseSeasonLabel.AutoSize = true;
            ChooseSeasonLabel.Location = new Point(6, 35);
            ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            ChooseSeasonLabel.Size = new Size(89, 15);
            ChooseSeasonLabel.TabIndex = 0;
            ChooseSeasonLabel.Text = "Choose season:";
            // 
            // SeasonHandlePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonHandleBox);
            Name = "SeasonHandlePanel";
            Size = new Size(422, 176);
            SeasonHandleBox.ResumeLayout(false);
            SeasonHandleBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Label label6;
        private ComboBox timeOfYearBox;
        private Button button2;
        private Label labelTimeOfYear;
        private GroupBox SeasonHandleBox;
        private ComboBox SeasonsComboBox;
        private Label ChooseSeasonLabel;
        private Button GoButton;
        private Label ResultSeasonLabel;
    }
}
