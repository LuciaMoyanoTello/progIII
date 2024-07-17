using Libreria_api.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Libreria_api.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}
