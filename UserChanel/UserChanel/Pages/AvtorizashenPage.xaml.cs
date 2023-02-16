using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserChanel.Pages
{
    /// <summary>
    /// Логика взаимодействия для AvtorizashenPage.xaml
    /// </summary>
    public partial class AvtorizashenPage : Page
    {
        public AvtorizashenPage()
        {
            InitializeComponent();
        }

        private void ABavorizashen_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User.FirstOrDefault(q => q.Login == TBLogin.Text && q.Password == TBPassword.Text);
            if (user == null)
                MessageBox.Show("неверные данные");
            else
            NavigationService.Navigate(new MainPage());

        }

        private void TBLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
