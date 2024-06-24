using DependecyInjection.Domain;
using Microsoft.EntityFrameworkCore;

namespace DependecyInjection.Context
{
    public class CountryDbContext : DbContext
    {
        public CountryDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = "1", Nombre = "Argentina" },
                new Country { Id = "2", Nombre = "Francia" },
                new Country { Id = "3", Nombre = "Brasil" },
                new Country { Id = "4", Nombre = "Chile" },
                new Country { Id = "5", Nombre = "Paraguay" });
        }
        //es para acceder
        public DbSet<Country> Countries { get; set; }
    }
}
