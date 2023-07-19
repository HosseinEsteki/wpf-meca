
namespace DataAccess.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        #region TimeStamp
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        #endregion
    }
}
