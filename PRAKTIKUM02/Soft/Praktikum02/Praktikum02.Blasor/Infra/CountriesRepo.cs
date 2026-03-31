using Praktikum02.Blasor.Data;
using Praktikum02.Blasor.Domain;
using Microsoft.EntityFrameworkCore;

namespace Praktikum02.Blasor.Infra
{
    public class CountriesRepo : EfBaseRepo<Country>, ICountriesRepo
    {
        public CountriesRepo(MovieContext context) : base(context) { }

        public async Task<IEnumerable<Country>> GetOrderedAsync()
        {
            return await db.Set<Country>()
                .AsNoTracking()
                .OrderBy(c => c.Name)
                .ToListAsync();
        }
    }
}
