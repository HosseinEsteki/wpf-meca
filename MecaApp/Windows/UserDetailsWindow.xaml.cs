using DataAccess;
using DataAccess.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPFMecaApp.Windows
{
    public partial class UserDetailsWindow : Window
    {
        CollectionViewSource carViewSource;
        CarDataAccess carDataAccess;
        User User;
        Car CurrentCar;
        public UserDetailsWindow(User user)
        {
            User = user;
            carDataAccess=new CarDataAccess(user);
            InitializeComponent();
            carViewSource =
                (CollectionViewSource)FindResource(nameof(carViewSource));
            RefreshDatabase();
            FillData();
            buttonEditCar.IsEnabled=false;
            buttonRemoveCar.IsEnabled=false;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (carsListView.SelectedItems.Count > 0)
            {
                CurrentCar = carsListView.SelectedItem as Car;
                buttonEditCar.IsEnabled = true;
                buttonRemoveCar.IsEnabled = true;
            }
            else
            {
                buttonEditCar.IsEnabled = false;
                buttonRemoveCar.IsEnabled = false;
            }
        }
        private void RefreshDatabase()
        {
            carViewSource.Source = carDataAccess.Cars;
            carsListView.Items.Refresh();
            FillData();
        }
        private void FillData()
        {
            labelCarsNumber.Content = carDataAccess.Cars.Count;
            labelPhoneNumber.Content = User.PhoneNumber;
            labelUserName.Content = User.Name;
        }
        private void buttonAddCar_Click(object sender, RoutedEventArgs e)
        {
            AddEditCarWindow addEditCarWindow = new AddEditCarWindow(carDataAccess);
            addEditCarWindow.ShowDialog();
            RefreshDatabase();
        }

        private void buttonEditCar_Click(object sender, RoutedEventArgs e)
        {
            AddEditCarWindow addEditCarWindow = new(carDataAccess,CurrentCar);
            addEditCarWindow.ShowDialog();
            RefreshDatabase();
        }

        private void buttonRemoveCar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult action = MessageBox.Show("آیا از حذف خودرو اطمینان دارید؟", "حذف خودرو", MessageBoxButton.YesNo);
            if (action == MessageBoxResult.Yes)
            {
                carDataAccess.Delete(CurrentCar);
                RefreshDatabase();
            }
        }
    }
}
