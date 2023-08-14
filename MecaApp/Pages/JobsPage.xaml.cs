using DataAccess.Data;
using DataAccess.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WPFMecaApp.Windows;

namespace WPFMecaApp
{
    public partial class JobsPage : Page
    {
        RefferalsDataAccess jobsDataAccess = new();
        private CollectionViewSource jobsViewSource;
        public JobsPage()
        {
            InitializeComponent();
            jobsViewSource =
                (CollectionViewSource)FindResource(nameof(jobsViewSource));
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshDatabase();
        }
        private void UserGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonDelete.IsEnabled = JobGrid.SelectedIndex >= 0;
        }
        private void RefreshDatabase()
        {
            jobsViewSource.Source = jobsDataAccess.Refferals;
            JobGrid.Columns[0].Width = 30;
            JobGrid.Columns[0].Header = "کد";
            JobGrid.Columns[1].Header = "نام مشتری";
            JobGrid.Columns[2].Header = "خودرو";
            JobGrid.Columns[3].Header = "سابقه مراجعه";
            JobGrid.Columns[4].Header = "سررسید مراجعه";
            JobGrid.Columns[5].Header = "قطعه تعویضی";
            JobGrid.Columns[6].Header = "شماره تماس";
            JobGrid.Items.Refresh();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddEditJobsWindow jobsWindow = new AddEditJobsWindow(jobsDataAccess);
            jobsWindow.ShowDialog();
            RefreshDatabase();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult =
                MessageBox.Show("آیا از حذف مراجعه مطمئنید؟", "حذف مراجعه", MessageBoxButton.YesNo);
            if(messageBoxResult == MessageBoxResult.Yes)
            {
                RefferalViewModel refferal = (RefferalViewModel)JobGrid.SelectedValue;
                jobsDataAccess.Delete(refferal);
                MessageBox.Show(Messages.RemoveMessage);
                RefreshDatabase();
            }
        }
    }
}
