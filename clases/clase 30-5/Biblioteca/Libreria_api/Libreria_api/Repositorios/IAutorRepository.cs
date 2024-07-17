using Libreria_api.Entidades;

namespace Libreria_api.Repositorios
{
    public interface IAutorRepository
    {
        Task<List<Autor>> GetAllAsync();
        Task<Autor> GetByIdAsync(int id);
    }
}
