using EasyReg.DataFolder;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EasyReg
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // проверка на существование пользователя 

            var exUser = DBEntities.GetContext().User.SingleOrDefault(u => u.Login == UsernameTextBox.Text);
            try
            {
                if (PasswordBox.Password == RepeatPasswordBox.Password)
                {
                    var newUser = new User()
                    {
                        Login = UsernameTextBox.Text,
                        Password = PasswordBox.Password,
                        IdRole = 1,
                    };
                    DBEntities.GetContext().User.Add(newUser);
                    DBEntities.GetContext().SaveChanges();

                    MessageBox.Show("Успех");
                                    }
                else
                {
                    MessageBox.Show("Провал");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
                                   
        }
    }
}
