using EasyReg.DataFolder;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EasyReg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = DBEntities.GetContext().User.SingleOrDefault(u => u.Login == UsernameTextBox.Text);
                if (user != null)
                {
                    MessageBox.Show("успех");
                    new Listuser().Show();
                }
                else
                    MessageBox.Show("Неудача");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Reg().Show();
            Close();
        }
    }
}
