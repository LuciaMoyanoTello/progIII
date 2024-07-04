using DependecyInjection2.Context;
using DependecyInjection2.Domain;
using Microsoft.EntityFrameworkCore;

namespace DependecyInjection2.Repositories
{
    public class DbCountryRepository : ICountryRepository
    {
        private readonly CountryDbContext _context;
        public DbCountryRepository(CountryDbContext context)
        {
            _context = context;
        }
        public Task<List<Country>> GetAllAsync()
        {
            return _context.Countries.ToListAsync();
        }
    }
}
