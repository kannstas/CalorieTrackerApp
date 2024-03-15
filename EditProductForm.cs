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
    public partial class EditProductForm : Form
    {
        private Product product;
        public EditProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;

        
            nameTextBox.Text = product.Name;
            caloriesTextBox.Text = product.Calories.ToString();
            proteinsTextBox.Text = product.Proteins.ToString();
            fatsTextBox.Text = product.Fats.ToString();
            carbohydratesTextBox.Text = product.Carbohydrates.ToString();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название продукта!");
                return;
            }

           
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
               
                var existingProduct = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
                if (existingProduct != null)
                {
                    // Обновляем значения продукта
                    existingProduct.Name = name;
                    existingProduct.Calories = calories;
                    existingProduct.Proteins = proteins;
                    existingProduct.Fats = fats;
                    existingProduct.Carbohydrates = carbohydrates;

                    context.SaveChanges();
                    MessageBox.Show("Информация о продукте успешно обновлена!");
                    this.Close();
                }
                context.Dispose();
            }
        }
    }
}
