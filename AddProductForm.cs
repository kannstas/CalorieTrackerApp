using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackerApp
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название продукта!");
                return;
            }

            // Проверяем, корректно ли заполнены числовые поля
            if (!int.TryParse(caloriesTextBox.Text, out int calories) ||
                !decimal.TryParse(proteinsTextBox.Text, out decimal proteins) ||
                !decimal.TryParse(fatsTextBox.Text, out decimal fats) ||
                !decimal.TryParse(carbohydratesTextBox.Text, out decimal carbohydrates))
            {
                MessageBox.Show("Некорректные значения для калорий, белков, жиров или углеводов!");
                return;
            }

            using (var context = new AppDbContext())
            {
                // Создаем новый продукт и сохраняем его в базе данных
                var newProduct = new Product
                {
                    Name = name,
                    Calories = calories,
                    Proteins = proteins,
                    Fats = fats,
                    Carbohydrates = carbohydrates
                };
                context.Products.Add(newProduct);
                context.SaveChanges();

                MessageBox.Show("Продукт успешно добавлен!");
                this.Close();

                context.Dispose();
            }
        }
    }
}
