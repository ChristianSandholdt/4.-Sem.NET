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
        public Ejer e = new Ejer("Martin");
        public BilContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-LFEACLO; Initial Catalog=Bil; Integrated Security=SSPI; TrustServerCertificate=true"); // stationær
            optionsBuilder.UseSqlServer("Data Source=Christian\\SQLEXPRESS; Initial Catalog=Bil; Integrated Security=SSPI; TrustServerCertificate=true"); // bærbar
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ejer>().HasData(new Ejer[]
{
                new Ejer {EjerID = -1, Name = "Martin"}

});
            modelBuilder.Entity<Bil>().HasData(new Bil[]
            {
                new Bil {BilID = -1, Color = "Red", Manufacturer = "Ford", Plate = "DB12122", EjerID = 1}
            });

        }

        public DbSet<Bil> Biler { get; set; }
        public DbSet<Ejer> Ejere { get; set; }
    }
}
