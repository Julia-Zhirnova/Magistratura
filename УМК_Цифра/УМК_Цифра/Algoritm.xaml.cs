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

namespace УМК_Цифра
{
    /// <summary>
    /// Логика взаимодействия для Algoritm.xaml
    /// </summary>
    public partial class Algoritm : Window
    {
        public Algoritm()
        {
            InitializeComponent();
            MainFrame.Navigate(new Algoritms.mainpage());
            Manager.MainFrame = MainFrame;
        }

    }
}
