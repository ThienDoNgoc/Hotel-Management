using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class BookingDetailDAO
    {
        FUMiniHotelManagementContext myDB = new FUMiniHotelManagementContext();

        private static BookingDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public static BookingDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookingDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<BookingDetail> GetbookingDetailList()
        {
            List<BookingDetail> bookingDetail;
            try
            {
                bookingDetail = myDB.BookingDetails.AsNoTracking().Where(s => s.BookingReservation.BookingStatus != 0)
                                                                .Include(r => r.BookingReservation)
                                                                .OrderByDescending(o => o.StartDate)
                                                                .ToList();
                foreach (var roomInfo in bookingDetail)
                {
                    myDB.Entry(roomInfo).State = EntityState.Detached;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookingDetail;
        }
        public IEnumerable<BookingDetail> GetBookingDetailByStartDateEndDate(DateTime startTime, DateTime endTime)
        {
            List<BookingDetail> bookingDetail;
            try
            {
                bookingDetail = myDB.BookingDetails.AsNoTracking().Where(s => s.StartDate >=startTime 
                                                                            && s.EndDate <= endTime 
                                                                            && s.BookingReservation.BookingStatus != 0)
                                                                            .Include(r=>r.BookingReservation)
                                                                            .OrderByDescending(o => o.StartDate)
                                                                            .ToList();
                foreach (var roomInfo in bookingDetail)
                {
                    myDB.Entry(roomInfo).State = EntityState.Detached;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookingDetail;
        }

        public IEnumerable<BookingDetail> GetbookingDetailByBookingReservationId(int bookingId)
        {
            List<BookingDetail> bookingDetail;
            try
            {
                bookingDetail = myDB.BookingDetails.AsNoTracking().Where(s => s.BookingReservationId == bookingId)
                                                                .ToList();
                foreach (var roomInfo in bookingDetail)
                {
                    myDB.Entry(roomInfo).State = EntityState.Detached;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookingDetail;
        }

        public void AddNew(BookingDetail bookingDetail)
        {
            try
            {
                myDB.BookingDetails.Add(bookingDetail);
                myDB.SaveChanges();
                myDB.Entry(bookingDetail).State = EntityState.Detached;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
