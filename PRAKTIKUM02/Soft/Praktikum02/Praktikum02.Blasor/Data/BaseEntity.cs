namespace Praktikum02.Blasor.Data
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime ValidFrom { get; set; } = DateTime.Now;

        public DateTime? ValidTo { get; set; }

        public byte[]? Timestamp { get; set; }
    }
}
