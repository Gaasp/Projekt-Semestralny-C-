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
        Window2 dodaj = new Window2();
        
        public Window1()
        {
            InitializeComponent();
            
        }
        
       
        private void Zamknij_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
           
            if (MainWindow.balance <=1)
            {
                dodaj.Show();
              
            }
            
        }
    }
}
