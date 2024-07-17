using Libreria_api.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Libreria_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;

        public AutorController(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        [HttpGet("/TodosAutores")]
        public async Task<IActionResult> GetAutores()
        {
            var respuesta = await _autorRepository.GetAllAsync();
            return Ok(respuesta);
        }

        [HttpGet("/AutorPorId")]
        public async Task<IActionResult> GetAutorPorId(int id)
        {
            var respuesta = await _autorRepository.GetByIdAsync(id);
            return Ok(respuesta);
        }
    }
}
