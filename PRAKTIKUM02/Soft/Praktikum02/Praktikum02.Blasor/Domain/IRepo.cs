using Praktikum02.Blasor.Data;

namespace Praktikum02.Blasor.Domain
{
    public interface IRepo<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity?> GetAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAsync();
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(Guid id);
    }
}
