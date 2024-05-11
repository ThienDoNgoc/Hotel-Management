using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepo
{
    public interface IBookingDetailRepository
    {   
            IEnumerable<BookingDetail> GetBookingDetailsAllList();
            IEnumerable<BookingDetail> GetBookingDetailFromStartDateToEndDate(DateTime startDate, DateTime endDate);
            IEnumerable<BookingDetail> GetBookingDetailByBookingReserId(int bookingReservationId);
            void InsertBookingDetail(BookingDetail bookingDetail);
    }
}
