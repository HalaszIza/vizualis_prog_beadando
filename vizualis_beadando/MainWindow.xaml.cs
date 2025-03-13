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

        private void OpenHetiWindow(object sender, RoutedEventArgs e)
        {
            HetiAjanlat objHetiAjanlat = new HetiAjanlat();
            this.Visibility = Visibility.Hidden;
            objHetiAjanlat.Show();
        }

        private void OpenFelhasznalo(object sender, RoutedEventArgs e)
        {
            Felhasznalo objFelhasznalo = new Felhasznalo();
            this.Visibility = Visibility.Hidden;
            objFelhasznalo.Show();
        }

        private void OpenFoetelek(object sender, RoutedEventArgs e)
        {
            Foetelek objFoetelek = new Foetelek();
            this.Visibility = Visibility.Hidden;
            objFoetelek.Show();
        }

        private void OpenSutemenyek(object sender, RoutedEventArgs e)
        {
            Sutemenyek objSutemenyek = new Sutemenyek();
            this.Visibility = Visibility.Hidden;
            objSutemenyek.Show();
        }

        private void OpenOrszagTortai(object sender, RoutedEventArgs e)
        {
            OrszagTortai objOrszagTortai = new OrszagTortai();
            this.Visibility = Visibility.Hidden;
            objOrszagTortai.Show();
        }
    }
}
