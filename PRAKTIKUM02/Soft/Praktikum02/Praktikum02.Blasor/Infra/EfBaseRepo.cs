using Microsoft.EntityFrameworkCore;
using Praktikum02.Blasor.Data;
using Praktikum02.Blasor.Domain;

namespace Praktikum02.Blasor.Infra
{
    public class EfBaseRepo<TEntity> : IRepo<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly MovieContext db;

        public EfBaseRepo(MovieContext context)
        {
            db = context;
        }

        public async Task<TEntity?> GetAsync(Guid id) =>
            await db.Set<TEntity>().FindAsync(id);

        public async Task<IEnumerable<TEntity>> GetAsync() =>
            await db.Set<TEntity>().ToListAsync();

        public async Task CreateAsync(TEntity entity)
        {
            db.Add(entity);
            await db.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            db.Update(entity);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetAsync(id);
            if (entity == null) return;

            db.Remove(entity);
            await db.SaveChangesAsync();
        }
    }
}
