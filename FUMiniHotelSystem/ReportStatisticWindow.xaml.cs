using BusinessObjects;
using Repositories.IRepo;
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

namespace FUMiniHotelSystem
{
    /// <summary>
    /// Interaction logic for ReportStatisticWindow.xaml
    /// </summary>
    public partial class ReportStatisticWindow : Window
    {
        IBookingDetailRepository _bookingDetailRepository;
        public ReportStatisticWindow(IBookingDetailRepository bookingDetailRepository)
        {
            InitializeComponent();
            _bookingDetailRepository = bookingDetailRepository;
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadData_Click(object sender, RoutedEventArgs e)
        {
            decimal? totalPrice = 0;

            if (!StartDatePicker.SelectedDate.HasValue && !EndDatePicker.SelectedDate.HasValue)
            {
                lvRoomInformation.ItemsSource = _bookingDetailRepository.GetBookingDetailsAllList();

            }
            else if (StartDatePicker.SelectedDate.HasValue && EndDatePicker.SelectedDate.HasValue)
            {
                DateTime startDate = StartDatePicker.SelectedDate.Value;
                DateTime endDate = EndDatePicker.SelectedDate.Value;
                lvRoomInformation.ItemsSource = _bookingDetailRepository.GetBookingDetailFromStartDateToEndDate(startDate, endDate);
            }
            else
            {
                MessageBox.Show("Please Choose All date");
            }

            NumberOfBookinglbs.Content = lvRoomInformation.Items.Count;
            foreach(var detail in lvRoomInformation.Items)
            {
                var bookingDetail = detail as BookingDetail;
                if (bookingDetail != null)
                {
                    totalPrice += bookingDetail.ActualPrice;
                }
            }
            TotalPricelbs.Content = totalPrice;
        }
    }
}
