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
using System.Windows.Shapes;
using WpfApp1.Entity;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            User user = DemoSSEntities.GetContext().Users.FirstOrDefault(p => p.Login == TbLogin.Text && p.Password == TbPass.Text);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            if (user == null)
            {
                MessageBox.Show("Неверно введён логин или пароль");
                return;
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
