using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
using static Model.Felhasznalo;
using vizualis_beadando;
using Model;

namespace vizualis_beadando.Data
{
    public class AppDbContext : System.Data.Entity.DbContext, IDisposable
    {
        public DbSet<Felhasznalo> Felhasznalok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=VizualisBeadandoDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Felhasznalo>(entity =>
            {
                entity.ToTable("Felhasznalok"); // Explicit táblanév
                entity.HasKey(e => e.f_id); // Elsődleges kulcs
                entity.Property(e => e.felhasznalo_n).IsRequired();

            });
        }
    }
}