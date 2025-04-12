namespace Lab3.View.Panels
{
    partial class EnumerationsPanel
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            EnumsList = new ListBox();
            label2 = new Label();
            ValueList = new ListBox();
            label3 = new Label();
            indexValue = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(EnumsList);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ValueList);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(indexValue);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 283);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerations";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 3;
            label1.Text = "Choose enumaration:";
            // 
            // EnumsList
            // 
            EnumsList.FormattingEnabled = true;
            EnumsList.ItemHeight = 15;
            EnumsList.Items.AddRange(new object[] { "Color", "Genre", "Season", "Smartphone Manufacturers", "Student's form of education", "Weekday" });
            EnumsList.Location = new Point(18, 50);
            EnumsList.Name = "EnumsList";
            EnumsList.Size = new Size(141, 199);
            EnumsList.TabIndex = 0;
            EnumsList.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 32);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "Choose value:";
            // 
            // ValueList
            // 
            ValueList.FormattingEnabled = true;
            ValueList.ItemHeight = 15;
            ValueList.Location = new Point(181, 50);
            ValueList.Name = "ValueList";
            ValueList.Size = new Size(137, 199);
            ValueList.TabIndex = 1;
            ValueList.SelectedIndexChanged += ValueList_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 32);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Int value:";
            // 
            // indexValue
            // 
            indexValue.Location = new Point(352, 50);
            indexValue.Name = "indexValue";
            indexValue.Size = new Size(100, 23);
            indexValue.TabIndex = 2;
            // 
            // EnumerationsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "EnumerationsPanel";
            Size = new Size(644, 289);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ListBox EnumsList;
        private Label label2;
        private ListBox ValueList;
        private Label label3;
        private TextBox indexValue;
    }
}
