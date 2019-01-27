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
using System.Timers;


namespace Projekt_Semestralny
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
            if(balance>=2)
            {
                losowanie = rnd.Next(0, 100);
                balance -=2;

                //pokazac balance

            if(losowanie >= 0 && losowanie <= 1)
                {
                    //obrazek karambitu
                    karambit += 1;
                }
            if(losowanie >=2 && losowanie <= 3)
                {
                    //obrazek bayonet_gammadoppler.png
                    bayonet += 1;
                }
            if(losowanie >=4 && losowanie <=5)
                {
                    //obrazek hunstam_knife_marble_fade.png
                    huntsman += 1;
                }
            if(losowanie >=6 && losowanie<=10)
                {
                    //obrazek ak47_the_empress.png
                    ak47 += 1;
                }
            if(losowanie >=11 && losowanie <=15)
                {
                    //obrazek p250_see_ya_later.png
                    p250 += 1;
                }
            if(losowanie >=16 && losowanie <=27)
                {
                    //obrazek r8_revolver_llama_cannon.png
                    r8 += 1;
                }
            if (losowanie >= 28 && losowanie <= 40)
                {
              //obrazek m4a1-s_leaded_glass.png
                m4a1 += 1;
                }

            //zwykle 41-100
            if (losowanie >= 41 && losowanie <= 60)
                {
               //obrazektec-9_cracked_opal.png
                tec += 1;
                }
            if (losowanie >= 61 && losowanie <= 80)
                {
               //obrazek grafika/aug_tiqua.png
                aug += 1;
                }
            if (losowanie >= 81 && losowanie <= 100)
                {
               //obrazek mac-10_oceanic.png
                mac10 += 1;
                }
            }
        }
    }
}

