using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _10._02.Models.Data
{
    class MyDatabase : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Engineer> Engineers { get; set; }

        public MyDatabase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NMFVIJJ;Database=medical;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        private static MyDatabase? instance;
        public static MyDatabase getInstance()
        {
            if (instance == null)
            {
                instance = new MyDatabase();
                //instance.Database.EnsureDeleted();
                //var exists = instance.Database.EnsureCreated();

                instance.Clients.Load();
                instance.Engineers.Load();
                instance.Requests.Load();
                instance.Equipments.Load();

                instance.SaveChanges();
            }
            return instance;
        }
    }
}
