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
using Microsoft.EntityFrameworkCore;
using static Model.Felhasznalo;
using vizualis_beadando.Data;
using Model;
using System.Windows.Controls.Primitives;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace vizualis_beadando
{
    /// <summary>
    /// Interaction logic for Felhasznalo.xaml
    /// </summary>
    public partial class Felhasznalo : Window
    {
        private Felhasznalo bejelentkezettFelhasznalo;

        //NEW
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long f_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string felhasznalo_n { get; set; }

        // Külső kulcsok nullable-vé tétele
        public long? Foetelekf_id { get; set; }
        public long? s_id { get; set; }
        public long? t_id { get; set; }

        // Navigációs tulajdonságok
        public virtual Foetelek Foetelek { get; set; }
        public virtual Sutemenyek Sutemenyek { get; set; }
        public virtual Tortak Tortak { get; set; }

        //NEW END

        public Felhasznalo()
        {
            InitializeComponent();
            statusBar.Visibility = Visibility.Collapsed;
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
                        f_kedvenc_id = 0,
                        s_kedvenc_id = 0,
                        t_kedvenc_id = 0
                    };

                    context.Felhasznalok.Add(newFelhasznalo);
                    context.SaveChanges();
                    MessageBox.Show("Sikeres regisztráció!");

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