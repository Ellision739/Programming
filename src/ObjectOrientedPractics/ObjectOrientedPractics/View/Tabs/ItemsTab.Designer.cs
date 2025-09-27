namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsLabel = new Label();
            ItemsListBox = new ListBox();
            AddButton = new Button();
            RemoveButton = new Button();
            SelectedItemPanel = new Panel();
            InfoLabel = new Label();
            DescriptionTextBox = new TextBox();
            DescriptionLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            CostLabel = new Label();
            IdLabel = new Label();
            SelectedItemLabel = new Label();
            ItemsPanel = new Panel();
            RemovePanel = new Panel();
            SavePanel = new Panel();
            SaveButton = new Button();
            AddPanel = new Panel();
            SelectedItemPanel.SuspendLayout();
            ItemsPanel.SuspendLayout();
            RemovePanel.SuspendLayout();
            SavePanel.SuspendLayout();
            AddPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsLabel.Location = new Point(3, 7);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(40, 15);
            ItemsLabel.TabIndex = 0;
            ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 25);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(343, 454);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(107, 41);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.Location = new Point(3, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(107, 41);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // SelectedItemPanel
            // 
            SelectedItemPanel.BackColor = Color.White;
            SelectedItemPanel.Controls.Add(InfoLabel);
            SelectedItemPanel.Controls.Add(DescriptionTextBox);
            SelectedItemPanel.Controls.Add(DescriptionLabel);
            SelectedItemPanel.Controls.Add(NameTextBox);
            SelectedItemPanel.Controls.Add(NameLabel);
            SelectedItemPanel.Controls.Add(CostTextBox);
            SelectedItemPanel.Controls.Add(IdTextBox);
            SelectedItemPanel.Controls.Add(CostLabel);
            SelectedItemPanel.Controls.Add(IdLabel);
            SelectedItemPanel.Controls.Add(SelectedItemLabel);
            SelectedItemPanel.Dock = DockStyle.Right;
            SelectedItemPanel.Location = new Point(358, 0);
            SelectedItemPanel.Name = "SelectedItemPanel";
            SelectedItemPanel.Size = new Size(514, 542);
            SelectedItemPanel.TabIndex = 4;
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(45, 464);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(0, 15);
            InfoLabel.TabIndex = 9;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(3, 247);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(505, 154);
            DescriptionTextBox.TabIndex = 8;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(3, 229);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 7;
            DescriptionLabel.Text = "Description:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(3, 131);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(505, 84);
            NameTextBox.TabIndex = 6;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(3, 113);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Name:";
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            CostTextBox.Location = new Point(48, 69);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(120, 23);
            CostTextBox.TabIndex = 4;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            IdTextBox.Location = new Point(48, 37);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(120, 23);
            IdTextBox.TabIndex = 3;
            // 
            // CostLabel
            // 
            CostLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(3, 72);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 2;
            CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            IdLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(3, 40);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID:";
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedItemLabel.Location = new Point(3, 7);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(88, 15);
            SelectedItemLabel.TabIndex = 0;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // ItemsPanel
            // 
            ItemsPanel.Controls.Add(RemovePanel);
            ItemsPanel.Controls.Add(SavePanel);
            ItemsPanel.Controls.Add(AddPanel);
            ItemsPanel.Controls.Add(ItemsLabel);
            ItemsPanel.Controls.Add(ItemsListBox);
            ItemsPanel.Dock = DockStyle.Left;
            ItemsPanel.Location = new Point(0, 0);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(349, 542);
            ItemsPanel.TabIndex = 5;
            // 
            // RemovePanel
            // 
            RemovePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemovePanel.Controls.Add(RemoveButton);
            RemovePanel.Location = new Point(119, 488);
            RemovePanel.Name = "RemovePanel";
            RemovePanel.Size = new Size(112, 48);
            RemovePanel.TabIndex = 9;
            // 
            // SavePanel
            // 
            SavePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SavePanel.Controls.Add(SaveButton);
            SavePanel.Location = new Point(235, 488);
            SavePanel.Name = "SavePanel";
            SavePanel.Size = new Size(113, 48);
            SavePanel.TabIndex = 2;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SaveButton.Location = new Point(3, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(108, 41);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddPanel
            // 
            AddPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddPanel.Controls.Add(AddButton);
            AddPanel.Location = new Point(3, 488);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(113, 48);
            AddPanel.TabIndex = 6;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsPanel);
            Controls.Add(SelectedItemPanel);
            Name = "ItemsTab";
            Size = new Size(872, 542);
            SelectedItemPanel.ResumeLayout(false);
            SelectedItemPanel.PerformLayout();
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            RemovePanel.ResumeLayout(false);
            SavePanel.ResumeLayout(false);
            AddPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label ItemsLabel;
        private ListBox ItemsListBox;
        private Button AddButton;
        private Button RemoveButton;
        private Panel SelectedItemPanel;
        private Label CostLabel;
        private Label IdLabel;
        private Label SelectedItemLabel;
        private TextBox DescriptionTextBox;
        private Label DescriptionLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Panel ItemsPanel;
        private Panel AddPanel;
        private Panel RemovePanel;
        private Button SaveButton;
        private Label InfoLabel;
        private Panel SavePanel;
    }
}
