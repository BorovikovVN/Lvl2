using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lvl2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();
        public MainWindow()
        {
            users.Add(new User("Admin", "123", true));
            users.Add(new User("User", "1234", false));
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in users)
            {
                if (item.UserLogin == Login.Text.ToString() && item.UserPassword == Password.Text.ToString())
                {
                    if (CheckBox1.IsChecked == false)
                    {
                        Window1 window = new Window1(false);
                        window.Show();
                    }
                    else
                    {
                        if (item.IsAdmin)
                        {
                            Window2 window = new Window2();
                            window.Show();
                        }
                        else
                        {
                            Window1 window = new Window1(true);
                            window.Show();
                        }
                    }
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Пользователь не найден");
        }
    }
}