using DependecyInjection.Domain;

namespace DependecyInjection.Repositories
{
    public interface ICountryRepository
    {
        List<Country> GetAll();
    }
}
