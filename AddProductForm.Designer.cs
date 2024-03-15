namespace CalorieTrackerApp
{
    partial class AddProductForm
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
            nameTextBox = new TextBox();
            fatsTextBox = new TextBox();
            proteinsTextBox = new TextBox();
            caloriesTextBox = new TextBox();
            carbohydratesTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            addButton = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(39, 53);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(423, 27);
            nameTextBox.TabIndex = 0;
            // 
            // fatsTextBox
            // 
            fatsTextBox.Location = new Point(43, 180);
            fatsTextBox.Name = "fatsTextBox";
            fatsTextBox.Size = new Size(182, 27);
            fatsTextBox.TabIndex = 1;
            // 
            // proteinsTextBox
            // 
            proteinsTextBox.Location = new Point(269, 110);
            proteinsTextBox.Name = "proteinsTextBox";
            proteinsTextBox.Size = new Size(187, 27);
            proteinsTextBox.TabIndex = 2;
            // 
            // caloriesTextBox
            // 
            caloriesTextBox.Location = new Point(43, 110);
            caloriesTextBox.Name = "caloriesTextBox";
            caloriesTextBox.Size = new Size(172, 27);
            caloriesTextBox.TabIndex = 3;
            // 
            // carbohydratesTextBox
            // 
            carbohydratesTextBox.Location = new Point(269, 180);
            carbohydratesTextBox.Name = "carbohydratesTextBox";
            carbohydratesTextBox.Size = new Size(187, 27);
            carbohydratesTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 5;
            label1.Text = "Введите название продукта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 87);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Белки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 157);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 7;
            label3.Text = "Углеводы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 157);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 8;
            label4.Text = "Жиры";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 87);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 9;
            label5.Text = "Калории";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 238);
            label6.Name = "label6";
            label6.Size = new Size(334, 20);
            label6.TabIndex = 10;
            label6.Text = "*расчёт пищевой ценности продукта на 100 гр";
            // 
            // addButton
            // 
            addButton.Location = new Point(509, 110);
            addButton.Name = "addButton";
            addButton.Size = new Size(96, 38);
            addButton.TabIndex = 11;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 291);
            Controls.Add(addButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(carbohydratesTextBox);
            Controls.Add(caloriesTextBox);
            Controls.Add(proteinsTextBox);
            Controls.Add(fatsTextBox);
            Controls.Add(nameTextBox);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox fatsTextBox;
        private TextBox proteinsTextBox;
        private TextBox caloriesTextBox;
        private TextBox carbohydratesTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button addButton;
    }
}