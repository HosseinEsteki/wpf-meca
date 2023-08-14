using DataAccess.Models;
using DataAccess.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class RefferalsDataAccess
    {
        MecaDB db = BaseDataAccess.DB;

        public RefferalsDataAccess()
        {
            db.Database.EnsureCreated();
        }
        public List<RefferalViewModel> Alerts
        {
            get
            {
                List<RefferalViewModel> result = new();
                RefferalTemp refferalTemp = new RefferalTemp();
                foreach (var item in MainJobs)
                {

                    DateTime? AlertTime = refferalTemp.GetAlertTime(item);
                    if (AlertTime == null)
                    {
                        continue;
                    }
                    else
                    {
                        Refferal refferal = item.Refferal;
                        DateTime recentRefferal = item.Refferal.CreatedAt;
                        string recentRefferalPersian = PersianDateTime.GetDateTime(recentRefferal);
                        string refferalPersian = PersianDateTime.GetDate((DateTime)AlertTime);
                        RefferalViewModel refferalViewModel = new()
                        {
                            Id = item.Id,
                            CarName = refferal.Car.Name,
                            PhoneNumber = refferal.Car.User.PhoneNumber,
                            RecentRefferal = recentRefferalPersian,
                            UserId = refferal.Car.User.Id,
                            UserName = refferal.Car.User.Name,
                            RefferalDate = refferalPersian,
                            Segments = item.Segment.Name
                        };
                        result.Add(refferalViewModel);
                    }
                }

                return result;
            }
        }
        List<Refferal> MainRefferals
        {
            get
            {
                return db.Refferals
                             .Include(x => x.Car)
                             .ThenInclude(x => x.User)
                             .OrderByDescending(r => r.Id)
                             .ToList();
            }
        }
        List<Job> MainJobs
        {
            get
            {
                return db.Jobs
                    .Include(x => x.Refferal)
                    .Where(x => x.IsShow == true)
                    .ToList();
            }
        }
        public List<RefferalViewModel> Refferals
        {
            get
            {
                List<RefferalViewModel> result = new();
                foreach (var item in MainRefferals)
                {
                    DateTime recentRefferal = item.CreatedAt;
                    string recentRefferalPersian = PersianDateTime.GetDateTime(recentRefferal);
                    RefferalTemp refferalTemp = new RefferalTemp();
                    DateTime refferalDate = refferalTemp.GetRefferalDate(item);
                    string refferalPersian = PersianDateTime.GetDate(refferalDate);
                    string segmentsString = "";
                    List<string> segments = item.Jobs.Select(x => x.Segment.Name).ToList();
                    foreach (string segment in segments)
                    {
                        segmentsString += segment + "\n";
                    }
                    RefferalViewModel refferal = new()
                    {
                        Id = item.Id,
                        CarName = item.Car.Name,
                        PhoneNumber = item.Car.User.PhoneNumber,
                        RecentRefferal = recentRefferalPersian,
                        UserId = item.Car.User.Id,
                        UserName = item.Car.User.Name,
                        RefferalDate = refferalPersian,
                        Segments = segmentsString
                    };

                    result.Add(refferal);
                }

                return result;
            }
        }

        public void DontShow(List<int> ids)
        {
            foreach (int id in ids)
            {
                Job job = MainJobs.Where(x => x.Id == id).First();
                job.IsShow = false;
                db.Update(job);
            }
            db.SaveChanges();
        }
        public void Add(Car car, List<Segment> segments)
        {
            Refferal refferal = new Refferal()
            {
                CarId = car.Id,
            };
            db.Refferals.Add(refferal);
            db.SaveChanges();
            foreach (var segment in segments)
            {
                Job? job = db.Jobs
                           .Include(x => x.Refferal)
                           .ThenInclude(x => x.Car)
                           .Where(x => x.IsShow == true && x.SegmentId == segment.Id && x.Refferal.Car.Id == refferal.Car.Id)
                           .FirstOrDefault();
                if (job != null)
                {
                    job.IsShow = false;
                    db.Update(job);
                }
                db.Jobs.Add(new Job()
                {
                    SegmentId = segment.Id,
                    RefferalId = refferal.Id,
                });
            }
            db.SaveChanges();

        }
        public void Delete(RefferalViewModel refferalViewModel)
        {
            Refferal refferal = MainRefferals.Where(x => x.Id == refferalViewModel.Id).First();
            db.Refferals.Remove(refferal);
            db.SaveChanges();
        }
    }
}
