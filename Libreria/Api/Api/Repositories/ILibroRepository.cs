using Api.Dtos;
using Api.Models;

namespace Api.Repositories
{
    public interface ILibroRepository
    {
        Task<List<Libro>> GetAllAsync();
        Task<Libro> Create(LibroDto libroDto);
        Task<LibroDto> Update(LibroDto libroDto, int id);
        Task<Object> Delete(int id);
    }
}
