using DependecyInjection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependecyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        //se maneja la implementación de esta interfaz desde el program
        private readonly ICountryRepository _countryRepository;
        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        /// DESDE MEMORIA
        [HttpGet]
        public IActionResult Get() //devuelve los paises
        {
            //puedo poner ICountryRepository porque InMemoryRepository implementa esa interfaz
            //ICountryRepository countryRepository = new InMemoryRepository();
            var countryRepository = new InMemoryRepository();
            var countries = countryRepository.GetAll();
            return Ok(countries);
        }

        /// DESDE UN ARCHIVO
        [HttpGet("v2")]
        public IActionResult GetV2()
        {
            var countries = _countryRepository.GetAll();
            return Ok(countries);
        }
    }
}
