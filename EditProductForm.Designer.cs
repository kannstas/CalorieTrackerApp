namespace CalorieTrackerApp
{
    partial class EditProductForm
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
            saveButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            carbohydratesTextBox = new TextBox();
            caloriesTextBox = new TextBox();
            proteinsTextBox = new TextBox();
            fatsTextBox = new TextBox();
            nameTextBox = new TextBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(504, 91);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(96, 38);
            saveButton.TabIndex = 23;
            saveButton.Text = "Изменить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 219);
            label6.Name = "label6";
            label6.Size = new Size(334, 20);
            label6.TabIndex = 22;
            label6.Text = "*расчёт пищевой ценности продукта на 100 гр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 68);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 21;
            label5.Text = "Калории";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 138);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 20;
            label4.Text = "Жиры";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 138);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 19;
            label3.Text = "Углеводы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 68);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 18;
            label2.Text = "Белки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 11);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 17;
            label1.Text = "Введите название продукта";
            // 
            // carbohydratesTextBox
            // 
            carbohydratesTextBox.Location = new Point(264, 161);
            carbohydratesTextBox.Name = "carbohydratesTextBox";
            carbohydratesTextBox.Size = new Size(187, 27);
            carbohydratesTextBox.TabIndex = 16;
            // 
            // caloriesTextBox
            // 
            caloriesTextBox.Location = new Point(38, 91);
            caloriesTextBox.Name = "caloriesTextBox";
            caloriesTextBox.Size = new Size(172, 27);
            caloriesTextBox.TabIndex = 15;
            // 
            // proteinsTextBox
            // 
            proteinsTextBox.Location = new Point(264, 91);
            proteinsTextBox.Name = "proteinsTextBox";
            proteinsTextBox.Size = new Size(187, 27);
            proteinsTextBox.TabIndex = 14;
            // 
            // fatsTextBox
            // 
            fatsTextBox.Location = new Point(38, 161);
            fatsTextBox.Name = "fatsTextBox";
            fatsTextBox.Size = new Size(182, 27);
            fatsTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(34, 34);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(423, 27);
            nameTextBox.TabIndex = 12;
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 250);
            Controls.Add(saveButton);
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
            Name = "EditProductForm";
            Text = "Изменить продукт";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox carbohydratesTextBox;
        private TextBox caloriesTextBox;
        private TextBox proteinsTextBox;
        private TextBox fatsTextBox;
        private TextBox nameTextBox;
    }
}