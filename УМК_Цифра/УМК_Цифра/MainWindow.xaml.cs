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
using System.Windows.Threading;

namespace УМК_Цифра
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
        }
        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /*Menu menu = new Menu();
            menu.Show();*/
            Greetings greetings = new Greetings();
            greetings.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
        
    }
}
