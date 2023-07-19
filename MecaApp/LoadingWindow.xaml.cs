using System;
using System.Windows;
using System.Windows.Threading;

namespace WPFMecaApp
{
    /// <summary>
    /// Interaction logic for LoadingWindow.xaml
    /// </summary>
    public partial class LoadingWindow : Window
    {
        DispatcherTimer timer=new();
        public LoadingWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Tick += timer_tick;
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Start();
        }
        private void timer_tick(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
