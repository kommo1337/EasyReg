using EasyReg.DataFolder;
using System.Linq;
using System.Windows;


namespace EasyReg
{
    /// <summary>
    /// Логика взаимодействия для Listuser.xaml
    /// </summary>
    public partial class Listuser : Window
    {
        public Listuser()
        {
            InitializeComponent();
            UserDG.ItemsSource = DBEntities.GetContext().User.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
