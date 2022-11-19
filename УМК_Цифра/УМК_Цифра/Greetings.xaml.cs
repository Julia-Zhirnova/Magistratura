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
        private void TbxShowPass_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxbPassword.Visibility = Visibility.Visible;
            PsbPassword.Visibility = Visibility.Collapsed;
            TxbPassword.Text = PsbPassword.Password;
        }

        private void TbxShowPass_MouseUp(object sender, MouseButtonEventArgs e)
        {
            TxbPassword.Visibility = Visibility.Collapsed;
            PsbPassword.Visibility = Visibility.Visible;
        }
    }
}
