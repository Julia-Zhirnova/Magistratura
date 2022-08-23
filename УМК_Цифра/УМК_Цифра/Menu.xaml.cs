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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void Button_Click_Teorya(object sender, RoutedEventArgs e)
        {
            Teorya teorya = new Teorya();
            teorya.Show();
        }

        private void Button_Click_Algoritm(object sender, RoutedEventArgs e)
        {
            Algoritm algoritm = new Algoritm();
            algoritm.Show();
        }

        private void Button_Click_Result(object sender, RoutedEventArgs e)
        {
            Result result = new Result();
            result.Show();
        }

        private void Button_Click_Control(object sender, RoutedEventArgs e)
        {
            Control control = new Control();
            control.Show();
        }
    }
}
