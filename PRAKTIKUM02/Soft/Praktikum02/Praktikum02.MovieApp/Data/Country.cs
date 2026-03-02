using System.ComponentModel.DataAnnotations;

namespace Praktikum02.MovieApp.Data;

public class Country
{
    public int Id { get; set; }

    [Required]
    [StringLength(2)]
    public string IsoCode { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
}