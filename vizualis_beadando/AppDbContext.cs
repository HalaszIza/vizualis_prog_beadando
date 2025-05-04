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
        public System.Data.Entity.DbSet<Model.Felhasznalo> Felhasznalok { get; set; }

        public void SaveChanges()
        {
            // Ide jön a mentés logikája (pl. SQL kézzel írt parancsok)
            Console.WriteLine("Adat mentése...");
        }
    }
    
}