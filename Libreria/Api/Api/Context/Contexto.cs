using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Genero> Genero { get; set; }
    }
}
