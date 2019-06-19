using Microsoft.EntityFrameworkCore;
using Reviews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews
{
    public class SiteContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<HorrorReviews> HorrorReviews { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=SiteDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
