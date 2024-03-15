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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            PopulateProductList();

        }


        private void PopulateProductList()
        {
            using (var context = new AppDbContext())
            {
                var products = context.Products.ToList();
                foreach (var product in products)
                {
                    productListBox.Items.Add($"{product.Name}: {product.Calories} калорий");
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim();
            using (var context = new AppDbContext())
            {
                productListBox.Items.Clear();
                var products = context.Products.Where(p => p.Name.Contains(searchText)).ToList();
                foreach (var product in products)
                {
                    productListBox.Items.Add($"{product.Name}: {product.Calories} калорий \n" +
                        $"Б - {product.Proteins}, Ж - {product.Fats}, У -{product.Carbohydrates}");
                }
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();

            PopulateProductList();
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            if (productListBox.SelectedItem != null)
            {
                string selectedProduct = productListBox.SelectedItem.ToString();
                string productName = selectedProduct.Split(':')[0].Trim();
                using (var context = new AppDbContext())
                {
                    var product = context.Products.FirstOrDefault(p => p.Name == productName);
                    if (product != null)
                    {
                        EditProductForm editProductForm = new EditProductForm(product);
                        editProductForm.ShowDialog();
              
                        PopulateProductList();
                    }

                    context.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Выберите продукт для редактирования!");
            }
        }
    }
}
