
namespace DataAccess.Models
{
    public class Segment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DurabilityPerKilloMetter { get; set; }
        public int DurabilityPerMonth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
