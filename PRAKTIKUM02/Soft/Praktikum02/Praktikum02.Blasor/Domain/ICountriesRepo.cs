using Praktikum02.Blasor.Data;

namespace Praktikum02.Blasor.Domain
{
    public interface ICountriesRepo : IRepo<Country>
    {
        Task<IEnumerable<Country>> GetOrderedAsync();
    }
}
