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

namespace Auth
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            MainWindow window = new MainWindow();
            if (Login.Text == "" || Password.Text == "") Error.Text = "Поля пустые";
            else
            {
                    if (Login.Text.Length < 4) Error.Text = "Логин должен быть больше 3 символов";
                else
                {
                    if (Password.Text.Length < 6) Error.Text = "Пароль должен быть больше 5 символов";
                    else
                    {
                        Error.Text = "";
                        window1.Show();
                    }
                }
            }
        }
    }
}
