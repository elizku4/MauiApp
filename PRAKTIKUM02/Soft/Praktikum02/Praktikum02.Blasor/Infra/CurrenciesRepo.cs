using Microsoft.EntityFrameworkCore;
using Praktikum02.Blasor.Data;
using Praktikum02.Blasor.Domain;

namespace Praktikum02.Blasor.Infra
{
    public class CurrenciesRepo : EfBaseRepo<Currency>, ICurrenciesRepo
    {
        public CurrenciesRepo(MovieContext context) : base(context) { }

        public async Task<IEnumerable<Currency>> GetOrderedAsync()
        {
            return await db.Set<Currency>()
                .AsNoTracking()
                .OrderBy(c => c.Code)
                .ToListAsync();
        }
    }
}
