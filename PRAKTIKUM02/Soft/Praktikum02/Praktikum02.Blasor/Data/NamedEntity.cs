namespace Praktikum02.Blasor.Data;

public abstract class NamedEntity : DetailedEntity
{
    public string Name { get; set; } = "";
    public string Code { get; set; } = "";
}