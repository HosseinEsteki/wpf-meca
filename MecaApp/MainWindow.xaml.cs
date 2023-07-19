using System.Windows;
using WPFMecaApp;

namespace MecaApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new RefferalsPage();
            LoadingWindow loadingWindow= new LoadingWindow();
            this.Hide();
            loadingWindow.ShowDialog();
            this.Show();
        }
        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content=new UsersPage();
        }

        private void btnTime_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new RefferalsPage();
        }

        private void btnRefferal_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new JobsPage();
        }

        private void btnSegments_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new SegmentsPage();
        }
    }
}
