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
    public class BookingReservationRepository : IBookingReservationRepository
    {
        public void DeleteBookingReservation(BookingReservation bookingReservation) => BookingReservationDAO.Instance.Remove(bookingReservation);

        public BookingReservation GetbookingReservationByID(int id) => BookingReservationDAO.Instance.GetBookingReservationByID(id);  

        public IEnumerable<BookingReservation> GetBookingReservations() => BookingReservationDAO.Instance.GetBookingReservationList();  

        public int GetRoomTypeId(string roomTypeName) => BookingReservationDAO.Instance.GetRoomTypeNameId(roomTypeName);

        public IEnumerable<BookingDetail> GetBookingDetailList(BookingReservation bookingReservation) => BookingReservationDAO.Instance.GetBookingDetail(bookingReservation);

        public void InsertBookingReservation(BookingReservation bookingReservation) => BookingReservationDAO.Instance.AddNew(bookingReservation);

        public void UpdateBookingReservation(BookingReservation bookingReservation) => BookingReservationDAO.Instance.Update(bookingReservation);

        public int GetMaxBookingReservationId() => BookingReservationDAO.Instance.GetMaxBookingReservationId();

        public IEnumerable<BookingReservation> GetBookingReservationByUserId(int id) => BookingReservationDAO.Instance.GetBookingReservationByCustomerId(id);
    }
}
