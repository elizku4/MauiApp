namespace Praktikum02.Blasor.Data;

public class Money : BaseEntity
{
    public decimal Amount { get; set; }
    public Guid CurrencyId { get; set; }
}
