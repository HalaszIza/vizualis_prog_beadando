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

namespace vizualis_beadando
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFelhasznalo(object sender, RoutedEventArgs e)
        {
            Felhasznalo window1 = new Felhasznalo();
            window1.Show();
        }

        private void OpenFoetelek(object sender, RoutedEventArgs e)
        {
            Foetelek window2 = new Foetelek();
            window2.Show();
        }

        private void OpenHetiAjanlat(object sender, RoutedEventArgs e)
        {
            HetiAjanlat window3 = new HetiAjanlat();
            window3.Show();
        }

        private void OpenOrszagTortai(object sender, RoutedEventArgs e)
        {
            OrszagTortai window4 = new OrszagTortai();
            window4.Show();
        }

        private void OpenSutemenyek(object sender, RoutedEventArgs e)
        {
            Sutemenyek window5 = new Sutemenyek();
            window5.Show();
        }
    }
}
