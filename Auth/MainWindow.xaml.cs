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

        Label passLabel = new Label();
        StackPanel aPanel = new StackPanel();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            MainWindow window = new MainWindow();
            if (Login.Text == "" || Password.Password == "") Error.Text = "Поля пустые";
            else
            {
                    if (Login.Text.Length < 4) Error.Text = "Логин должен быть больше 3 символов";
                else
                {
                    if (Password.Password.Length < 6) Error.Text = "Пароль должен быть больше 5 символов";
                    else
                    {
                        Error.Text = "";
                        window1.Show();
                        this.Close();
                    }
                }
            }
        }

        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            Password.Background = null;
        }

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBlock someText = new TextBlock();
            someText.Text = "Hello, World";

            aPanel.Children.Add(someText);
            /*Password.Background = new VisualBrush().Visual =;*/
        }
    }
}
