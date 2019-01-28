﻿using System;
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
using System.Timers;


namespace Projekt_Semestralny
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            label1.Content = balance.ToString();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            
            
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Window1 po_wylosowaniu = new Window1();
            {
                po_wylosowaniu.Show();
                dispatcherTimer.Stop();
                
            }
        }
        Random rnd = new Random();
        public static float losowanie = 0;
        public static double balance = 5;
        public static float skrzynka = 2;
        public static int ak47 = 0;
        public static int aug = 0;
        public static int bayonet = 0;
        public static int huntsman = 0;
        public static int karambit = 0;
        public static int m4a1 = 0;
        public static int mac10 = 0;
        public static int p250 = 0;
        public static int r8 = 0;
        public static int tec = 0;



        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

        }
       
        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {
            if (balance >= 2)
            {
                losowanie = rnd.Next(0, 1);
                balance -= 2;
                label1.Content = balance.ToString();
                btnChange.IsEnabled = false;

                if (losowanie >= 0 && losowanie <= 100)
                {           
                    MovingImage.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/karambit_lore.png"));      
                    karambit += 1;
                    dispatcherTimer.Start();
                    
                    
                }
                if (losowanie >= 2 && losowanie <= 3)
                {
                    MovingImage.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/bayonet_gammadoppler.png"));
                    bayonet += 1;
                }
                if (losowanie >= 4 && losowanie <= 5)
                {
                    MovingImage.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/hunstam_knife_marble_fade.png"));
                    huntsman += 1;
                }
                if (losowanie >= 6 && losowanie <= 10)
                {
                    MovingImage.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/ak47_the_empress.png"));
                    ak47 += 1;
                }
                if (losowanie >= 11 && losowanie <= 15)
                {
                    MovingImage.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/p250_see_ya_later.png"));
                    p250 += 1;
                }
                if (losowanie >= 16 && losowanie <= 27)
                {
                    MovingImage.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/r8_revolver_llama_cannon.png"));
                    r8 += 1;
                }
                if (losowanie >= 28 && losowanie <= 40)
                {
                    MovingImage.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/m4a1-s_leaded_glass.png"));
                    m4a1 += 1;
                }
                //zwykle 41-100
                if (losowanie >= 41 && losowanie <= 60)
                {
                    MovingImage.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/tec-9_cracked_opal.png"));
                    tec += 1;
                }
                if (losowanie >= 61 && losowanie <= 80)
                {
                    MovingImage.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/aug_tiqua.png"));
                    aug += 1;
                }
                if (losowanie >= 81 && losowanie <= 100)
                {
                    MovingImage.Source = new BitmapImage(new Uri("pack://application:,,,/Projekt Semestralny;component/grafika/mac-10_oceanic.png"));
                    mac10 += 1;
                }
            }
        }
       
    }
}

