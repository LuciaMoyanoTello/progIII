using Libreria_api.Dto;
using Libreria_api.Entidades;

namespace Libreria_api.Repositorios
{
    public interface ILibroRepository
    {
        Task<List<Libro>> GetAllAsync();
        Task<Libro> GetByIdAsync(int id);
        Task<Libro> CreateAsync(LibroDto libroDto);
        Task<LibroDto> UpdateAsync(int id, LibroDto libroDto);
        Task<Object> DeleteAsync(int id);
    }
}
