namespace HaircutManager.Domain.Models
{
    public class Service
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
    }
}
