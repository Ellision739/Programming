namespace ObjectOrientedPractics
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CustomersTabPage = new TabPage();
            customersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            ItemTabPage = new TabPage();
            itemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            MainTabControl = new TabControl();
            CartsTabPage = new TabPage();
            cartsTab = new ObjectOrientedPractics.View.Tabs.CardsTab();
            OrdersTab = new TabPage();
            ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            TestTabPage = new TabPage();
            priorityOrdersTab = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            CustomersTabPage.SuspendLayout();
            ItemTabPage.SuspendLayout();
            MainTabControl.SuspendLayout();
            CartsTabPage.SuspendLayout();
            OrdersTab.SuspendLayout();
            TestTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(customersTab);
            CustomersTabPage.Location = new Point(4, 24);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(940, 550);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(3, 3);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(934, 544);
            customersTab.TabIndex = 0;
            // 
            // ItemTabPage
            // 
            ItemTabPage.Controls.Add(itemsTab);
            ItemTabPage.Location = new Point(4, 24);
            ItemTabPage.Name = "ItemTabPage";
            ItemTabPage.Padding = new Padding(3);
            ItemTabPage.Size = new Size(940, 550);
            ItemTabPage.TabIndex = 0;
            ItemTabPage.Text = "Items";
            ItemTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            itemsTab.Dock = DockStyle.Fill;
            itemsTab.Location = new Point(3, 3);
            itemsTab.Name = "itemsTab";
            itemsTab.Size = new Size(934, 544);
            itemsTab.TabIndex = 0;
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemTabPage);
            MainTabControl.Controls.Add(CustomersTabPage);
            MainTabControl.Controls.Add(CartsTabPage);
            MainTabControl.Controls.Add(OrdersTab);
            MainTabControl.Controls.Add(TestTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(948, 578);
            MainTabControl.TabIndex = 0;
            MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            // 
            // CartsTabPage
            // 
            CartsTabPage.Controls.Add(cartsTab);
            CartsTabPage.Location = new Point(4, 24);
            CartsTabPage.Name = "CartsTabPage";
            CartsTabPage.Padding = new Padding(3);
            CartsTabPage.Size = new Size(940, 550);
            CartsTabPage.TabIndex = 2;
            CartsTabPage.Text = "Carts";
            CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab
            // 
            cartsTab.Customers = null;
            cartsTab.Dock = DockStyle.Fill;
            cartsTab.Location = new Point(3, 3);
            cartsTab.Name = "cartsTab";
            cartsTab.Size = new Size(934, 544);
            cartsTab.TabIndex = 0;
            // 
            // OrdersTab
            // 
            OrdersTab.Controls.Add(ordersTab1);
            OrdersTab.Location = new Point(4, 24);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Padding = new Padding(3);
            OrdersTab.Size = new Size(940, 550);
            OrdersTab.TabIndex = 3;
            OrdersTab.Text = "Orders";
            OrdersTab.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Customers = null;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(3, 3);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(934, 544);
            ordersTab1.TabIndex = 0;
            // 
            // TestTabPage
            // 
            TestTabPage.Controls.Add(priorityOrdersTab);
            TestTabPage.Location = new Point(4, 24);
            TestTabPage.Name = "TestTabPage";
            TestTabPage.Padding = new Padding(3);
            TestTabPage.Size = new Size(940, 550);
            TestTabPage.TabIndex = 4;
            TestTabPage.Text = "Test";
            TestTabPage.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab
            // 
            priorityOrdersTab.Dock = DockStyle.Fill;
            priorityOrdersTab.Location = new Point(3, 3);
            priorityOrdersTab.Name = "priorityOrdersTab";
            priorityOrdersTab.PriorityOrder = null;
            priorityOrdersTab.Size = new Size(934, 544);
            priorityOrdersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 578);
            Controls.Add(MainTabControl);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            CustomersTabPage.ResumeLayout(false);
            ItemTabPage.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
            CartsTabPage.ResumeLayout(false);
            OrdersTab.ResumeLayout(false);
            TestTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private View.Tabs.ItemsTab itemsTab1;
        private TabPage CustomersTabPage;
        private TabPage ItemTabPage;
        private View.Tabs.ItemsTab itemsTab;
        private TabControl MainTabControl;
        private View.Tabs.CustomersTab customersTab;
        private TabPage CartsTabPage;
        private View.Tabs.CardsTab cartsTab;
        private TabPage OrdersTab;
        private View.Tabs.OrdersTab ordersTab1;
        private TabPage TestTabPage;
        private View.Tabs.PriorityOrdersTab priorityOrdersTab;
    }
}
