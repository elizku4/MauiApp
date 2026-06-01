using Praktikum02.Blasor.Data;

namespace Praktikum02.Blasor.Domain;

public interface ICountryCurrenciesRepo : IRepo<CountryCurrency>
{
    Task<IEnumerable<CountryCurrency>> GetOrderedAsync();
}