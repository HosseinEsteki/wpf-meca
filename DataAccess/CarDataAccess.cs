using DataAccess.Data;
using DataAccess.Models;

namespace DataAccess
{
    public class CarDataAccess
    {
        List<Car> _cars;
        public List<Car> Cars { get {
                Refresh();
                return _cars; }
            set
            {
                _cars = value;
            }
        }
        User _user;
        public User User
        {
            get=>_user;
            set{
                _user = value;
            }
        }
        MecaDB db = BaseDataAccess.DB;
        public CarDataAccess(User user)
        {
            User = user;
        }
        public void Refresh()
        {
            Cars = db.Cars.Where(x => x.UserId == User.Id).ToList();
        }
        public void Add(Car car)
        {
            car.UserId = User.Id;
            db.Cars.Add(car);
            db.SaveChanges();
        }
        public void Update(Car car)
        {
            db.Cars.Update(car);
        }
        public void Delete(Car car)
        {
            db.Cars.Remove(car);
            db.SaveChanges();

        }
        public Car FindCarByName(string name)
        {
            return Cars.Where(x => x.Name == name).FirstOrDefault();
        }
    }
}
