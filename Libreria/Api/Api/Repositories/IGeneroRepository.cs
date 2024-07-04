using Api.Models;

namespace Api.Repositories
{
    public interface IGeneroRepository
    {
        Task<List<Genero>> GetAllAsync();
        Task<Genero> CreateGeneroAsync(Genero genero);
        Task<Genero> UpdateGeneroAsync(Genero genero);
    }
}
