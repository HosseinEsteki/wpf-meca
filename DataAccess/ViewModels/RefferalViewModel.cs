using DataAccess.Models;

namespace DataAccess.ViewModels
{
    public class RefferalViewModel
    {
        public int Id;
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string CarName { get; set; }
        public string RecentRefferal { get; set; }
        public string RefferalDate { get; set; }
        public string Segments { get; set; }
        public string PhoneNumber { get; set; }
    }
}
