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
using System.Windows.Shapes;


namespace Projekt_Semestralny
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            if (MainWindow.losowanie >= 0 && MainWindow.losowanie <= 1)
            {

            }
            int test = 0;
        }

       
        private void Zamknij_Click(object sender, RoutedEventArgs e)
        {
            
            if(MainWindow.losowanie >=0 && MainWindow.losowanie <=1)
            {

            }
        }
    }
}