namespace Lab3.View
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            CanvasPanel = new Panel();
            RectanglesBoxPaint = new ListBox();
            RectanglesLabelPaint = new Label();
            AddRectangleButton = new Button();
            DeleteRectangleButton = new Button();
            SelectedLabelPaint = new Label();
            IDLabelPaint = new Label();
            XLabelPaint = new Label();
            IDBoxPaint = new TextBox();
            XBoxPaint = new TextBox();
            YLabelPaint = new Label();
            YBoxPaint = new TextBox();
            WidthLabelPaint = new Label();
            WidthBoxPaint = new TextBox();
            HeightLabelPaint = new Label();
            HeightBoxPaint = new TextBox();
            ErrorLabel = new Label();
            SuspendLayout();
            // 
            // CanvasPanel
            // 
            CanvasPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvasPanel.Location = new Point(366, 16);
            CanvasPanel.Name = "CanvasPanel";
            CanvasPanel.Size = new Size(490, 464);
            CanvasPanel.TabIndex = 14;
            // 
            // RectanglesBoxPaint
            // 
            RectanglesBoxPaint.FormattingEnabled = true;
            RectanglesBoxPaint.ItemHeight = 15;
            RectanglesBoxPaint.Location = new Point(12, 34);
            RectanglesBoxPaint.Name = "RectanglesBoxPaint";
            RectanglesBoxPaint.Size = new Size(308, 154);
            RectanglesBoxPaint.TabIndex = 17;
            RectanglesBoxPaint.SelectedValueChanged += RectanglesBoxPaint_SelectedIndexChanged;
            // 
            // RectanglesLabelPaint
            // 
            RectanglesLabelPaint.AutoSize = true;
            RectanglesLabelPaint.Location = new Point(12, 16);
            RectanglesLabelPaint.Name = "RectanglesLabelPaint";
            RectanglesLabelPaint.Size = new Size(67, 15);
            RectanglesLabelPaint.TabIndex = 18;
            RectanglesLabelPaint.Text = "Rectangles:";
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.FlatAppearance.BorderSize = 0;
            AddRectangleButton.FlatStyle = FlatStyle.Flat;
            AddRectangleButton.Image = (Image)resources.GetObject("AddRectangleButton.Image");
            AddRectangleButton.Location = new Point(51, 206);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(38, 36);
            AddRectangleButton.TabIndex = 19;
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click_1;
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.FlatAppearance.BorderSize = 0;
            DeleteRectangleButton.FlatStyle = FlatStyle.Flat;
            DeleteRectangleButton.Image = (Image)resources.GetObject("DeleteRectangleButton.Image");
            DeleteRectangleButton.Location = new Point(235, 206);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(43, 36);
            DeleteRectangleButton.TabIndex = 20;
            DeleteRectangleButton.UseVisualStyleBackColor = true;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // SelectedLabelPaint
            // 
            SelectedLabelPaint.AutoSize = true;
            SelectedLabelPaint.Location = new Point(12, 260);
            SelectedLabelPaint.Name = "SelectedLabelPaint";
            SelectedLabelPaint.Size = new Size(109, 15);
            SelectedLabelPaint.TabIndex = 21;
            SelectedLabelPaint.Text = "Selected Rectangle:";
            // 
            // IDLabelPaint
            // 
            IDLabelPaint.AutoSize = true;
            IDLabelPaint.Location = new Point(51, 285);
            IDLabelPaint.Name = "IDLabelPaint";
            IDLabelPaint.Size = new Size(20, 15);
            IDLabelPaint.TabIndex = 22;
            IDLabelPaint.Text = "Id:";
            // 
            // XLabelPaint
            // 
            XLabelPaint.AutoSize = true;
            XLabelPaint.Location = new Point(54, 320);
            XLabelPaint.Name = "XLabelPaint";
            XLabelPaint.Size = new Size(17, 15);
            XLabelPaint.TabIndex = 23;
            XLabelPaint.Text = "X:";
            // 
            // IDBoxPaint
            // 
            IDBoxPaint.Location = new Point(77, 282);
            IDBoxPaint.Name = "IDBoxPaint";
            IDBoxPaint.Size = new Size(100, 23);
            IDBoxPaint.TabIndex = 24;
            // 
            // XBoxPaint
            // 
            XBoxPaint.Location = new Point(77, 320);
            XBoxPaint.Name = "XBoxPaint";
            XBoxPaint.Size = new Size(100, 23);
            XBoxPaint.TabIndex = 25;
            XBoxPaint.TextChanged += XBoxPaint_TextChanged;
            // 
            // YLabelPaint
            // 
            YLabelPaint.AutoSize = true;
            YLabelPaint.Location = new Point(54, 353);
            YLabelPaint.Name = "YLabelPaint";
            YLabelPaint.Size = new Size(17, 15);
            YLabelPaint.TabIndex = 26;
            YLabelPaint.Text = "Y:";
            // 
            // YBoxPaint
            // 
            YBoxPaint.Location = new Point(77, 353);
            YBoxPaint.Name = "YBoxPaint";
            YBoxPaint.Size = new Size(100, 23);
            YBoxPaint.TabIndex = 27;
            YBoxPaint.TextChanged += YBoxPaint_TextChanged;
            // 
            // WidthLabelPaint
            // 
            WidthLabelPaint.AutoSize = true;
            WidthLabelPaint.Location = new Point(29, 387);
            WidthLabelPaint.Name = "WidthLabelPaint";
            WidthLabelPaint.Size = new Size(42, 15);
            WidthLabelPaint.TabIndex = 28;
            WidthLabelPaint.Text = "Width:";
            // 
            // WidthBoxPaint
            // 
            WidthBoxPaint.Location = new Point(77, 387);
            WidthBoxPaint.Name = "WidthBoxPaint";
            WidthBoxPaint.Size = new Size(100, 23);
            WidthBoxPaint.TabIndex = 29;
            WidthBoxPaint.TextChanged += WidthBoxPaint_TextChanged;
            // 
            // HeightLabelPaint
            // 
            HeightLabelPaint.AutoSize = true;
            HeightLabelPaint.Location = new Point(25, 421);
            HeightLabelPaint.Name = "HeightLabelPaint";
            HeightLabelPaint.Size = new Size(46, 15);
            HeightLabelPaint.TabIndex = 30;
            HeightLabelPaint.Text = "Height:";
            // 
            // HeightBoxPaint
            // 
            HeightBoxPaint.Location = new Point(77, 421);
            HeightBoxPaint.Name = "HeightBoxPaint";
            HeightBoxPaint.Size = new Size(100, 23);
            HeightBoxPaint.TabIndex = 31;
            HeightBoxPaint.TextChanged += HeightBoxPaint_TextChanged;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(235, 285);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 15);
            ErrorLabel.TabIndex = 32;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ErrorLabel);
            Controls.Add(HeightBoxPaint);
            Controls.Add(HeightLabelPaint);
            Controls.Add(WidthBoxPaint);
            Controls.Add(WidthLabelPaint);
            Controls.Add(YBoxPaint);
            Controls.Add(YLabelPaint);
            Controls.Add(XBoxPaint);
            Controls.Add(IDBoxPaint);
            Controls.Add(XLabelPaint);
            Controls.Add(IDLabelPaint);
            Controls.Add(SelectedLabelPaint);
            Controls.Add(DeleteRectangleButton);
            Controls.Add(AddRectangleButton);
            Controls.Add(RectanglesLabelPaint);
            Controls.Add(RectanglesBoxPaint);
            Controls.Add(CanvasPanel);
            Name = "RectanglesCollisionControl";
            Size = new Size(875, 497);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CanvasPanel;
        private ListBox RectanglesBoxPaint;
        private Label RectanglesLabelPaint;
        private Button AddRectangleButton;
        private Button DeleteRectangleButton;
        private Label SelectedLabelPaint;
        private Label IDLabelPaint;
        private Label XLabelPaint;
        private TextBox IDBoxPaint;
        private TextBox XBoxPaint;
        private Label YLabelPaint;
        private TextBox YBoxPaint;
        private Label WidthLabelPaint;
        private TextBox WidthBoxPaint;
        private Label HeightLabelPaint;
        private TextBox HeightBoxPaint;
        private Label ErrorLabel;
    }
}
