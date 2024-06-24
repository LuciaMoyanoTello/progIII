using DependecyInjection.Context;
using DependecyInjection.Domain;

namespace DependecyInjection.Repositories
{
    public class DbCountryRepository : ICountryRepository
    {
        private readonly CountryDbContext _context;

        public DbCountryRepository(CountryDbContext context)
        {
            _context = context;
        }
        public List<Country> GetAll()
        {
            //hace una lista de lo que tengo en db
            //usar powershell para desarrolladores: dotnet ef migrations add InitialCreate
            //Si no lo toma hacer: dotnet tool install --global dotnet-ef
            //                     dotnet ef --version (para ver si se instalo bien)
            //Siguiente paso: dotnet ef database update
            return _context.Countries.ToList();
        }
    }
}
