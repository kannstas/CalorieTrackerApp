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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }



        private void registerButton_Click_1(object sender, EventArgs e)
        {

            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                using (var context = new AppDbContext())
                {
                   
                    if (context.Users.Any(u => u.Username == username))
                    {
                        MessageBox.Show("Пользователь с таким именем уже существует!");
                        return;
                    }

                    var newUser = new User
                    {
                        Username = username,
                        PasswordHash = password
                    };
                    context.Users.Add(newUser);
                    context.SaveChanges();

                    MessageBox.Show("Пользователь успешно зарегистрирован!");
                    this.Close();

                    context.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Введите имя пользователя и пароль!");
            }
        }

      
    }
}
