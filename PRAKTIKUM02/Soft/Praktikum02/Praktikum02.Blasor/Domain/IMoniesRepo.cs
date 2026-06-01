using Praktikum02.Blasor.Data;

namespace Praktikum02.Blasor.Domain;

public interface IMoniesRepo : IRepo<Money>
{
    Task<IEnumerable<Money>> GetOrderedAsync();
}