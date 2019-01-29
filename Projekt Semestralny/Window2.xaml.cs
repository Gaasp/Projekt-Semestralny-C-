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

namespace Projekt_Semestralny
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(piec.IsChecked == true)
            {
                MainWindow.balance += 5;
                new MainWindow().label1.Content = MainWindow.balance.ToString();
                new Window3().Show();
            }
            if(dziesiec.IsChecked == true)
            {
                MainWindow.balance += 10;
                new MainWindow().label1.Content = MainWindow.balance.ToString();
                new Window3().Show();
                
            }
            if(sto.IsChecked == true)
            {
                MainWindow.balance += 100;
                new MainWindow().label1.Content = MainWindow.balance.ToString();
                new Window3().Show();
            }
            this.Hide();
        }
    }
}
