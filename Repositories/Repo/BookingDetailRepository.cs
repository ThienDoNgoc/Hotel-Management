using BusinessObjects;
using DataAccessObjects;
using Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repo
{
    public class BookingDetailRepository : IBookingDetailRepository
    {
        public IEnumerable<BookingDetail> GetBookingDetailByBookingReserId(int bookingReservationId) => BookingDetailDAO.Instance.GetbookingDetailByBookingReservationId(bookingReservationId); 

        public IEnumerable<BookingDetail> GetBookingDetailFromStartDateToEndDate(DateTime startDate, DateTime endDate) => BookingDetailDAO.Instance.GetBookingDetailByStartDateEndDate(startDate, endDate);

        public IEnumerable<BookingDetail> GetBookingDetailsAllList() => BookingDetailDAO.Instance.GetbookingDetailList();

        public void InsertBookingDetail(BookingDetail bookingDetail) => BookingDetailDAO.Instance.AddNew(bookingDetail);
    }
}
