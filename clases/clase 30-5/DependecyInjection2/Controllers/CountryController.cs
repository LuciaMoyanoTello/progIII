using DependecyInjection2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DependecyInjection2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        ////DESDE MEMORIA
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var countryRepository = new InMemoryRepository();
            var countries = await countryRepository.GetAllAsync();
            return Ok(countries);
        }
        ////DESDE UN ARCHIVO
        [HttpGet("V2")]
        public async Task<IActionResult> GetV2()
        {
            var countries = await _countryRepository.GetAllAsync();
            return Ok(countries);
        }
    }
}
