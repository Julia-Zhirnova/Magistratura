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

namespace УМК_Цифра.Teoryas
{
    /// <summary>
    /// Логика взаимодействия для tmainpage.xaml
    /// </summary>
    public partial class tmainpage : Page
    {
        public tmainpage()
        {
            InitializeComponent();
        }

        private void Button_Click_Otrasl(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Teoryas.tOtrasl());
        }

        private void Button_Click_SIZ(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Zone(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Shablon(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Razmer(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Zvet(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Kachestvo(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Kod(object sender, RoutedEventArgs e)
        {

        }
    }
}
