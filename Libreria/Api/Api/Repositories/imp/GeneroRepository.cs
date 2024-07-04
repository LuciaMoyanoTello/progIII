using Api.Context;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories.imp
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly Contexto _contexto;

        public GeneroRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<Genero> CreateGeneroAsync(Genero genero)
        {
            await _contexto.Genero.AddAsync(genero);
            await _contexto.SaveChangesAsync();
            return genero;
        }

        public async Task<List<Genero>> GetAllAsync()
        {
            return await _contexto.Genero.ToListAsync();
        }

        public async Task<Genero> UpdateGeneroAsync(Genero genero)
        {
            var generoExistente = await _contexto.Genero.FindAsync(genero.Id);
            generoExistente.Nombre = genero.Nombre;

            await _contexto.SaveChangesAsync();
            return generoExistente;
        }
    }
}
