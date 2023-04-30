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
using System.Windows.Threading;

namespace УМК_Цифра
{
    /// <summary>
    /// Логика взаимодействия для Greetings.xaml
    /// </summary>
    public partial class Greetings : Window
    {
        public Greetings()
        {
            InitializeComponent();
            //this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
            //StartCloseTimer();
        }
        /* private void StartCloseTimer()
         {
             DispatcherTimer timer = new DispatcherTimer();
             timer.Interval = TimeSpan.FromSeconds(5d);
             timer.Tick += TimerTick;
             timer.Start();
         }

         private void TimerTick(object sender, EventArgs e)
         {
             DispatcherTimer timer = (DispatcherTimer)sender;
             timer.Stop();
             timer.Tick -= TimerTick;
             Close();
         }*/
       /* void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            
        }*/
        private void BtnInLogin_Click(object sender, RoutedEventArgs e)
        {
            if (TxbLogin.Text == String.Empty || PsbPassword.Password == String.Empty)//Проверка на пустоту текстбокса
            MessageBox.Show("Введите данные");
            else
            {
                if ((TxbLogin.Text == "205AD" && PsbPassword.Password == "12345") || (TxbLogin.Text == "root" && PsbPassword.Password == "12345"))
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }
                //this.Close();

                else MessageBox.Show("Такого пользователя нет!", "Ошибка при авторизации",
                            MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            
        }
        private void SeekPass_Click(object sender, RoutedEventArgs e)
        {
            if (PsbPassword.Password.Length > 0)
            {
                PsbPassword.Visibility = Visibility.Visible;
                PsbPassword.Password = TxbPassword.Text;
                TxbPassword.Visibility = Visibility.Hidden;
                SeekPass.Visibility = Visibility.Hidden;
                ShowPass.Visibility = Visibility.Visible;
            }
        }
        private void ShowPass_Click(object sender, RoutedEventArgs e)
        {
            if (PsbPassword.Password.Length > 0)
            {
                PsbPassword.Visibility = Visibility.Hidden;
                TxbPassword.Text = PsbPassword.Password;
                TxbPassword.Visibility = Visibility.Visible;
                SeekPass.Visibility = Visibility.Visible;
                ShowPass.Visibility = Visibility.Hidden;
            }
        }

    }
}
