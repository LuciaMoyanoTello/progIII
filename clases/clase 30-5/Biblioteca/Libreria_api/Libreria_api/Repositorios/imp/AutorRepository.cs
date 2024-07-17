using Libreria_api.Context;
using Libreria_api.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Libreria_api.Repositorios.imp
{
    public class AutorRepository : IAutorRepository
    {
        private readonly Contexto _contexto;

        public AutorRepository(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<List<Autor>> GetAllAsync()
        {
            return await _contexto.Autores.ToListAsync();
        }

        public async Task<Autor> GetByIdAsync(int id)
        {
            var autor = await _contexto.Autores.FindAsync(id);
            return autor;
        }
    }
}
