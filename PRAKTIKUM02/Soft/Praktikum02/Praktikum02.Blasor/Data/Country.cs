using System.ComponentModel.DataAnnotations;

namespace Praktikum02.Blasor.Data;

public class Country : NamedEntity
{
    public string IsoCode { get; set; } = "";
}