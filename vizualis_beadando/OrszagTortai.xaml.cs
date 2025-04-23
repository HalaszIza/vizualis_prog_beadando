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
    /// Interaction logic for OrszagTortai.xaml
    /// </summary>
    public partial class OrszagTortai : Window
    {
        public OrszagTortai()
        {
            InitializeComponent();
        }
        private void mi_Főoldal_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
