using Microsoft.EntityFrameworkCore;
using Praktikum02.Blasor.Data;
using Praktikum02.Blasor.Domain;

namespace Praktikum02.Blasor.Infra;

public class MoniesRepo : EfBaseRepo<Money>, IMoniesRepo
{
    public MoniesRepo(MovieContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Money>> GetOrderedAsync()
    {
        var list = await db.Set<Money>()
            .AsNoTracking()
            .ToListAsync();

        return list.OrderBy(x => x.Amount);
    }
}