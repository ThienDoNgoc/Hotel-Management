using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class RoomInformationDAO
    {
        FUMiniHotelManagementContext myDB = new FUMiniHotelManagementContext();

        private static RoomInformationDAO instance = null;
        private static readonly object instanceLock = new object();
        public static RoomInformationDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new RoomInformationDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<RoomInformation> GetRoomInformationList()
        {
            List<RoomInformation> roomInformation;
            try
            {
                roomInformation = myDB.RoomInformations.AsNoTracking().Where(s => s.RoomStatus != 0).Include(r => r.RoomType).ToList();
                foreach (var roomInfo in roomInformation)
                {
                    myDB.Entry(roomInfo).State = EntityState.Detached;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return roomInformation;
        }

        public IEnumerable<RoomInformation> SearchRoomByRoomNumber(string keyword)
        {
            List<RoomInformation> roomInformation;
            try
            {
                roomInformation = myDB.RoomInformations.Where(c => c.RoomStatus !=0 && c.RoomNumber.ToLower().Contains(keyword.ToLower())).ToList();
                foreach (var roomInfo in roomInformation)
                {
                    myDB.Entry(roomInfo).State = EntityState.Detached;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return roomInformation;
        }

        public decimal? GetRoomPriceById(int id)
        {
            decimal? roomPrice = 0;
            try
            {
                var room = myDB.RoomInformations.Where(room => room.RoomId == id).FirstOrDefault();             
                roomPrice = room.RoomPricePerDay;
                myDB.Entry(room).State = EntityState.Detached;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return roomPrice;
        }

        public RoomInformation GetRoomInformationByID(int roomInformationID)
        {
            RoomInformation roomInformation = null;
            try
            {
                roomInformation = myDB.RoomInformations.AsNoTracking().SingleOrDefault(s => s.RoomId == roomInformationID);
                myDB.Entry(roomInformation).State = EntityState.Detached;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return roomInformation;
        }

        public void AddNew(RoomInformation roomInformation)
        {
            try
            {
                myDB.RoomInformations.Add(roomInformation);
                myDB.SaveChanges();
                myDB.Entry(roomInformation).State = EntityState.Detached;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<String> GetRoomTypeName()
        {
            List<String> roomTypeName = new List<string>();
            try
            {
                var room = myDB.RoomTypes.AsNoTracking().ToList();
                foreach (var type in room)
                {
                    roomTypeName.Add(type.RoomTypeName);    
                }
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
                // Check if the RoomInformation exists in the database
                var room = myDB.RoomTypes.FirstOrDefault(s => s.RoomTypeName == roomTypeName);
                roomTypeId = room.RoomTypeId;
                myDB.Entry(room).State = EntityState.Detached;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return roomTypeId;
        }

        public bool CheckRoomExist(string roomNumber)
        {
            bool check = false;
            try
            {
                var customers = myDB.RoomInformations.AsNoTracking().Where(s => s.RoomStatus != 0 && s.RoomNumber == roomNumber).FirstOrDefault();
                if (customers!=null)
                {
                    check = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        public List<int> GetRoomValidList()
        {
            List<int> listRoomValid = new List<int>();
            try
            {
                 listRoomValid = myDB.RoomInformations.Where(room => !myDB.BookingDetails
                                                      .Any(booking => booking.RoomId == room.RoomId
                                                                   && booking.StartDate <= DateTime.Now
                                                                   && booking.EndDate >= DateTime.Now
                                                                   && booking.BookingReservation.BookingStatus!=0))
                                                      .Select(room => room.RoomId)
                                                      .ToList();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listRoomValid;

        }

        public void Update(RoomInformation roomInformation)
        {
            try
            {
                // Check if the RoomInformation exists in the database
                var existingRoomInformation = myDB.RoomInformations.Find(roomInformation.RoomId);

                if (existingRoomInformation != null)
                {
                    // Update the existing entity with the new values
                    myDB.Entry(existingRoomInformation).CurrentValues.SetValues(roomInformation);
                    myDB.SaveChanges();
                    myDB.Entry(existingRoomInformation).State = EntityState.Detached;

                }
                else
                {
                    throw new Exception("The roomInformation not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(RoomInformation roomInformation)
        {
            try
            {
                RoomInformation _roomInformation = GetRoomInformationByID(roomInformation.RoomId);
                if (_roomInformation != null)
                {
                    var listBooking = myDB.BookingDetails.FirstOrDefault(s => s.RoomId == _roomInformation.RoomId);
                    if (listBooking!=null)
                    {
                        roomInformation.RoomStatus = 0;
                        myDB.Entry<RoomInformation>(roomInformation).State = EntityState.Modified;
                        myDB.SaveChanges();
                        myDB.Entry(roomInformation).State = EntityState.Detached;
                    }
                    else
                    {
                        myDB.RoomInformations.Remove(roomInformation);
                        myDB.SaveChanges();
                        myDB.Entry(roomInformation).State = EntityState.Detached;

                    }
                }
                else
                {
                    throw new Exception("The roomInformation not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
