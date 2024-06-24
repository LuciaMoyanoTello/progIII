using DependecyInjection.Domain;
using Newtonsoft.Json;

namespace DependecyInjection.Repositories
{
    public class FileCountryRepository : ICountryRepository
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileCountryRepository(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public List<Country> GetAll()
        {
            //CONTIENE LA RUTA DE DONDE ESTOY PARADO
            //RUTA DEL PROYECTO DONDE ESTÁ CORRIENDO
            //QUIERE ACCEDER A COUNTRY.JSON
            var basePath = _webHostEnvironment.ContentRootPath;
            //da la ruta del archivo
            var filePath = Path.Combine(basePath, "country.json");
            //Lee el archivo entero y me lo da en formato string
            var countriesAasString = System.IO.File.ReadAllText(filePath);
            //necesito en objeto no en string
            var countries = JsonConvert.DeserializeObject<List<Country>>(countriesAasString);
            return countries;
        }
    }
}
