namespace DataAccess.Models
{
    public class Job
    {
        public int Id { get; set; }
        public int SegmentId { get; set; }
        public bool IsShow { get; set; } = true;
        public virtual Segment Segment { get; set; }
        public int RefferalId { get; set; }
        public virtual Refferal Refferal { get; set; }


    }
}
