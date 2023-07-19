using System;

namespace DataAccess.ViewModels
{
    public class SegmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DurabilityPerKilloMetter { get; set; }
        public int DurabilityPerMonth { get; set; }
        public string CreatedAt { get; set; }
    }
}
