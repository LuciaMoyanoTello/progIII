using Libreria_api.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Libreria_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroRepository _generoRepository;

        public GeneroController(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }

        [HttpGet("/TodosGeneros")]
        public async Task<IActionResult> GetGeneros()
        {
            var respuesta = await _generoRepository.GetAllAsync();
            return Ok(respuesta);
        }

        [HttpGet("/GeneroPorId")]
        public async Task<IActionResult> GeneroPorId(int id)
        {
            var respuesta = await _generoRepository.GetByIdAsync(id);
            return Ok(respuesta);
        }
    }
}
