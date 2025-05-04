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
using static Model.Felhasznalo;

namespace vizualis_beadando
{
    /// <summary>
    /// Interaction logic for Felhasznalo.xaml
    /// </summary>
    public partial class Felhasznalo : Window
    {
        //Felhasznalo proba = new Felhasznalo();
        public Felhasznalo()
        {
            InitializeComponent();
        }

        private void bt_Bej(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Kérjük töltse ki a mezőt!");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    var user = context.Felhasznalok.FirstOrDefault(u => u.felhasznalo_n == username);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }
        }

        private void bt_Reg(object sender, RoutedEventArgs e)
        {
            string username = txtRegUsername.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Kérjük töltse ki a mezőt!");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    // Ellenőrizzük, hogy létezik-e már a felhasználó
                    if (context.Felhasznalok.Any(u => u.felhasznalo_n == username))
                    {
                        MessageBox.Show("Ez a felhasználónév már foglalt!");
                        return;
                    }

                    // Új felhasználó létrehozása
                    var newFelhasznalo = new Model.Felhasznalo
                    {
                        felhasznalo_n = username,
                    };

                    context.Felhasznalok.Add(newFelhasznalo);
                    context.SaveChanges();

                    MessageBox.Show("Sikeres regisztráció! elkezdheti a barangolást csodást receptjeink között.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }
        }
        private void mi_Főoldal_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}