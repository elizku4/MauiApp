using Praktikum02.Blasor.Data;

namespace Praktikum02.Blasor.Domain
{
    public interface ICurrenciesRepo : IRepo<Currency>
    {
        Task<IEnumerable<Currency>> GetOrderedAsync();
    }
}
