namespace ObjectOrientedPractics.View.Tabs
{
    partial class CardsTab
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

        private void InitializeComponent()
        {
            ItemsPanel = new Panel();
            ButtonPanel = new Panel();
            AddToCartButton = new Button();
            ItemsListBox = new ListBox();
            ItemsLabel = new Label();
            CartPanel = new Panel();
            TotalLabel = new Label();
            NumTotalLabel = new Label();
            NumDisAmountLabel = new Label();
            DiscountAmountLabel = new Label();
            DiscountsCheckedListBox = new CheckedListBox();
            DiscountsLabel = new Label();
            PriorityOrderButton = new Button();
            InfoLabel = new Label();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            ValueLabel = new Label();
            AmountLabel = new Label();
            CartListBox = new ListBox();
            CartLabel = new Label();
            CustomerComboBox = new ComboBox();
            CustomerLabel = new Label();
            ItemsPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            CartPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsPanel
            // 
            ItemsPanel.Controls.Add(ButtonPanel);
            ItemsPanel.Controls.Add(ItemsListBox);
            ItemsPanel.Controls.Add(ItemsLabel);
            ItemsPanel.Dock = DockStyle.Fill;
            ItemsPanel.Location = new Point(0, 0);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(353, 550);
            ItemsPanel.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonPanel.Controls.Add(AddToCartButton);
            ButtonPanel.Location = new Point(3, 502);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(116, 42);
            ButtonPanel.TabIndex = 9;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(8, 3);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(99, 37);
            AddToCartButton.TabIndex = 2;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 27);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(347, 469);
            ItemsListBox.TabIndex = 1;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsLabel.Location = new Point(3, 9);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(44, 15);
            ItemsLabel.TabIndex = 0;
            ItemsLabel.Text = "Items:";
            // 
            // CartPanel
            // 
            CartPanel.Controls.Add(TotalLabel);
            CartPanel.Controls.Add(NumTotalLabel);
            CartPanel.Controls.Add(NumDisAmountLabel);
            CartPanel.Controls.Add(DiscountAmountLabel);
            CartPanel.Controls.Add(DiscountsCheckedListBox);
            CartPanel.Controls.Add(DiscountsLabel);
            CartPanel.Controls.Add(PriorityOrderButton);
            CartPanel.Controls.Add(InfoLabel);
            CartPanel.Controls.Add(CreateOrderButton);
            CartPanel.Controls.Add(RemoveItemButton);
            CartPanel.Controls.Add(ClearCartButton);
            CartPanel.Controls.Add(ValueLabel);
            CartPanel.Controls.Add(AmountLabel);
            CartPanel.Controls.Add(CartListBox);
            CartPanel.Controls.Add(CartLabel);
            CartPanel.Controls.Add(CustomerComboBox);
            CartPanel.Controls.Add(CustomerLabel);
            CartPanel.Dock = DockStyle.Right;
            CartPanel.Location = new Point(353, 0);
            CartPanel.Name = "CartPanel";
            CartPanel.Size = new Size(587, 550);
            CartPanel.TabIndex = 1;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalLabel.Location = new Point(488, 495);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(52, 17);
            TotalLabel.TabIndex = 17;
            TotalLabel.Text = "TOTAL:";
            // 
            // NumTotalLabel
            // 
            NumTotalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NumTotalLabel.AutoSize = true;
            NumTotalLabel.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NumTotalLabel.Location = new Point(488, 512);
            NumTotalLabel.Name = "NumTotalLabel";
            NumTotalLabel.Size = new Size(26, 30);
            NumTotalLabel.TabIndex = 16;
            NumTotalLabel.Text = "0";
            // 
            // NumDisAmountLabel
            // 
            NumDisAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NumDisAmountLabel.AutoSize = true;
            NumDisAmountLabel.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NumDisAmountLabel.Location = new Point(488, 361);
            NumDisAmountLabel.Name = "NumDisAmountLabel";
            NumDisAmountLabel.Size = new Size(26, 30);
            NumDisAmountLabel.TabIndex = 15;
            NumDisAmountLabel.Text = "0";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountLabel.Location = new Point(431, 343);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(117, 15);
            DiscountAmountLabel.TabIndex = 13;
            DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.BackColor = SystemColors.Window;
            DiscountsCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountsCheckedListBox.CheckOnClick = true;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.IntegralHeight = false;
            DiscountsCheckedListBox.Location = new Point(6, 361);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(204, 126);
            DiscountsCheckedListBox.TabIndex = 12;
            DiscountsCheckedListBox.SelectedIndexChanged += DiscountsCheckedListBox_SelectedIndexChanged;
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountsLabel.Location = new Point(6, 343);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(71, 15);
            DiscountsLabel.TabIndex = 11;
            DiscountsLabel.Text = "Discounts:";
            // 
            // PriorityOrderButton
            // 
            PriorityOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PriorityOrderButton.Location = new Point(111, 277);
            PriorityOrderButton.Name = "PriorityOrderButton";
            PriorityOrderButton.Size = new Size(99, 47);
            PriorityOrderButton.TabIndex = 10;
            PriorityOrderButton.Text = "Create Priority Order";
            PriorityOrderButton.UseVisualStyleBackColor = true;
            PriorityOrderButton.Click += PriorityOrderButton_Click;
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(47, 516);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(0, 15);
            InfoLabel.TabIndex = 9;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateOrderButton.Location = new Point(6, 277);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(99, 47);
            CreateOrderButton.TabIndex = 8;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(375, 277);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(99, 47);
            RemoveItemButton.TabIndex = 7;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearCartButton.Location = new Point(480, 277);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(99, 47);
            ClearCartButton.TabIndex = 6;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // ValueLabel
            // 
            ValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ValueLabel.AutoSize = true;
            ValueLabel.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ValueLabel.Location = new Point(488, 244);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(26, 30);
            ValueLabel.TabIndex = 5;
            ValueLabel.Text = "0";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(488, 229);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(60, 15);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Amount:";
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(5, 87);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(574, 139);
            CartListBox.TabIndex = 3;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(5, 69);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(32, 15);
            CartLabel.TabIndex = 2;
            CartLabel.Text = "Cart:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(80, 24);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(499, 23);
            CustomerComboBox.TabIndex = 1;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomerLabel.Location = new Point(5, 27);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(69, 15);
            CustomerLabel.TabIndex = 0;
            CustomerLabel.Text = "Customer:";
            // 
            // CardsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsPanel);
            Controls.Add(CartPanel);
            Name = "CardsTab";
            Size = new Size(940, 550);
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            CartPanel.ResumeLayout(false);
            CartPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ItemsPanel;
        private Panel CartPanel;
        private Button AddToCartButton;
        private ListBox ItemsListBox;
        private Label ItemsLabel;
        private Label CartLabel;
        private ComboBox CustomerComboBox;
        private Label CustomerLabel;
        private Label ValueLabel;
        private Label AmountLabel;
        private ListBox CartListBox;
        private Button CreateOrderButton;
        private Button RemoveItemButton;
        private Button ClearCartButton;
        private Panel ButtonPanel;
        private Label InfoLabel;
        private Button PriorityOrderButton;
        private Label DiscountsLabel;
        private Label NumTotalLabel;
        private Label NumDisAmountLabel;
        private Label DiscountAmountLabel;
        private CheckedListBox DiscountsCheckedListBox;
        private Label TotalLabel;
    }
}
