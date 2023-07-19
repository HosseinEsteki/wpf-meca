using DataAccess;
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

namespace WPFMecaApp.Windows
{
    /// <summary>
    /// Interaction logic for AddEditSegmentWindow.xaml
    /// </summary>
    public partial class AddEditSegmentWindow : Window
    {
        SegmentDataAccess SegmentDataAccess = new();
        public Segment Segment { get; set; }
        public AddEditSegmentWindow()
        {
            InitializeComponent();
        }
        public AddEditSegmentWindow(Segment segment)
        {
            InitializeComponent();
            Segment = segment;
            textboxName.Text = segment.Name;
            textboxKiloMeterDuribility.Text = segment.DurabilityPerKilloMetter.ToString();
            textboxMonthDuribility.Text=segment.DurabilityPerMonth.ToString();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (Segment == null)
            {
                Segment segment = new Segment()
                {
                    Name = textboxName.Text.Trim(),
                    DurabilityPerKilloMetter = int.Parse(textboxKiloMeterDuribility.Text.Trim()),
                    DurabilityPerMonth=int.Parse(textboxMonthDuribility.Text.Trim()),
                    CreatedAt = DateTime.Now,
                };
                SegmentDataAccess.Add(segment);
                MessageBox.Show(Messages.InsertMessage);

            }
            else
            {
                Segment.Name = textboxName.Text.Trim();
                Segment.DurabilityPerKilloMetter = int.Parse(textboxKiloMeterDuribility.Text.Trim());
                Segment.DurabilityPerMonth = int.Parse(textboxMonthDuribility.Text.Trim());
                SegmentDataAccess.Update(Segment);
                MessageBox.Show(Messages.UpdateMessage);
            }
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void textboxMonthDuribility_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            CheckInput.Number(e);
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnSubmit.IsEnabled=
                textboxKiloMeterDuribility.Text.Trim().Length>0
                &&textboxMonthDuribility.Text.Trim().Length>0
                &&textboxName.Text.Trim().Length>0;
        }
    }
}
