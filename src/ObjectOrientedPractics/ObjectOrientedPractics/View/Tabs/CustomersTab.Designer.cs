namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            Model.Address address1 = new Model.Address();
            CustomersPanel = new Panel();
            panel1 = new Panel();
            SaveCButton = new Button();
            RemoveCPanel = new Panel();
            RemoveCButton = new Button();
            AddCPanel = new Panel();
            AddCButton = new Button();
            RemovePanel = new Panel();
            RemoveButton = new Button();
            SavePanel = new Panel();
            SaveButton = new Button();
            AddPanel = new Panel();
            AddButton = new Button();
            CustomersLabel = new Label();
            CustomersListBox = new ListBox();
            SelectedCustomerPanel = new Panel();
            InfoCLabel = new Label();
            FullnameTextBox = new TextBox();
            FullNameLabel = new Label();
            IdCTextBox = new TextBox();
            IdCLabel = new Label();
            SelectedCustomerLabel = new Label();
            addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            CustomersPanel.SuspendLayout();
            panel1.SuspendLayout();
            RemoveCPanel.SuspendLayout();
            AddCPanel.SuspendLayout();
            RemovePanel.SuspendLayout();
            SavePanel.SuspendLayout();
            AddPanel.SuspendLayout();
            SelectedCustomerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersPanel
            // 
            CustomersPanel.Controls.Add(panel1);
            CustomersPanel.Controls.Add(RemoveCPanel);
            CustomersPanel.Controls.Add(AddCPanel);
            CustomersPanel.Controls.Add(RemovePanel);
            CustomersPanel.Controls.Add(SavePanel);
            CustomersPanel.Controls.Add(AddPanel);
            CustomersPanel.Controls.Add(CustomersLabel);
            CustomersPanel.Controls.Add(CustomersListBox);
            CustomersPanel.Dock = DockStyle.Left;
            CustomersPanel.Location = new Point(0, 0);
            CustomersPanel.Name = "CustomersPanel";
            CustomersPanel.Size = new Size(350, 550);
            CustomersPanel.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(SaveCButton);
            panel1.Location = new Point(233, 493);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 48);
            panel1.TabIndex = 7;
            // 
            // SaveCButton
            // 
            SaveCButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SaveCButton.Location = new Point(3, 3);
            SaveCButton.Name = "SaveCButton";
            SaveCButton.Size = new Size(108, 41);
            SaveCButton.TabIndex = 2;
            SaveCButton.Text = "Save";
            SaveCButton.UseVisualStyleBackColor = true;
            SaveCButton.Click += SaveCButton_Click;
            // 
            // RemoveCPanel
            // 
            RemoveCPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveCPanel.Controls.Add(RemoveCButton);
            RemoveCPanel.Location = new Point(119, 493);
            RemoveCPanel.Name = "RemoveCPanel";
            RemoveCPanel.Size = new Size(113, 48);
            RemoveCPanel.TabIndex = 10;
            // 
            // RemoveCButton
            // 
            RemoveCButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RemoveCButton.Location = new Point(3, 3);
            RemoveCButton.Name = "RemoveCButton";
            RemoveCButton.Size = new Size(108, 41);
            RemoveCButton.TabIndex = 3;
            RemoveCButton.Text = "Remove";
            RemoveCButton.UseVisualStyleBackColor = true;
            RemoveCButton.Click += RemoveCButton_Click;
            // 
            // AddCPanel
            // 
            AddCPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddCPanel.Controls.Add(AddCButton);
            AddCPanel.Location = new Point(3, 493);
            AddCPanel.Name = "AddCPanel";
            AddCPanel.Size = new Size(114, 48);
            AddCPanel.TabIndex = 10;
            // 
            // AddCButton
            // 
            AddCButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddCButton.Location = new Point(3, 3);
            AddCButton.Name = "AddCButton";
            AddCButton.Size = new Size(108, 41);
            AddCButton.TabIndex = 2;
            AddCButton.Text = "Add";
            AddCButton.UseVisualStyleBackColor = true;
            AddCButton.Click += AddCButton_Click;
            // 
            // RemovePanel
            // 
            RemovePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemovePanel.Controls.Add(RemoveButton);
            RemovePanel.Location = new Point(119, 938);
            RemovePanel.Name = "RemovePanel";
            RemovePanel.Size = new Size(262, 48);
            RemovePanel.TabIndex = 9;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.Location = new Point(3, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(169, 41);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // SavePanel
            // 
            SavePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SavePanel.Controls.Add(SaveButton);
            SavePanel.Location = new Point(235, 938);
            SavePanel.Name = "SavePanel";
            SavePanel.Size = new Size(263, 48);
            SavePanel.TabIndex = 2;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SaveButton.Location = new Point(3, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(171, 41);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // AddPanel
            // 
            AddPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddPanel.Controls.Add(AddButton);
            AddPanel.Location = new Point(3, 938);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(263, 48);
            AddPanel.TabIndex = 6;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(170, 41);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersLabel.Location = new Point(3, 7);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(71, 15);
            CustomersLabel.TabIndex = 0;
            CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(3, 25);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(344, 454);
            CustomersListBox.TabIndex = 1;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomerPanel
            // 
            SelectedCustomerPanel.BackColor = Color.White;
            SelectedCustomerPanel.Controls.Add(addressControl1);
            SelectedCustomerPanel.Controls.Add(InfoCLabel);
            SelectedCustomerPanel.Controls.Add(FullnameTextBox);
            SelectedCustomerPanel.Controls.Add(FullNameLabel);
            SelectedCustomerPanel.Controls.Add(IdCTextBox);
            SelectedCustomerPanel.Controls.Add(IdCLabel);
            SelectedCustomerPanel.Controls.Add(SelectedCustomerLabel);
            SelectedCustomerPanel.Dock = DockStyle.Fill;
            SelectedCustomerPanel.Location = new Point(350, 0);
            SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            SelectedCustomerPanel.Size = new Size(590, 550);
            SelectedCustomerPanel.TabIndex = 7;
            // 
            // InfoCLabel
            // 
            InfoCLabel.AutoSize = true;
            InfoCLabel.Location = new Point(71, 464);
            InfoCLabel.Name = "InfoCLabel";
            InfoCLabel.Size = new Size(0, 15);
            InfoCLabel.TabIndex = 7;
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullnameTextBox.Location = new Point(71, 69);
            FullnameTextBox.Multiline = true;
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(513, 23);
            FullnameTextBox.TabIndex = 6;
            FullnameTextBox.TextChanged += FullnameTextBox_TextChanged;
            // 
            // FullNameLabel
            // 
            FullNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(3, 72);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(62, 15);
            FullNameLabel.TabIndex = 5;
            FullNameLabel.Text = "Full name:";
            // 
            // IdCTextBox
            // 
            IdCTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            IdCTextBox.Location = new Point(71, 37);
            IdCTextBox.Name = "IdCTextBox";
            IdCTextBox.ReadOnly = true;
            IdCTextBox.Size = new Size(120, 23);
            IdCTextBox.TabIndex = 3;
            // 
            // IdCLabel
            // 
            IdCLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IdCLabel.AutoSize = true;
            IdCLabel.Location = new Point(3, 40);
            IdCLabel.Name = "IdCLabel";
            IdCLabel.Size = new Size(21, 15);
            IdCLabel.TabIndex = 1;
            IdCLabel.Text = "ID:";
            // 
            // SelectedCustomerLabel
            // 
            SelectedCustomerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerLabel.AutoSize = true;
            SelectedCustomerLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomerLabel.Location = new Point(3, 7);
            SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            SelectedCustomerLabel.Size = new Size(119, 15);
            SelectedCustomerLabel.TabIndex = 0;
            SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // addressControl1
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 0;
            address1.Street = "";
            addressControl1.Address = address1;
            addressControl1.Location = new Point(6, 98);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(567, 203);
            addressControl1.TabIndex = 8;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedCustomerPanel);
            Controls.Add(CustomersPanel);
            Name = "CustomersTab";
            Size = new Size(940, 550);
            CustomersPanel.ResumeLayout(false);
            CustomersPanel.PerformLayout();
            panel1.ResumeLayout(false);
            RemoveCPanel.ResumeLayout(false);
            AddCPanel.ResumeLayout(false);
            RemovePanel.ResumeLayout(false);
            SavePanel.ResumeLayout(false);
            AddPanel.ResumeLayout(false);
            SelectedCustomerPanel.ResumeLayout(false);
            SelectedCustomerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel CustomersPanel;
        private Panel RemovePanel;
        private Button RemoveButton;
        private Panel SavePanel;
        private Button SaveButton;
        private Panel AddPanel;
        private Button AddButton;
        private Label CustomersLabel;
        private ListBox CustomersListBox;
        private Panel AddCPanel;
        private Button AddCButton;
        private Panel RemoveCPanel;
        private Button RemoveCButton;
        private Panel panel1;
        private Button SaveCButton;
        private Panel SelectedCustomerPanel;
        private TextBox FullnameTextBox;
        private Label FullNameLabel;
        private TextBox IdCTextBox;
        private Label IdCLabel;
        private Label SelectedCustomerLabel;
        private Label InfoCLabel;
        private Controls.AddressControl addressControl1;
    }
}
