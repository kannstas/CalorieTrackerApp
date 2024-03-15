namespace CalorieTrackerApp
{
    partial class MainForm
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
            productListBox = new ListBox();
            searchTextBox = new TextBox();
            label1 = new Label();
            addProductButton = new Button();
            editProductButton = new Button();
            SuspendLayout();
            // 
            // productListBox
            // 
            productListBox.FormattingEnabled = true;
            productListBox.Location = new Point(117, 94);
            productListBox.Name = "productListBox";
            productListBox.Size = new Size(536, 284);
            productListBox.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(117, 42);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(536, 27);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 19);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Найти продукт";
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(152, 397);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(176, 29);
            addProductButton.TabIndex = 3;
            addProductButton.Text = "Добавить продукт";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // editProductButton
            // 
            editProductButton.Location = new Point(434, 397);
            editProductButton.Name = "editProductButton";
            editProductButton.Size = new Size(176, 29);
            editProductButton.TabIndex = 4;
            editProductButton.Text = "Изменить продукт";
            editProductButton.UseVisualStyleBackColor = true;
            editProductButton.Click += editProductButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editProductButton);
            Controls.Add(addProductButton);
            Controls.Add(label1);
            Controls.Add(searchTextBox);
            Controls.Add(productListBox);
            Name = "MainForm";
            Text = "Калорийность";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox productListBox;
        private TextBox searchTextBox;
        private Label label1;
        private Button addProductButton;
        private Button editProductButton;
    }
}