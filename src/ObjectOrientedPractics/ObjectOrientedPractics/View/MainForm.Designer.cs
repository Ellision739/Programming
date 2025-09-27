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
            CustomersTabPage = new TabPage();
            customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            MainTabControl = new TabControl();
            ItemTabPage = new TabPage();
            itemsTab2 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            CustomersTabPage.SuspendLayout();
            MainTabControl.SuspendLayout();
            ItemTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(customersTab1);
            CustomersTabPage.Location = new Point(4, 24);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(882, 534);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(876, 528);
            customersTab1.TabIndex = 0;
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemTabPage);
            MainTabControl.Controls.Add(CustomersTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(890, 562);
            MainTabControl.TabIndex = 0;
            // 
            // ItemTabPage
            // 
            ItemTabPage.Controls.Add(itemsTab2);
            ItemTabPage.Location = new Point(4, 24);
            ItemTabPage.Name = "ItemTabPage";
            ItemTabPage.Padding = new Padding(3);
            ItemTabPage.Size = new Size(882, 534);
            ItemTabPage.TabIndex = 0;
            ItemTabPage.Text = "Items";
            ItemTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab2
            // 
            itemsTab2.Dock = DockStyle.Fill;
            itemsTab2.Location = new Point(3, 3);
            itemsTab2.Name = "itemsTab2";
            itemsTab2.Size = new Size(876, 528);
            itemsTab2.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 562);
            Controls.Add(MainTabControl);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            CustomersTabPage.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
            ItemTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage CustomersTabPage;
        private View.Tabs.ItemsTab itemsTab1;
        private TabControl MainTabControl;
        private TabPage ItemTabPage;
        private View.Tabs.ItemsTab itemsTab2;
        private View.Tabs.CustomersTab customersTab1;
    }
}
