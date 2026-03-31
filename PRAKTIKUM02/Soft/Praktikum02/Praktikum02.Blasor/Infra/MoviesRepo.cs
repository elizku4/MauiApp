using Microsoft.EntityFrameworkCore;
using Praktikum02.Blasor.Data;
using Praktikum02.Blasor.Domain;

namespace Praktikum02.Blasor.Infra
{
    public class MoviesRepo : EfBaseRepo<Movie>, IMoviesRepo
    {
        public MoviesRepo(MovieContext context) : base(context) { }

        public async Task<IEnumerable<Movie>> GetOrderedAsync()
        {
            return await db.Set<Movie>()
                .AsNoTracking()
                .OrderBy(m => m.Title)
                .ToListAsync();
        }
    }
}
