namespace ObjectOrientedPractics.View.Forms
{
    partial class AddDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PercentDiscountLabel = new Label();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            OKButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PercentDiscountLabel.Location = new Point(12, 31);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(114, 15);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(12, 61);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "Electronics", "Clothing", "Food", "Books", "Toys", "Furniture", "Sports" });
            CategoryComboBox.Location = new Point(76, 58);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(261, 23);
            CategoryComboBox.TabIndex = 2;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(153, 112);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(100, 40);
            OKButton.TabIndex = 3;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(259, 112);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(100, 40);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 164);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(PercentDiscountLabel);
            Name = "AddDiscountForm";
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PercentDiscountLabel;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private Button OKButton;
        private Button CancelButton;
    }
}