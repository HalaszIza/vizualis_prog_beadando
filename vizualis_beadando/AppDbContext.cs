using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using vizualis_beadando;

namespace vizualis_beadando.Data
{
    public class AppDbContext : DbContext
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
                entity.Property(e => e.f_id)
              .ValueGeneratedOnAdd();

            });
        }
    }
}
