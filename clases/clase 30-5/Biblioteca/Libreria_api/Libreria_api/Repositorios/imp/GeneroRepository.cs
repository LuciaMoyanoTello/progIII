using Libreria_api.Context;
using Libreria_api.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Libreria_api.Repositorios.imp
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly Contexto _contexto;

        public GeneroRepository(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<List<Genero>> GetAllAsync()
        {
            return await _contexto.Generos.ToListAsync();
        }

        public async Task<Genero> GetByIdAsync(int id)
        {
            var genero = await _contexto.Generos.FindAsync(id);
            return genero;
        }
    }
}
