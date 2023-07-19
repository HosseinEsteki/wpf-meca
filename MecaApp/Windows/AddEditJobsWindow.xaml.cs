using DataAccess;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WPFMecaApp.Windows
{
    public partial class AddEditJobsWindow : Window
    {
        ICollection<User> users;
        ICollection<Car> cars;
        ICollection<Segment> segments;
        User currentUser;

        UserDataAccess userDataAccess = new UserDataAccess();
        SegmentDataAccess segmentDataAccess=new SegmentDataAccess();
        CarDataAccess carDataAccess;
        RefferalsDataAccess jobsDataAccess;
        public AddEditJobsWindow(RefferalsDataAccess jobsDataAccess)
        {
            InitializeComponent();
            
            users = userDataAccess.Users;
            this.jobsDataAccess = jobsDataAccess;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in users)
            {
                UserSelect.Items.Add(item.Name);
            }
        }
        private void User_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarSelect.IsEnabled = true;
            SegmentSelect.IsEnabled = false;
            Submit.IsEnabled = false;
            SegmentSelect.Items.Clear();
            CarSelect.Items.Clear();
            currentUser = users.Where(x => x.Name == UserSelect.SelectedValue.ToString()).First();
            carDataAccess = new CarDataAccess(currentUser);
            cars = carDataAccess.Cars;
            foreach (var item in cars)
            {
                CarSelect.Items.Add(item.Name);
            }
            SegmentSelect.Items.Clear();
        }
        private void CarSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SegmentSelect.IsEnabled=true;
            SegmentSelect.Items.Clear();
            segments = segmentDataAccess.Segments;
            foreach (var item in segments)
            {
                SegmentSelect.Items.Add(item.Name);
            }
        }
        private void SegmentSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(SegmentSelect.SelectedItems.Count>0)
            {
                Submit.IsEnabled=true;
            }
            else
            {
                Submit.IsEnabled=false;
            }
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Car currentCar=carDataAccess.FindCarByName(CarSelect.SelectedValue.ToString());
            List<Segment> currentSegments = GetCurrentSegments();
            
            jobsDataAccess.Add(currentCar, currentSegments);
            MessageBox.Show("عملیات با موفقیت انجام شد");
            this.Close();
        }
        private List<Segment> GetCurrentSegments()
        {
            List<Segment> segments = new List<Segment>();
            foreach (string item in SegmentSelect.SelectedItems)
            {
                Segment segment= segmentDataAccess.FindSegmentByName(item.ToString());
                segments.Add(segment);
            }
            return segments;
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }       
    }
}
