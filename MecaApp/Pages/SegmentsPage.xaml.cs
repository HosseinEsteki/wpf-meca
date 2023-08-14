using DataAccess.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WPFMecaApp.Windows;
using DataAccess.ViewModels;
using DataAccess.Data;

namespace WPFMecaApp
{
    public partial class SegmentsPage : Page
    {
        SegmentDataAccess segmentDataAccess = new();
        Segment currentSegment {  get; set; }
        private CollectionViewSource segmentViewSource;
        public SegmentsPage()
        {
            InitializeComponent();
            segmentViewSource =
                (CollectionViewSource)FindResource(nameof(segmentViewSource));
        }
        private void RefreshDatabase()
        {
            segmentViewSource.Source = segmentDataAccess.SegmentsForDataGrid;
            SegmentGrid.Columns[0].Width = 30;
            SegmentGrid.Columns[0].Header = "کد";
            SegmentGrid.Columns[1].Header = "نام قطعه";
            SegmentGrid.Columns[2].Header = "طول عمر بر حسب کیلومتر";
            SegmentGrid.Columns[3].Header = "طول عمر بر حسب ماه";
            SegmentGrid.Columns[4].Header = "تاریخ ایجاد";
            SegmentGrid.Items.Refresh();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshDatabase();
        }
        private void SegmentGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SegmentGrid.SelectedIndex >= 0)
            {
                SegmentViewModel segment = SegmentGrid.SelectedItem as SegmentViewModel;
                currentSegment = segmentDataAccess.FindSegment(segment.Id);
                buttonEdit.IsEnabled = true;
                buttonDelete.IsEnabled = true;
            }
            else
            {
                buttonEdit.IsEnabled = false;
                buttonDelete.IsEnabled = false;
            }
        }
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditSegmentWindow addEditSegmentWindow = new();
            addEditSegmentWindow.ShowDialog();
            RefreshDatabase();
        }
        

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEditSegmentWindow addEditSegmentWindow = new(currentSegment);
            addEditSegmentWindow.ShowDialog();
            RefreshDatabase();
        }
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = 
                MessageBox.Show("آیا از حذف موارد مطمئنید؟", "حذف", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                segmentDataAccess.Delete(currentSegment);
                MessageBox.Show(Messages.RemoveMessage);
            }
            RefreshDatabase();
        }
    }
}
