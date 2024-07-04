using Api.Context;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories.imp
{
    public class AutorRepository : IAutorRepository
    {
        private readonly Contexto _contexto;

        public AutorRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<Autor> CreateAutorAsync(Autor autor)
        {
            await _contexto.Autor.AddAsync(autor);
            await _contexto.SaveChangesAsync();
            return autor;
        }

        public async Task<List<Autor>> GetAllAsync()
        {
            return await _contexto.Autor.ToListAsync();
        }

        public async Task<Autor> UpdateAutorAsync(Autor autor)
        {
            var autorExistente = await _contexto.Autor.FindAsync(autor.Id);
            autorExistente.Nombre = autor.Nombre;
            autorExistente.FechaNacimiento = autor.FechaNacimiento;
            return autorExistente;
        }
    }
}
