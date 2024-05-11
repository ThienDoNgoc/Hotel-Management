using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class BookingReservationDAO
    {
        FUMiniHotelManagementContext myDB = new FUMiniHotelManagementContext();

        private static BookingReservationDAO instance = null;
        private static readonly object instanceLock = new object();
        public static BookingReservationDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookingReservationDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<BookingReservation> GetBookingReservationList()
        {
            List<BookingReservation> bookingReservation;
            try
            {
                bookingReservation = myDB.BookingReservations.AsNoTracking().Where(s => s.BookingStatus != 0)
                                                                            .Include(s => s.Customer)
                                                                            .ToList();
                foreach (var roomInfo in bookingReservation)
                {
                    myDB.Entry(roomInfo).State = EntityState.Detached;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookingReservation;
        }

        public IEnumerable<BookingReservation> GetBookingReservationByCustomerId(int id)
        {
            List<BookingReservation> bookingReservation;
            try
            {
                bookingReservation = myDB.BookingReservations.AsNoTracking().Where(s => s.BookingStatus != 0 && s.CustomerId == id)
                                                                            .Include(s => s.Customer)
                                                                            .ToList();
                foreach (var roomInfo in bookingReservation)
                {
                    myDB.Entry(roomInfo).State = EntityState.Detached;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookingReservation;
        }


        public BookingReservation GetBookingReservationByID(int bookingReservationID)
        {
            BookingReservation bookingReservation = null;
            try
            {
                bookingReservation = myDB.BookingReservations.AsNoTracking().SingleOrDefault(s => s.BookingReservationId == bookingReservationID);
                myDB.Entry(bookingReservation).State = EntityState.Detached;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookingReservation;
        }

        public void AddNew(BookingReservation bookingReservation)
        {
            try
            {
                myDB.BookingReservations.Add(bookingReservation);
                myDB.SaveChanges();
                myDB.Entry(bookingReservation).State = EntityState.Detached;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BookingDetail> GetBookingDetail(BookingReservation bookingReservation)
        {
            List<BookingDetail> roomTypeName = new List<BookingDetail>();
            try
            {
                roomTypeName = myDB.BookingDetails.AsNoTracking().Where(s => s.BookingReservationId == bookingReservation.BookingReservationId).ToList();
        
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return roomTypeName;
        }

        public int GetRoomTypeNameId(string roomTypeName)
        {
            int roomTypeId;
            try
            {
                // Check if the bookingReservation exists in the database
                var room = myDB.RoomTypes.FirstOrDefault(s => s.RoomTypeName == roomTypeName);
                myDB.Entry(room).State = EntityState.Detached;
                roomTypeId = room.RoomTypeId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return roomTypeId;
        }

        public int GetMaxBookingReservationId()
        {
            int maxBookingReservationId;
            try
            {
                 maxBookingReservationId = myDB.BookingReservations.AsNoTracking().Max(br => br.BookingReservationId);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return maxBookingReservationId;
        }

        public void Update(BookingReservation bookingReservation)
        {
            try
            {
                // Check if the bookingReservation exists in the database
                var existingBookingReservation = myDB.BookingReservations.Find(bookingReservation.BookingReservationId);

                if (existingBookingReservation != null)
                {
                    myDB.Entry(existingBookingReservation).CurrentValues.SetValues(bookingReservation);
                    myDB.SaveChanges();
                    myDB.Entry(existingBookingReservation).State = EntityState.Detached;
                }
                else
                {
                    throw new Exception("The bookingReservation not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(BookingReservation bookingReservation)
        {
            try
            {
                BookingReservation _bookingReservation = GetBookingReservationByID(bookingReservation.BookingReservationId);
                if (_bookingReservation != null)
                {
                        bookingReservation.BookingStatus = 0;
                        myDB.Entry<BookingReservation>(bookingReservation).State = EntityState.Modified;
                        myDB.SaveChanges();
                        myDB.Entry(bookingReservation).State = EntityState.Detached;                         
                }
                else
                {
                    throw new Exception("The bookingReservation not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
