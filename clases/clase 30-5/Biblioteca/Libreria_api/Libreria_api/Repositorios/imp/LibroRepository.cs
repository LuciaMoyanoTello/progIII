using Libreria_api.Context;
using Libreria_api.Dto;
using Libreria_api.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Libreria_api.Repositorios.imp
{
    public class LibroRepository : ILibroRepository
    {
        private readonly Contexto _contexto;

        public LibroRepository(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<Libro> CreateAsync(LibroDto libroDto)
        {
            Libro libro = new Libro()
            {
                Nombre = libroDto.Nombre,
                IdAutor = libroDto.IdAutor,
                IdGenero = libroDto.IdGenero
            };
            await _contexto.Libros.AddAsync(libro);
            await _contexto.SaveChangesAsync();
            return libro;
        }

        public async Task<object> DeleteAsync(int id)
        {
            var libroBorrar = await _contexto.Libros.FindAsync(id);
            _contexto.Libros.Remove(libroBorrar);

            await _contexto.SaveChangesAsync();
            return libroBorrar;
        }

        public async Task<List<Libro>> GetAllAsync()
        {
            return await _contexto.Libros.Include(x => x.Autor).Include(x => x.Genero).ToListAsync();
        }

        public async Task<Libro> GetByIdAsync(int id)
        {
            var libro = await _contexto.Libros.FindAsync(id);
            return libro;
        }

        public async Task<LibroDto> UpdateAsync(int id, LibroDto libroDto)
        {
            var libroExistente = await _contexto.Libros.FindAsync(id);
            libroExistente.IdAutor = libroDto.IdAutor;
            libroExistente.IdGenero = libroDto.IdGenero;
            libroExistente.Nombre = libroDto.Nombre;

            await _contexto.SaveChangesAsync();
            return libroDto;
        }
    }
}
