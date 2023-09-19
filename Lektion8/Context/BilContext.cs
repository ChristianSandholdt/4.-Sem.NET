using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Opgave8_1.Model;

namespace Lektion8.Context
{
    class BilContext : DbContext
    {
        public BilContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-LFEACLO; Initial Catalog=Bil; Integrated Security=SSPI; TrustServerCertificate=true"); // stationær
            //optionsBuilder.UseSqlServer("Data Source=Christian\\SQLEXPRESS; Initial Catalog=Bil; Integrated Security=SSPI; TrustServerCertificate=true"); // bærbar
            optionsBuilder.UseSqlServer("Data Source=CKSA-PC01\\SQLEXPRESS; Initial Catalog=Bil; Integrated Security=SSPI; TrustServerCertificate=true"); //Arbejdsbærbar
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Ejer ejer1 = new Ejer { EjerID = -1, Name = "Martin" };
            Ejer ejer2 = new Ejer { EjerID = -2, Name = "Nehtin" };

            Bil bil1 = new Bil { EjerID = -1, BilID = -1 , Color = "Red", Manufacturer = "Volvo", Plate = "BZ42056"};
            Bil bil2 = new Bil { EjerID = -2, BilID = -2, Color = "Green", Manufacturer = "Audi", Plate = "FG64254" };

            modelBuilder.Entity<Ejer>().HasData(ejer1, ejer2);
            modelBuilder.Entity<Bil>().HasData(bil1, bil2);

        }

        public DbSet<Bil> Biler { get; set; }
        public DbSet<Ejer> Ejere { get; set; }
    }
}
