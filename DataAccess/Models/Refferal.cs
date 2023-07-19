namespace DataAccess.Models
{
    public class Refferal
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public virtual ICollection<Job>? Jobs { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
    }
}
