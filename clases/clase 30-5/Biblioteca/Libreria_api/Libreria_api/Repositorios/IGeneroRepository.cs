using Libreria_api.Entidades;

namespace Libreria_api.Repositorios
{
    public interface IGeneroRepository
    {
        Task<List<Genero>> GetAllAsync();
        Task<Genero> GetByIdAsync(int id);
    }
}
