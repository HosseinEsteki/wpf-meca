using DataAccess.Models;
using DataAccess;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Collections.ObjectModel;
using DataAccess.ViewModels;
using WPFMecaApp.Windows;

namespace WPFMecaApp
{
    public partial class UsersPage : Page
    {
        UserDataAccess userDataAccess = new();
        public User CurrentUser { get; set; }
        int selectionChangeCount = 0;
        private CollectionViewSource userViewSource;
        public UsersPage()
        {
            InitializeComponent();
            userViewSource =
                (CollectionViewSource)FindResource(nameof(userViewSource));
        }
        private void RefreshDatabase()
        {
            userViewSource.Source = userDataAccess.UsersForDataGrid;
            UserGrid.Columns[0].Width = 30;
            UserGrid.Columns[0].Header = "شناسه";
            UserGrid.Columns[1].Header = "نام مشتری";
            UserGrid.Columns[2].Header = "شماره تلفن";
            UserGrid.Columns[3].Header = "تاریخ ایجاد";
            UserGrid.Items.Refresh();
            selectionChangeCount = 0;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            buttonEdit.IsEnabled = false;
            buttonDelete.IsEnabled = false;
            buttonDetails.IsEnabled = false;
            RefreshDatabase();
        }
        private void UserGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserGrid.SelectedIndex >= 0)
            {
                UserViewModel user = UserGrid.SelectedItem as UserViewModel;
                CurrentUser = userDataAccess.Find(user.Id);
                buttonEdit.IsEnabled = true;
                buttonDelete.IsEnabled = true;
                buttonDetails.IsEnabled = true;
            }
            else
            {
                buttonEdit.IsEnabled = false;
                buttonDelete.IsEnabled = false;
                buttonDetails.IsEnabled = false;
            }
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditUserWindow win = new AddEditUserWindow();
            win.ShowDialog();
            RefreshDatabase();
        }
        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEditUserWindow win = new AddEditUserWindow(CurrentUser);
            win.ShowDialog();
            RefreshDatabase();
        }
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = 
                MessageBox.Show("آیا از حذف موارد مطمئنید؟", "حذف", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                userDataAccess.Delete(CurrentUser);
                MessageBox.Show(Messages.RemoveMessage);
            }
            RefreshDatabase();
        }
        private void buttonDetails_Click(object sender, RoutedEventArgs e)
        {
            UserDetailsWindow userDetails = new UserDetailsWindow(CurrentUser);
            userDetails.ShowDialog();
        }
    }
}
