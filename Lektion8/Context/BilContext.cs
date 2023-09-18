using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Lektion8.Context
{
    class BilContext : DbContext
    {
        public BilContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LFEACLO; Initial Catalog=Bil; Integrated Security=SSPI; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bil>().HasData(new Bil[]
            {
                new Bil {BilID = -1, Color = "Red", Manufacturer = "Ford", Plate = "DB12122" }
            });
        }

        public DbSet<Bil> Biler { get; set; }
    }
}
