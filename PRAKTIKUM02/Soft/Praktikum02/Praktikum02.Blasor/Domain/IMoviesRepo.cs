using Praktikum02.Blasor.Data;

namespace Praktikum02.Blasor.Domain
{
    public interface IMoviesRepo : IRepo<Movie>
    {
        Task<IEnumerable<Movie>> GetOrderedAsync();
    }
}
