using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using DataAccess.ViewModels;
using DataAccess.Data;

namespace WPFMecaApp
{
    public partial class RefferalsPage : Page
    {
        RefferalsDataAccess jobsDataAccess = new();
        private CollectionViewSource refferalsVeiwSource;
        public RefferalsPage()
        {
            InitializeComponent();
            refferalsVeiwSource =
                (CollectionViewSource)FindResource(nameof(refferalsVeiwSource));
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshDatabase();
        }
        private void RefferalGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonHide.IsEnabled = RefferalGrid.SelectedIndex >= 0;
        }
        private void RefreshDatabase()
        {
            refferalsVeiwSource.Source = jobsDataAccess.Alerts;
            RefferalGrid.Columns[0].Width = 30;
            RefferalGrid.Columns[0].Header = "کد";
            RefferalGrid.Columns[1].Header = "نام مشتری";
            RefferalGrid.Columns[2].Header = "خودرو";
            RefferalGrid.Columns[3].Header = "سابقه مراجعه";
            RefferalGrid.Columns[4].Header = "سررسید مراجعه";
            RefferalGrid.Columns[5].Header = "قطعه تعویضی";
            RefferalGrid.Columns[6].Header = "شماره تماس";
            RefferalGrid.Items.Refresh();
        }

        private void buttonHide_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult=
                MessageBox.Show("آیا از پنهان سازی این اعلان(ها) مطمئنید؟",
                "عدم نمایش",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < RefferalGrid.SelectedItems.Count; i++)
                {
                    list.Add(((RefferalViewModel)RefferalGrid.SelectedItems[i]).Id);
                }
                jobsDataAccess.DontShow(list);
                RefreshDatabase();
            }
        }
    }
}
