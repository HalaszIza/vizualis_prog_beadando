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
            k_recept.Text = "Hozzávalók:";
            k_recept.Visibility = Visibility.Visible;

            var k_lista = new List<string> { "1 kg finomliszt", "800 g tisztított burgonya", "50 g élesztő", "200 g teavaj",
                "200 g sertészsír", "50 g só", "3 db tojásnak a sárgája", "1.5 % tej 150 ml", "1 db egész tojás a kenéshez" };
            k_hozzavalok.ItemsSource = k_lista;
            k_hozzavalok.Visibility = Visibility.Visible;

            var uri = new Uri("Images/Etelek/kep_04.png");
            krumplis_pogi.Source = new BitmapImage(uri);
            krumplis_pogi.Visibility = Visibility.Visible;

        }

        private void macaron_Bt(object sender, RoutedEventArgs e)
        {
            m_recept.Text = "Hozzávalók:";
            m_recept.Visibility = Visibility.Visible;

            var m_lista = new List<string> { "Csokoládéganache-hoz:", "180 g étcsokoládé (két tábla)", "150 ml habtejszín (ha egy picivel több, az sem baj)",
                "Macarontésztához:", "150 g mandulaliszt", "170 g porcukor", "1 csipet só", "3 csepp ételfesték (piros)", 
                "csepp vaníliaaroma", "120 g tojásfehérje (4 M-es tojásból)", "120 g cukor" };
            m_hozzavalok.ItemsSource = m_lista;
            m_hozzavalok.Visibility = Visibility.Visible;

            var uri = new Uri("Images/Etelek/macaron.jpg");
            macaron.Source = new BitmapImage(uri);
            macaron.Visibility = Visibility.Visible;

        }

        private void malnas_Bt(object sender, RoutedEventArgs e)
        {
            mrp_recept.Text = "Hozzávalók:";
            mrp_recept.Visibility = Visibility.Visible;

            var k_lista = new List<string> { "Tésztához:", "4 db L-es tojás", "10 dkg eritrit (édesítő)", "1 kávéskanál sütőpor",
                "8 dkg liszt", "Málnakrémhez:", "30 dkg málna", "2 dl víz", "15 dkg eritrit", "40 g vaníliás pudingpor",
                "Tejszínhez:", "5 dl habtejszín", "5 dkg eritrit", "20 g habfixáló", "10 dkg málna a díszítéshez" };
            mrp_hozzavalok.ItemsSource = k_lista;
            mrp_hozzavalok.Visibility = Visibility.Visible;

            var uri = new Uri("Images/Etelek/malnastejszínhabos.jpg");
            meggyesr_pite.Source = new BitmapImage(uri);
            meggyesr_pite.Visibility = Visibility.Visible;

        }

        private void meggyes_Bt(object sender, RoutedEventArgs e)
        {
            k_recept.Text = "Hozzávalók:";
            k_recept.Visibility = Visibility.Visible;

            var k_lista = new List<string> { "Tésztához:", "500 g finomliszt", "1 evőkanál sütőpor", "120 g porcukor",
                "200 g vaj", "2 ek tejföl", "1 db tojás", "0.5 citromból nyert citromhéj", "1 csipet só", "Töltelékhez:",
                "350 g meggy", "100 g cukor", "1 teáskanál fahéj", "Összeállításhoz:", "2 evőkanál vaj", "2 evőkanál zsemlemorzsa",
                "2 csapott evőkanál búzadara", "2 marék dió (darált)", "1 db tojás" };
            k_hozzavalok.ItemsSource = k_lista;
            k_hozzavalok.Visibility = Visibility.Visible;

            var uri = new Uri("Images/Etelek/meggyespite.jpg");
            krumplis_pogi.Source = new BitmapImage(uri);
            krumplis_pogi.Visibility = Visibility.Visible;

        }

        private void pizzas_Bt(object sender, RoutedEventArgs e)
        {
            k_recept.Text = "Hozzávalók:";
            k_recept.Visibility = Visibility.Visible;

            var k_lista = new List<string> { "Tésztához:", "60 dkg finomliszt", "3 dl langyos 2.8 % tej", 
                "4-5 dkg élesztő", "10 dkg vaj vagy margarin", "só", "1 db egész tojás", "Szószhoz:", 
                "2 db kisebb vöröshagyma", "2 - 3 dl ketchup", "10-15 dkg kolozsvári szalonna", "10-15 dkg gépsonka", 
                "oregánó", "bazsalikom", "rozmaring ízlés szerint", "só", "őrölt fehér bors", "10-12 dkg reszelni való sajt" };
            k_hozzavalok.ItemsSource = k_lista;
            k_hozzavalok.Visibility = Visibility.Visible;

            var uri = new Uri("Images/Etelek/kep_03.png");
            krumplis_pogi.Source = new BitmapImage(uri);
            krumplis_pogi.Visibility = Visibility.Visible;

        }

        private void sajtos_Bt(object sender, RoutedEventArgs e)
        {
            k_recept.Text = "Hozzávalók:";
            k_recept.Visibility = Visibility.Visible;

            var k_lista = new List<string> { "350 g finomliszt", "250 g teavaj", "200 g Szarvasi Perfetto sajt amiből 130g a tésztába 70 g a sós sütemény tetejére",
                "2 db egész tojás a tésztába", "1 db egésztojás a kenéshez", "1 teáskanál só a tésztába és egy erős csipet kenésnél a tojásba", 
                "1 evőkanál 20 % tejfel", "ízlés szerinti kömény mennyiség" };
            k_hozzavalok.ItemsSource = k_lista;
            k_hozzavalok.Visibility = Visibility.Visible;

            var uri = new Uri("Images/Etelek/kep_05.png");
            krumplis_pogi.Source = new BitmapImage(uri);
            krumplis_pogi.Visibility = Visibility.Visible;

        }

        private void somloi_Bt(object sender, RoutedEventArgs e)
        {
            k_recept.Text = "Hozzávalók:";
            k_recept.Visibility = Visibility.Visible;

            var k_lista = new List<string> { "Krémhez:", "1 l tej", "3 csomag vaníliás cukor", "9 evőkanál cukor", 
                "4 evőkanál kakaó", "4 evőkanál liszt", "10 dkg margarin", "Piskótához:", "6 db tojás", "180g cukor",
                "3 evőkanál napraforgó olaj", "150 g liszt", "1.5 teáskanál sütőpor", "1 csipet só" };
            k_hozzavalok.ItemsSource = k_lista;
            k_hozzavalok.Visibility = Visibility.Visible;

            var uri = new Uri("Images/Etelek/somloi.jpg");
            krumplis_pogi.Source = new BitmapImage(uri);
            krumplis_pogi.Visibility = Visibility.Visible;

        }

        private void sos_Bt(object sender, RoutedEventArgs e)
        {
            k_recept.Text = "Hozzávalók:";
            k_recept.Visibility = Visibility.Visible;

            var k_lista = new List<string> { "1/2 kg finomliszt", "25 dkg teavaj", "2 dl habtejszín vagy 2 dl 20 % tejfel",
                "só ízlés szerint", "2 db tojás sárgája", "1 egész tojás a kenéshez", "10-15 dkg sajt a tésztába",
                "szóráshoz ismételten reszelt sajt ízlés szerint és egész kömény (elhagyható)" };
            k_hozzavalok.ItemsSource = k_lista;
            k_hozzavalok.Visibility = Visibility.Visible;

            var uri = new Uri("Images/Etelek/kep_02.png");
            krumplis_pogi.Source = new BitmapImage(uri);
            krumplis_pogi.Visibility = Visibility.Visible;

        }

        private void mi_Főoldal_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
