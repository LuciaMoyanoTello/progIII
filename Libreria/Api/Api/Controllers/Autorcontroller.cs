using Api.Dtos;
using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Autorcontroller : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;

        public Autorcontroller(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var autores = await _autorRepository.GetAllAsync();
            return Ok(autores);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAutor(AutorDto autorDto)
        {
            Autor autor = new Autor()
            {
                Nombre = autorDto.Nombre,
                FechaNacimiento = autorDto.FechaNacimiento
            };

            var respuesta = await _autorRepository.CreateAutorAsync(autor);
            return Ok(respuesta);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAutor(Autor autor)
        {
            var respuesta = await _autorRepository.UpdateAutorAsync(autor);
            return Ok(respuesta);
        }
    }
}
