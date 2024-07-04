using Api.Models;

namespace Api.Repositories
{
    public interface IAutorRepository
    {
        Task<List<Autor>> GetAllAsync();
        Task<Autor> CreateAutorAsync(Autor autor);
        Task<Autor> UpdateAutorAsync(Autor autor);
    }
}
