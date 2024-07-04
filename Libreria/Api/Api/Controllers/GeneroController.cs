using Api.Dtos;
using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var generos = await _generoRepository.GetAllAsync();
            return Ok(generos);
        }

        [HttpPost]
        public async Task<IActionResult> CreateGenero([FromBody] GeneroDto generoDto)
        {
            Genero genero = new Genero()
            {
                Nombre = generoDto.Nombre
            };

            var respuesta = await _generoRepository.CreateGeneroAsync(genero);
            return Ok(respuesta);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGenero(Genero genero)
        {
            var respuesta = await _generoRepository.UpdateGeneroAsync(genero);
            return Ok(respuesta);
        }
    }
}
