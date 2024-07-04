using Api.Dtos;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibroRepository _libroRepository;

        public LibroController(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        [HttpGet("/getAll")]
        public async Task<IActionResult> GetAll()
        {
            var libros = await _libroRepository.GetAllAsync();
            return Ok(libros);
        }

        [HttpPost("/Create")]
        public async Task<IActionResult> Create([FromBody]LibroDto libroDto)
        {
            var libros = await _libroRepository.Create(libroDto);
            return Ok(libros);
        }

        [HttpPut("/Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] LibroDto libroDto)
        {
            var libro = await _libroRepository.Update(libroDto, id);
            return Ok(libro);
        }

        [HttpDelete("/Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var libro = await _libroRepository.Delete(id);
            return Ok(libro);
        }
    }
}
