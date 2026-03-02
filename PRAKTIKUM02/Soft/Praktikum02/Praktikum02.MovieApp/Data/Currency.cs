using System.ComponentModel.DataAnnotations;

namespace Praktikum02.MovieApp.Data;

public class Currency
{
    public int Id { get; set; }

    [Required]
    [StringLength(3)]
    public string Code { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    public string? Symbol { get; set; }
}