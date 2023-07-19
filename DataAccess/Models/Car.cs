namespace DataAccess.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RunPerYear { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
