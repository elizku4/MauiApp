using Microsoft.EntityFrameworkCore;
using Praktikum02.Blasor.Data;
using Praktikum02.Blasor.Domain;

namespace Praktikum02.Blasor.Infra;

public class CountryCurrenciesRepo : EfBaseRepo<CountryCurrency>, ICountryCurrenciesRepo
{
    public CountryCurrenciesRepo(MovieContext context) : base(context)
    {
    }

    public async Task<IEnumerable<CountryCurrency>> GetOrderedAsync()
    {
        return await db.Set<CountryCurrency>()
            .AsNoTracking()
            .OrderBy(x => x.CountryId)
            .ThenBy(x => x.CurrencyId)
            .ToListAsync();
    }
}