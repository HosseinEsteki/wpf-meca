using DataAccess.Models;
using DataAccess.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace DataAccess.Data
{
    public class SegmentDataAccess
    {
        MecaDB db = BaseDataAccess.DB;
        public List<Segment> Segments { get => db.Segments.OrderByDescending(x => x.Id).ToList(); }
        public List<SegmentViewModel> SegmentsForDataGrid
        {
            get
            {
                List<SegmentViewModel> segments = new();
                foreach (var segment in Segments)
                {
                    SegmentViewModel seg = new SegmentViewModel()
                    {
                        Id = segment.Id,
                        Name = segment.Name,
                        DurabilityPerKilloMetter = segment.DurabilityPerKilloMetter,
                        DurabilityPerMonth = segment.DurabilityPerMonth,
                        CreatedAt = PersianDateTime.GetDateTime(segment.CreatedAt),
                    };
                    segments.Add(seg);
                }
                return segments;
            }
        }
        public Segment? FindSegment(int segmentId)
        {
            return Segments.FirstOrDefault(x => x.Id == segmentId);
        }
        public void Add(Segment segment)
        {
            segment.CreatedAt = DateTime.Now;
            db.Segments.Add(segment);
            db.SaveChanges();
        }
        public void Update(Segment segment)
        {
            db.Segments.Update(segment);
            db.SaveChanges();
        }
        public void Delete(Segment segment)
        {
            db.Segments.Remove(segment);
            db.SaveChanges();
        }

        public Segment FindSegmentByName(string name)
        {
            return Segments.Where(x => x.Name == name).FirstOrDefault();
        }
    }
}
