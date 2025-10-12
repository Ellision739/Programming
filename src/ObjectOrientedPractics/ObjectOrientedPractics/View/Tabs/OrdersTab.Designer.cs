namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            components = new System.ComponentModel.Container();
            Model.Address address2 = new Model.Address();
            OrdersPanel = new Panel();
            OrdersDataGridView = new DataGridView();
            orderBindingSource = new BindingSource(components);
            OrdersLabel = new Label();
            InfoPanel = new Panel();
            ValueLabel = new Label();
            AmountLabel = new Label();
            OrderItemsListBox = new ListBox();
            OrderItemsLabel = new Label();
            addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            StatusComboBox = new ComboBox();
            CreatedTextBox = new TextBox();
            IDTextBox = new TextBox();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IDLabel = new Label();
            SelectedOrderLabel = new Label();
            ID = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            TotalCost = new DataGridViewTextBoxColumn();
            OrdersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            InfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersPanel
            // 
            OrdersPanel.Controls.Add(OrdersDataGridView);
            OrdersPanel.Controls.Add(OrdersLabel);
            OrdersPanel.Dock = DockStyle.Left;
            OrdersPanel.Location = new Point(0, 0);
            OrdersPanel.Name = "OrdersPanel";
            OrdersPanel.Size = new Size(361, 550);
            OrdersPanel.TabIndex = 0;
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.AutoGenerateColumns = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, Created, OrderStatus, FullName, Address, TotalCost });
            OrdersDataGridView.DataSource = orderBindingSource;
            OrdersDataGridView.Location = new Point(3, 27);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RowHeadersVisible = false;
            OrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersDataGridView.Size = new Size(355, 520);
            OrdersDataGridView.TabIndex = 1;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Model.Order);
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrdersLabel.Location = new Point(3, 9);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(47, 15);
            OrdersLabel.TabIndex = 0;
            OrdersLabel.Text = "Orders";
            // 
            // InfoPanel
            // 
            InfoPanel.Controls.Add(ValueLabel);
            InfoPanel.Controls.Add(AmountLabel);
            InfoPanel.Controls.Add(OrderItemsListBox);
            InfoPanel.Controls.Add(OrderItemsLabel);
            InfoPanel.Controls.Add(addressControl);
            InfoPanel.Controls.Add(StatusComboBox);
            InfoPanel.Controls.Add(CreatedTextBox);
            InfoPanel.Controls.Add(IDTextBox);
            InfoPanel.Controls.Add(StatusLabel);
            InfoPanel.Controls.Add(CreatedLabel);
            InfoPanel.Controls.Add(IDLabel);
            InfoPanel.Controls.Add(SelectedOrderLabel);
            InfoPanel.Dock = DockStyle.Right;
            InfoPanel.Location = new Point(367, 0);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(573, 550);
            InfoPanel.TabIndex = 1;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ValueLabel.Location = new Point(477, 504);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(26, 30);
            ValueLabel.TabIndex = 11;
            ValueLabel.Text = "0";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(477, 489);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(60, 15);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(3, 332);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(567, 154);
            OrderItemsListBox.TabIndex = 9;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsLabel.Location = new Point(3, 311);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(77, 15);
            OrderItemsLabel.TabIndex = 8;
            OrderItemsLabel.Text = "Order Items";
            // 
            // addressControl
            // 
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = 0;
            address2.Street = "";
            addressControl.Address = address2;
            addressControl.Location = new Point(3, 123);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(567, 203);
            addressControl.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "New", "Processing", "Assembly", "Sent", "Delivered", "Returned", "Abandoned" });
            StatusComboBox.Location = new Point(60, 94);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(121, 23);
            StatusComboBox.TabIndex = 6;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(60, 65);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.ReadOnly = true;
            CreatedTextBox.Size = new Size(121, 23);
            CreatedTextBox.TabIndex = 5;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(60, 36);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(121, 23);
            IDTextBox.TabIndex = 4;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(3, 97);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(3, 68);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(51, 15);
            CreatedLabel.TabIndex = 2;
            CreatedLabel.Text = "Created:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(3, 39);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(21, 15);
            IDLabel.TabIndex = 1;
            IDLabel.Text = "ID:";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderLabel.Location = new Point(3, 9);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(95, 15);
            SelectedOrderLabel.TabIndex = 0;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Created
            // 
            Created.DataPropertyName = "DateOfCreation";
            Created.HeaderText = "Created";
            Created.Name = "Created";
            Created.ReadOnly = true;
            Created.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderStatus
            // 
            OrderStatus.DataPropertyName = "Status";
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "Fullname";
            FullName.HeaderText = "Customer Full Name";
            FullName.Name = "FullName";
            FullName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Address
            // 
            Address.HeaderText = "Delivery Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalCost
            // 
            TotalCost.DataPropertyName = "TotalCost";
            TotalCost.HeaderText = "Total Cost";
            TotalCost.Name = "TotalCost";
            TotalCost.ReadOnly = true;
            TotalCost.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InfoPanel);
            Controls.Add(OrdersPanel);
            Name = "OrdersTab";
            Size = new Size(940, 550);
            OrdersPanel.ResumeLayout(false);
            OrdersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel OrdersPanel;
        private Label OrdersLabel;
        private Panel InfoPanel;
        private Label IDLabel;
        private Label SelectedOrderLabel;
        private Label OrderItemsLabel;
        private Controls.AddressControl addressControl;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private TextBox IDTextBox;
        private Label StatusLabel;
        private Label CreatedLabel;
        private Label AmountLabel;
        private ListBox OrderItemsListBox;
        private Label ValueLabel;
        private DataGridView OrdersDataGridView;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn TotalCost;
    }
}
