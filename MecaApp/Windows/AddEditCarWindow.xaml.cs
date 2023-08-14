using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DataAccess.Data;

namespace WPFMecaApp.Windows
{
    /// <summary>
    /// Interaction logic for AddEditCarWindow.xaml
    /// </summary>
    public partial class AddEditCarWindow : Window
    {
        CarDataAccess carDataAccess;
        Car Car;
        public AddEditCarWindow(CarDataAccess carDataAccess)
        {
            InitializeComponent();
            this.carDataAccess = carDataAccess;
        }
        public AddEditCarWindow(CarDataAccess carDataAccess, Car car)
        {
            InitializeComponent();
            this.carDataAccess = carDataAccess;
            this.Car = car;
            textboxCarName.Text = car.Name;
            textboxRunPerYear.Text = car.RunPerYear.ToString();
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int runPerYear = Convert.ToInt32(textboxRunPerYear.Text.Trim());
            string carName = textboxCarName.Text.Trim();
            if (Car == null)
            {
                Car car = new Car
                {
                    Name = carName,
                    RunPerYear = runPerYear,
                };

                carDataAccess.Add(car);
                MessageBox.Show(Messages.InsertMessage);
            }
            else
            {
                Car.Name = carName;
                Car.RunPerYear = runPerYear;
                carDataAccess.Update(Car);
                MessageBox.Show(Messages.UpdateMessage);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textboxRunPerYear_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            CheckInput.Number(e);
        }
        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnSubmit.IsEnabled =
                textboxCarName.Text.Trim().Length > 0
                && textboxRunPerYear.Text.Trim().Length > 0;
        }
    }
}
