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

namespace vizualis_beadando
{
    /// <summary>
    /// Interaction logic for Foetelek.xaml
    /// </summary>
    public partial class Foetelek : Window
    {
        public Foetelek()
        {
            InitializeComponent();
        }

        private void carbon_Bt(object sender, RoutedEventArgs e)
        {
            carbon_hozzavalok.Visibility = Visibility.Visible;
            carbon_elkeszites.Visibility = Visibility.Visible;
            carb.Visibility = Visibility.Visible;
        }

        private void fozelek_Bt(object sender, RoutedEventArgs e)
        {
            tokfozelek_hozzavalok.Visibility = Visibility.Visible;
            tokfozelek_elkeszites.Visibility = Visibility.Visible;
            Tokfozelek.Visibility = Visibility.Visible;

        }

        private void teszta_Bt(object sender, RoutedEventArgs e)
        {
            teszta_hozzavalok.Visibility = Visibility.Visible;
            teszta_elkeszites.Visibility = Visibility.Visible;
            Teszta.Visibility = Visibility.Visible;


        }

        private void chilis_Bt(object sender, RoutedEventArgs e)
        {
            chilis_hozzavalok.Visibility = Visibility.Visible;
            chilis_elkeszites.Visibility = Visibility.Visible;
            Chilisbab.Visibility = Visibility.Visible;

        }

        private void lasagne_Bt(object sender, RoutedEventArgs e)
        {
            lasagne_hozzavalok.Visibility = Visibility.Visible;
            lasagne_elkeszites.Visibility = Visibility.Visible;
            Lasagne.Visibility = Visibility.Visible;

        }

        private void paprikas_Bt(object sender, RoutedEventArgs e)
        {
            paprikas_hozzavalok.Visibility = Visibility.Visible;
            paprikas_elkeszites.Visibility = Visibility.Visible;
            paprikas_krumpli.Visibility = Visibility.Visible;

        }

        private void burger_Bt(object sender, RoutedEventArgs e)
        {
            burger_hozzavalok.Visibility = Visibility.Visible;
            burger_elkeszites.Visibility = Visibility.Visible;
            csirkeburger.Visibility = Visibility.Visible;

        }

        private void bolog_Bt(object sender, RoutedEventArgs e)
        {
            bolog_hozzavalok.Visibility = Visibility.Visible;
            bolog_elkeszites.Visibility = Visibility.Visible;
            bolognai.Visibility = Visibility.Visible;

        }



        private void mi_Főoldal_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Uj_etel(object sender, RoutedEventArgs e)
        {
            if (Button_sum1.Visibility == Visibility.Visible)
            {
                carbon_hozzavalok.Visibility = Visibility.Collapsed;
                carbon_elkeszites.Visibility = Visibility.Collapsed;
                carb.Visibility = Visibility.Collapsed;
            }

            if (Button_sum2.Visibility == Visibility.Visible)
            {
                tokfozelek_hozzavalok.Visibility = Visibility.Collapsed;
                tokfozelek_elkeszites.Visibility = Visibility.Collapsed;
                Tokfozelek.Visibility = Visibility.Collapsed;
            }

            if (Button_sum3.Visibility == Visibility.Visible)
            {
                teszta_hozzavalok.Visibility = Visibility.Collapsed;
                teszta_elkeszites.Visibility = Visibility.Collapsed;
                Teszta.Visibility = Visibility.Collapsed;
            }

            if (Button_sum4.Visibility == Visibility.Visible)
            {
                chilis_hozzavalok.Visibility = Visibility.Collapsed;
                chilis_elkeszites.Visibility = Visibility.Collapsed;
                Chilisbab.Visibility = Visibility.Collapsed;
            }

            if (Button_sum5.Visibility == Visibility.Visible)
            {
                lasagne_hozzavalok.Visibility = Visibility.Collapsed;
                lasagne_elkeszites.Visibility = Visibility.Collapsed;
                Lasagne.Visibility = Visibility.Collapsed;
            }

            if (Button_sum6.Visibility == Visibility.Visible)
            {
                paprikas_hozzavalok.Visibility = Visibility.Collapsed;
                paprikas_elkeszites.Visibility = Visibility.Collapsed;
                paprikas_krumpli.Visibility = Visibility.Collapsed;
            }

            if (Button_sum7.Visibility == Visibility.Visible)
            {
                burger_hozzavalok.Visibility = Visibility.Collapsed;
                burger_elkeszites.Visibility = Visibility.Collapsed;
                csirkeburger.Visibility = Visibility.Collapsed;
            }

            if (Button_sum8.Visibility == Visibility.Visible)
            {
                bolog_hozzavalok.Visibility = Visibility.Collapsed;
                bolog_elkeszites.Visibility = Visibility.Collapsed;
                bolognai.Visibility = Visibility.Collapsed;
            }

        }


    }
}
