using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepo
{
    public interface IBookingReservationRepository
    {
        IEnumerable<BookingReservation> GetBookingReservations();
        IEnumerable<BookingReservation> GetBookingReservationByUserId(int id);
        BookingReservation GetbookingReservationByID(int id);
        void InsertBookingReservation(BookingReservation bookingReservation);
        void UpdateBookingReservation(BookingReservation bookingReservation);
        void DeleteBookingReservation(BookingReservation bookingReservation);
        int GetRoomTypeId(string roomTypeName);
        IEnumerable<BookingDetail> GetBookingDetailList(BookingReservation bookingReservation);
        int GetMaxBookingReservationId();
    }
}
