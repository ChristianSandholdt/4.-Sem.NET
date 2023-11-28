using Microsoft.EntityFrameworkCore;
using OpgaveLektion17.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace OpgaveLektion17.Context
{
    internal class StuderendeContext : DbContext
    {
        public StuderendeContext()
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database created");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Christian\\SQLEXPRESS;Initial Catalog=Studerende;Integrated Security=SSPI; TrustServerCertificate=true");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studerende>().HasData(new Studerende[] {
                new Studerende(1,"Hans"),
                new Studerende(2,"Grethe"),
                new Studerende(3, "Martin"),
            });
        }
        public DbSet<Studerende> Studerende { get; set; }
    }
}
