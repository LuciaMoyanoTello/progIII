using DependecyInjection2.Domain;

namespace DependecyInjection2.Repositories
{
    public class InMemoryRepository : ICountryRepository
    {
        private static List<Country> countries = new List<Country>
        {
            new Country{Id = "1", Name = "Argentina"},
            new Country{Id = "2", Name = "Francia"},
            new Country{Id = "3", Name = "Brasil"}
        };
        public Task<List<Country>> GetAllAsync()
        {
            return Task.FromResult(countries);
        }
    }
}
