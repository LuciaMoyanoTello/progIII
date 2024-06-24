using DependecyInjection.Domain;

namespace DependecyInjection.Repositories
{
    public class InMemoryRepository : ICountryRepository
    {
        private static List<Country> countries = new List<Country>
        {
            new Country{Id = "1", Nombre = "Argentina"},
            new Country{Id = "2", Nombre = "Francia"},
            new Country{Id = "3", Nombre = "Brasil"},
        };
        public List<Country> GetAll() //devuelve lista de paises
        {
            return countries;
        }
    }
}
