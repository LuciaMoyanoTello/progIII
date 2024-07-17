using DependecyInjection2.Domain;

namespace DependecyInjection2.Repositories
{
    public interface ICountryRepository
    {
        //Ejecutar tarea como asincrona
        //Se ejecuta esto y hasta que termine no se ejecuta lo demás?
        Task<List<Country>> GetAllAsync();
        Task<Country> CreateAsync(Country country);
    }
}
