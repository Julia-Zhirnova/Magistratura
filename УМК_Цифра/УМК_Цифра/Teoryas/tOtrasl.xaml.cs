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
    /// Логика взаимодействия для tOtrasl.xaml
    /// </summary>
    public partial class tOtrasl : Page
    {
        public tOtrasl()
        {
            InitializeComponent();
            
            
        }
        int trying = 1;
        private void Proiz1(object sender, RoutedEventArgs e)
        {
            if (trying == 0) P1.Visibility = Visibility.Hidden;
            else
            {
                Score.ScorePoint -= 1;
                MessageBox.Show("Неверно, Вы потеряли балл");
                trying = 0;
                Console.WriteLine(Score.ScorePoint);
            }
        }
        private void Proiz2(object sender, RoutedEventArgs e)
        {
            
            if (trying == 0) P2.Visibility = Visibility.Hidden;
            else
            {
                Score.ScorePoint += 1;
                MessageBox.Show("Верно, Вы получили балл");
                trying = 0;
                Console.WriteLine(Score.ScorePoint);
            }


        }
        private void Proiz3(object sender, RoutedEventArgs e)
        {
            if (trying == 0) P3.Visibility = Visibility.Hidden;
            else
            {
                Score.ScorePoint -= 1;
                MessageBox.Show("Неверно, Вы потеряли балл");
                trying = 0;
                Console.WriteLine(Score.ScorePoint);
            }
        }
    }
}
