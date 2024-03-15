using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieTrackerApp;
using Microsoft.EntityFrameworkCore;

  
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-JO1FE5G4;Initial Catalog=calories_tracker_db;Integrated Security=True;Trust Server Certificate=True");
        }
    }

