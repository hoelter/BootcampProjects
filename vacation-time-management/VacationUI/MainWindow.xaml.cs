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
using VacationLib;

namespace VacationUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BeginLogin();
        }

        private void BeginLogin()
        {
            Login login = new Login();
            Close();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //AdminForm a = new AdminForm();
            //a.Show();
        }
    }
}
