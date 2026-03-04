using System.ComponentModel.DataAnnotations;

namespace Praktikum02.Blasor.Data;

public class Currency : NamedEntity
{
    public string? Symbol { get; set; }
}