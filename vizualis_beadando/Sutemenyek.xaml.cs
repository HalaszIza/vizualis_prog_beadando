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
    /// Interaction logic for Sutemenyek.xaml
    /// </summary>
    public partial class Sutemenyek : Window
    {
        public Sutemenyek()
        {
            InitializeComponent();
        }

        private void krumplis_Bt(object sender, RoutedEventArgs e)
        {            
            k_hozzavalok.Visibility = Visibility.Visible;
            k_elkeszites.Visibility = Visibility.Visible;
            Krumplis_pogi.Visibility = Visibility.Visible;
        }

         private void macaron_Bt(object sender, RoutedEventArgs e)
        {         
            m_hozzavalok.Visibility = Visibility.Visible;
            m_elkeszites.Visibility = Visibility.Visible;
            macaron.Visibility = Visibility.Visible;

        }

        private void malnas_Bt(object sender, RoutedEventArgs e)
        {           
            mtk_hozzavalok.Visibility = Visibility.Visible;
            mtk_elkeszites.Visibility = Visibility.Visible;
            mt_kocka.Visibility = Visibility.Visible;

        }

        private void meggyes_Bt(object sender, RoutedEventArgs e)
        {                        
            mrp_hozzavalok.Visibility = Visibility.Visible;
            mrp_elkeszites.Visibility = Visibility.Visible;
            meggyesr_pite.Visibility = Visibility.Visible;

        }

        private void pizzas_Bt(object sender, RoutedEventArgs e)
        {                  
            p_hozzavalok.Visibility = Visibility.Visible;      
            p_elkeszites.Visibility = Visibility.Visible;       
            pizzas_csigusz.Visibility = Visibility.Visible;

        }

        private void sajtos_Bt(object sender, RoutedEventArgs e)
        {
            sr_hozzavalok.Visibility = Visibility.Visible;
            sr_elkeszites.Visibility = Visibility.Visible;
            sajtos_ropi.Visibility = Visibility.Visible;

        }

        private void somloi_Bt(object sender, RoutedEventArgs e)
        {
            sg_hozzavalok.Visibility = Visibility.Visible;
            sg_elkeszites.Visibility = Visibility.Visible;
            somloi.Visibility = Visibility.Visible;

        }

        private void sos_Bt(object sender, RoutedEventArgs e)
        {            
            sa_hozzavalok.Visibility = Visibility.Visible;
            sa_elkeszites.Visibility = Visibility.Visible;
            sos_apro.Visibility = Visibility.Visible;

        }
                
        private void mi_Főoldal_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Uj_suti(object sender, RoutedEventArgs e)
        {
            if (Button_sum1.Visibility == Visibility.Visible)
            {
                k_hozzavalok.Visibility = Visibility.Collapsed;
                k_elkeszites.Visibility = Visibility.Collapsed;
                Krumplis_pogi.Visibility = Visibility.Collapsed;
            }

            if (Button_sum2.Visibility == Visibility.Visible)
            {
                m_hozzavalok.Visibility = Visibility.Collapsed;
                m_elkeszites.Visibility = Visibility.Collapsed;
                macaron.Visibility = Visibility.Collapsed;
            }

            if (Button_sum3.Visibility == Visibility.Visible)
            {
                mtk_hozzavalok.Visibility = Visibility.Collapsed;
                mtk_elkeszites.Visibility = Visibility.Collapsed;
                mt_kocka.Visibility = Visibility.Collapsed;
            }

            if (Button_sum4.Visibility == Visibility.Visible)
            {
                mrp_hozzavalok.Visibility = Visibility.Collapsed;
                mrp_elkeszites.Visibility = Visibility.Collapsed;
                meggyesr_pite.Visibility = Visibility.Collapsed;
            }

            if (Button_sum5.Visibility == Visibility.Visible)
            {
                p_hozzavalok.Visibility = Visibility.Collapsed;
                p_elkeszites.Visibility = Visibility.Collapsed;
                pizzas_csigusz.Visibility = Visibility.Collapsed;
            }

            if (Button_sum6.Visibility == Visibility.Visible)
            {
                sr_hozzavalok.Visibility = Visibility.Collapsed;
                sr_elkeszites.Visibility = Visibility.Collapsed;
                sajtos_ropi.Visibility = Visibility.Collapsed;
            }

            if (Button_sum7.Visibility == Visibility.Visible)
            {
                sg_hozzavalok.Visibility = Visibility.Collapsed;
                sg_elkeszites.Visibility = Visibility.Collapsed;
                somloi.Visibility = Visibility.Collapsed;
            }

            if (Button_sum8.Visibility == Visibility.Visible)
            {
                sa_hozzavalok.Visibility = Visibility.Collapsed;
                sa_elkeszites.Visibility = Visibility.Collapsed;
                sos_apro.Visibility = Visibility.Collapsed;
            }

        }
    }
}
