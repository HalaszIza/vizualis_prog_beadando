using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static Model.Felhasznalo;
using vizualis_beadando;
using Model;
using Microsoft.EntityFrameworkCore;

namespace vizualis_beadando.Data
{
    public class AppDbContext : System.Data.Entity.DbContext, IDisposable
    {
        public System.Data.Entity.DbSet<Model.Felhasznalo> Felhasznalok { get; set; }

        public void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ReceptKonyvDB;Trusted_Connection=True;");
        }

        public void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Felhasznalo>()
                .HasKey(f => f.f_id);

            modelBuilder.Entity<Felhasznalo>()
                .Property(f => f.f_id)
                .ValueGeneratedOnAdd();

            // Kapcsolatok konfigurálása RESTRICT módban
            modelBuilder.Entity<Felhasznalo>()
                .HasOne(f => f.Foetelek)
                .WithMany()
                .HasForeignKey(f => f.Foetelekf_id)
                .OnDelete(DeleteBehavior.Restrict); // <- IDE ÍRJUK BE

            modelBuilder.Entity<Felhasznalo>()
                .HasOne(f => f.Sutemenyek)
                .WithMany()
                .HasForeignKey(f => f.s_id)
                .OnDelete(DeleteBehavior.Restrict); // <- IDE ÍRJUK BE

            modelBuilder.Entity<Felhasznalo>()
                .HasOne(f => f.Tortak)
                .WithMany()
                .HasForeignKey(f => f.t_id)
                .OnDelete(DeleteBehavior.Restrict); // <- IDE ÍRJUK BE

            // További táblák konfigurálása
            modelBuilder.Entity<Model.Foetelek>(entity =>
            {
                entity.HasKey(e => e.f_id);
            });

            modelBuilder.Entity<Model.Sutemenyek>(entity =>
            {
                entity.HasKey(e => e.s_id);
            });

            modelBuilder.Entity<Model.Tortak>(entity =>
            {
                entity.HasKey(e => e.t_id);
            });
        }

        public void SaveChanges()
        {
            // Ide jön a mentés logikája (pl. SQL kézzel írt parancsok)
            Console.WriteLine("Adat mentése...");
        }
    }
    
}