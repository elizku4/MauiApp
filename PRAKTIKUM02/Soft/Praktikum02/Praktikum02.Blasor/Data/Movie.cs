using System.ComponentModel.DataAnnotations;
namespace Praktikum02.Blasor.Data;

public class Movie : DetailedEntity
{
    [Required]
    public string Title { get; set; } = "";

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    public string Genre { get; set; } = "";

    [Range(0, 100)]
    public decimal Price { get; set; }
}
