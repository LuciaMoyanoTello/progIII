using Api.Context;
using Api.Dtos;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories.imp
{
    public class LibroRepository : ILibroRepository
    {
        private readonly Contexto _contexto;

        public LibroRepository(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<Libro> Create(LibroDto libroDto)
        {
            Libro libro = new Libro()
            {
                Titulo = libroDto.Titulo,
                IdAutor = libroDto.IdAutor,
                FechaPublicacion = libroDto.FechaPublicacion,
                IdGenero = libroDto.IdGenero

            };
            await _contexto.Libro.AddAsync(libro);
            await _contexto.SaveChangesAsync();
            return libro;
        }

        public async Task<object> Delete(int id)
        {
            var libro = await _contexto.Libro.FindAsync(id);
            _contexto.Libro.Remove(libro);
            await _contexto.SaveChangesAsync();
            return libro;
        }

        public async Task<List<Libro>> GetAllAsync()
        {
            return await _contexto.Libro.Include(x => x.Autor).Include(x => x.Genero).ToListAsync();
        }

        public async Task<LibroDto> Update(LibroDto libroDto, int id)
        {
            var libroExistente = await _contexto.Libro.FindAsync(id);
            libroExistente.IdAutor = libroDto.IdAutor;
            libroExistente.IdGenero = libroDto.IdGenero;
            libroExistente.Titulo = libroDto.Titulo;
            libroExistente.FechaPublicacion = libroDto.FechaPublicacion;
            await _contexto.SaveChangesAsync();
            return libroDto;
        }
    }
}
