namespace Lab3
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
            tabControlRectangles = new TabControl();
            tabPage1 = new TabPage();
            seasonHandlePanel1 = new Lab3.View.Panels.SeasonHandlePanel();
            enumerationsPanel1 = new Lab3.View.Panels.EnumerationsPanel();
            weekdayParsingPanel1 = new Lab3.View.Panels.WeekdayParsingPanel();
            tabPage2 = new TabPage();
            moviePanel1 = new Lab3.View.Panels.MoviePanel();
            rectanglesPanel1 = new Lab3.View.Panels.RectanglesPanel();
            tabPage4 = new TabPage();
            rectanglesCollisionControl1 = new Lab3.View.RectanglesCollisionControl();
            tabControlRectangles.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRectangles
            // 
            tabControlRectangles.Controls.Add(tabPage1);
            tabControlRectangles.Controls.Add(tabPage2);
            tabControlRectangles.Controls.Add(tabPage4);
            tabControlRectangles.Location = new Point(12, 12);
            tabControlRectangles.Name = "tabControlRectangles";
            tabControlRectangles.SelectedIndex = 0;
            tabControlRectangles.Size = new Size(887, 530);
            tabControlRectangles.TabIndex = 0;
            tabControlRectangles.Text = "Rectangles";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(seasonHandlePanel1);
            tabPage1.Controls.Add(enumerationsPanel1);
            tabPage1.Controls.Add(weekdayParsingPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(879, 502);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // seasonHandlePanel1
            // 
            seasonHandlePanel1.Location = new Point(444, 321);
            seasonHandlePanel1.Name = "seasonHandlePanel1";
            seasonHandlePanel1.Size = new Size(425, 175);
            seasonHandlePanel1.TabIndex = 2;
            // 
            // enumerationsPanel1
            // 
            enumerationsPanel1.Location = new Point(3, 6);
            enumerationsPanel1.Name = "enumerationsPanel1";
            enumerationsPanel1.Size = new Size(644, 289);
            enumerationsPanel1.TabIndex = 1;
            // 
            // weekdayParsingPanel1
            // 
            weekdayParsingPanel1.Location = new Point(6, 324);
            weekdayParsingPanel1.Name = "weekdayParsingPanel1";
            weekdayParsingPanel1.Size = new Size(435, 168);
            weekdayParsingPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(moviePanel1);
            tabPage2.Controls.Add(rectanglesPanel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(879, 502);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Classes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // moviePanel1
            // 
            moviePanel1.Location = new Point(440, 11);
            moviePanel1.Name = "moviePanel1";
            moviePanel1.Size = new Size(350, 381);
            moviePanel1.TabIndex = 3;
            // 
            // rectanglesPanel1
            // 
            rectanglesPanel1.Location = new Point(60, 32);
            rectanglesPanel1.Name = "rectanglesPanel1";
            rectanglesPanel1.Size = new Size(326, 360);
            rectanglesPanel1.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(rectanglesCollisionControl1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(879, 502);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Rectangles";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Location = new Point(1, 0);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(875, 514);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 540);
            Controls.Add(tabControlRectangles);
            Name = "MainForm";
            Text = "Programming Demo";
            tabControlRectangles.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlRectangles;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private View.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.RectanglesPanel rectanglesPanel1;
        private View.Panels.MoviePanel moviePanel1;
        private View.Panels.WeekdayParsingPanel weekdayParsingPanel1;
        private View.Panels.EnumerationsPanel enumerationsPanel1;
        private View.Panels.SeasonHandlePanel seasonHandlePanel1;
    }
}
