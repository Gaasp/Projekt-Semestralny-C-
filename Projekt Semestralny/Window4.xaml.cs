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
    /// Logika interakcji dla klasy Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public static double p250_cena = 17.30;
        public static double ak47_cena = 137.76;
        public static double aug_cena = 0.58;
        public static double m4a1_cena = 8.57;
        public static double mac10_cena = 0.13;
        public static double karambit_cena = 1303.27;
        public static double huntsman_cena = 252.50;
        public static double bayonet_cena = 335.96;
        public static double tec_cena = 0.21;
        public static double r8_cena = 8.19;
        int wybrana = 0;
        public Window4()
        {
            InitializeComponent();
            sprzedaj.Visibility = Visibility.Hidden;
            sprzedaj.IsEnabled = false;
        }

     
      private void sprzedaj_przedmiot()
        {
         
        }

        private void AK_Click(object sender, RoutedEventArgs e)
        {
            glowne.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/ak47_the_empress.png"));
            ilosc.Content = "Ilość: " + MainWindow.ak47.ToString();
            cena.Content = "Cena: " + ak47_cena + "$";
            wybrana = 1;
            if (MainWindow.ak47 >= 1)
            {
                sprzedaj.IsEnabled = true;
                sprzedaj.Visibility = Visibility.Visible;

            }
        }

        private void AUG_Click(object sender, RoutedEventArgs e)
        {
            glowne.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/aug_tiqua.png"));
            ilosc.Content = "Ilość: " + MainWindow.aug.ToString();
            cena.Content = "Cena: " + aug_cena + "$";
            wybrana = 2;
            if (MainWindow.aug >= 1)
            {
                sprzedaj.IsEnabled = true;
                sprzedaj.Visibility = Visibility.Visible;

            }
        }

        private void M4A1_Click(object sender, RoutedEventArgs e)
        {
            glowne.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/m4a1-s_leaded_glass.png"));
            ilosc.Content = "Ilość: " + MainWindow.m4a1.ToString();
            cena.Content = "Cena: " + m4a1_cena + "$";
            wybrana = 3;
            if (MainWindow.m4a1 >= 1)
            {
                sprzedaj.IsEnabled = true;
                sprzedaj.Visibility = Visibility.Visible;

            }
        }

        private void MAC_Click(object sender, RoutedEventArgs e)
        {
            glowne.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/mac-10_oceanic.png"));
            ilosc.Content = "Ilość: " + MainWindow.mac10.ToString();
            cena.Content = "Cena: " + mac10_cena + "$";
            wybrana = 4;
            if (MainWindow.mac10 >= 1)
            {
                sprzedaj.IsEnabled = true;
                sprzedaj.Visibility = Visibility.Visible;

            }
        }

        private void P250_Click(object sender, RoutedEventArgs e)
        {
            glowne.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/p250_see_ya_later.png"));
            ilosc.Content = "Ilość: " + MainWindow.p250.ToString();
            cena.Content = "Cena: " + p250_cena + "$";
            wybrana = 5;
            if (MainWindow.p250 >= 1)
            {
                sprzedaj.IsEnabled = true;
                sprzedaj.Visibility = Visibility.Visible;

            }
        }

        private void R8_Click(object sender, RoutedEventArgs e)
        {
            glowne.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/r8_revolver_llama_cannon.png"));
            ilosc.Content = "Ilość: " + MainWindow.r8.ToString();
            cena.Content = "Cena: " + r8_cena + "$";
            wybrana = 6;
            if (MainWindow.r8 >= 1)
            {
                sprzedaj.IsEnabled = true;
                sprzedaj.Visibility = Visibility.Visible;

            }
        }

        private void Tec_Click(object sender, RoutedEventArgs e)
        {
            glowne.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/tec-9_cracked_opal.png"));
            ilosc.Content = "Ilość: " + MainWindow.tec.ToString();
            cena.Content = "Cena: " + tec_cena + "$";
            wybrana = 7;
            if (MainWindow.tec >= 1)
            {
                sprzedaj.IsEnabled = true;
                sprzedaj.Visibility = Visibility.Visible;

            }
        }

        private void Bayonet_Click(object sender, RoutedEventArgs e)
        {
            glowne.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/bayonet_gammadoppler.png"));
            ilosc.Content = "Ilość: " + MainWindow.bayonet.ToString();
            cena.Content = "Cena: " + bayonet_cena + "$";
            wybrana = 8;
            if (MainWindow.bayonet >= 1)
            {
                sprzedaj.IsEnabled = true;
                sprzedaj.Visibility = Visibility.Visible;

            }
        }

        private void Hunstam_Click(object sender, RoutedEventArgs e)
        {
            glowne.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/hunstam_knife_marble_fade.png"));
            ilosc.Content = "Ilość: " + MainWindow.huntsman.ToString();
            cena.Content = "Cena: " + huntsman_cena + "$";
            wybrana = 9;
            if (MainWindow.huntsman >= 1)
            {
                sprzedaj.IsEnabled = true;
                sprzedaj.Visibility = Visibility.Visible;

            }
        }

        private void Karambit_Click(object sender, RoutedEventArgs e)
        {
            glowne.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/karambit_lore.png"));
            ilosc.Content = "Ilość: " + MainWindow.karambit.ToString();
            cena.Content = "Cena: " + karambit_cena + "$";
          
            if(MainWindow.karambit>=1)
            {
                sprzedaj.IsEnabled = true;
                sprzedaj.Visibility = Visibility.Visible;
                wybrana = 10;
            }
            else
            {
                sprzedaj.IsEnabled = false;
                sprzedaj.Visibility = Visibility.Hidden;

            }
        }

        private void Sprzedaj_Click(object sender, RoutedEventArgs e)
        {
            switch (wybrana)
            {
                case 1: MainWindow.balance += ak47_cena; MainWindow.ak47 -= 1; ilosc.Content = "Ilość: " + MainWindow.ak47.ToString(); if (MainWindow.ak47 <= 0)
                    {
                        sprzedaj.IsEnabled = false;
                        sprzedaj.Visibility = Visibility.Hidden;
                    }
                    break;
                case 2: MainWindow.balance += aug_cena; MainWindow.aug -= 1; ilosc.Content = "Ilość: " + MainWindow.aug.ToString(); if (MainWindow.aug <= 0)
                    {
                        sprzedaj.IsEnabled = false;
                        sprzedaj.Visibility = Visibility.Hidden;
                    }
                    break;
                case 3: MainWindow.balance += m4a1_cena; MainWindow.m4a1 -= 1; ilosc.Content = "Ilość: " + MainWindow.m4a1.ToString(); if (MainWindow.m4a1 <= 0)
                    {
                        sprzedaj.IsEnabled = false;
                        sprzedaj.Visibility = Visibility.Hidden;
                    }
                    break;
                case 4: MainWindow.balance += mac10_cena; MainWindow.mac10 -= 1; ilosc.Content = "Ilość: " + MainWindow.mac10.ToString(); if (MainWindow.mac10 <= 0)
                    {
                        sprzedaj.IsEnabled = false;
                        sprzedaj.Visibility = Visibility.Hidden;
                    }
                    break;
                case 5: MainWindow.balance += p250_cena; MainWindow.p250 -= 1; ilosc.Content = "Ilość: " + MainWindow.p250.ToString(); if (MainWindow.p250 <= 0)
                    {
                        sprzedaj.IsEnabled = false;
                        sprzedaj.Visibility = Visibility.Hidden;
                    }
                    break;
                case 6: MainWindow.balance += r8_cena; MainWindow.r8 -= 1; ilosc.Content = "Ilość: " + MainWindow.r8.ToString(); if (MainWindow.r8 <= 0)
                    {
                        sprzedaj.IsEnabled = false;
                        sprzedaj.Visibility = Visibility.Hidden;
                    }
                    break;
                case 7: MainWindow.balance += tec_cena; MainWindow.tec -= 1; ilosc.Content = "Ilość: " + MainWindow.tec.ToString(); if (MainWindow.tec <= 0)
                    {
                        sprzedaj.IsEnabled = false;
                        sprzedaj.Visibility = Visibility.Hidden;
                    }
                    break;
                case 8: MainWindow.balance += bayonet_cena; MainWindow.bayonet -= 1; ilosc.Content = "Ilość: " + MainWindow.bayonet.ToString(); if (MainWindow.bayonet <= 0)
                    {
                        sprzedaj.IsEnabled = false;
                        sprzedaj.Visibility = Visibility.Hidden;
                    }
                    break;
                case 9: MainWindow.balance += huntsman_cena; MainWindow.huntsman -= 1; ilosc.Content = "Ilość: " + MainWindow.huntsman.ToString(); if (MainWindow.huntsman <= 0)
                    {
                        sprzedaj.IsEnabled = false;
                        sprzedaj.Visibility = Visibility.Hidden;
                    }
                    break;
                case 10: MainWindow.balance += karambit_cena; MainWindow.karambit -= 1; ilosc.Content = "Ilość: " + MainWindow.karambit.ToString(); if(MainWindow.karambit <= 0)
                    {
                        sprzedaj.IsEnabled = false;
                        sprzedaj.Visibility = Visibility.Hidden;
                    }
                    break;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
