using DataAccess.Models;
using DataAccess.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace DataAccess.Data
{
    public class UserDataAccess
    {

        MecaDB db = BaseDataAccess.DB;
        public List<User> Users
        {
            get => db.Users.OrderByDescending(x => x.Id).ToList();
        }
        public List<UserViewModel> UsersForDataGrid
        {
            get
            {
                List<UserViewModel> usersViewModel = new List<UserViewModel>();
                foreach (User user in Users)
                {
                    UserViewModel uvm = new UserViewModel()
                    {
                        CreatedAt = PersianDateTime.GetDateTime(user.CreatedAt),
                        Id = user.Id,
                        Name = user.Name,
                        PhoneNumber = user.PhoneNumber
                    };
                    usersViewModel.Add(uvm);
                }
                return usersViewModel;
            }
        }
        public void Add(User user)
        {
            user.CreatedAt = DateTime.Now;
            db.Users.Add(user);
            db.SaveChanges();
        }
        public void Update(User user)
        {
            db.Users.Update(user);
            db.SaveChanges();
        }
        public void Delete(User user)
        {
            db.Users.Remove(user);
            db.SaveChanges();
        }
        public User? Find(int userId)
        {
            return Users.FirstOrDefault(x => x.Id == userId);
        }
    }
}
