using Libreria_api.Dto;
using Libreria_api.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Libreria_api.Controllers
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

        [HttpGet("/TodosLibros")]
        public async Task<IActionResult> GetLibros()
        {
            var respuesta = await _libroRepository.GetAllAsync();
            return Ok(respuesta);
        }

        [HttpGet("/LibrosPorId")]
        public async Task<IActionResult> GetPorId(int id)
        {
            var respuesta = await _libroRepository.GetByIdAsync(id);
            return Ok(respuesta);
        }

        [HttpPost("/Crear")]
        public async Task<IActionResult> CrearLibro([FromBody]LibroDto libroDto)
        {
            var respuesta = await _libroRepository.CreateAsync(libroDto);
            return Ok(respuesta);
        }

        [HttpPut("/Actualizar")]
        public async Task<IActionResult> AutualizarLibro(int id, [FromBody]LibroDto libroDto)
        {
            var respuesta = await _libroRepository.UpdateAsync(id, libroDto);
            return Ok(respuesta);
        }

        [HttpDelete("/Eliminar")]
        public async Task<IActionResult> EliminarLibro(int id)
        {
            var respuesta = await _libroRepository.DeleteAsync(id);
            return Ok(respuesta);
        }
    }
}
