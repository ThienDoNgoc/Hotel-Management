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
    public class RoomInformationRepository : IRoomInformationRepository
    {
        public bool CheckRoomNumberExist(string roomNumber) => RoomInformationDAO.Instance.CheckRoomExist(roomNumber);

        public void DeleteRoomInformation(RoomInformation roomInformation) => RoomInformationDAO.Instance.Remove(roomInformation);

        public IEnumerable<RoomInformation> GetRoomInforamtions() => RoomInformationDAO.Instance.GetRoomInformationList();

        public RoomInformation GetRoomInformationByID(int id) => RoomInformationDAO.Instance.GetRoomInformationByID(id);

        public decimal? GetRoomPriceById(int id) => RoomInformationDAO.Instance.GetRoomPriceById(id);

        public int GetRoomTypeId(string roomTypeName) => RoomInformationDAO.Instance.GetRoomTypeNameId(roomTypeName);

        public List<string> GetRoomTypeNameList() => RoomInformationDAO.Instance.GetRoomTypeName();

        public List<int> GetRoomValidList() => RoomInformationDAO.Instance.GetRoomValidList();

        public void InsertRoomInformation(RoomInformation roomInformation) => RoomInformationDAO.Instance.AddNew(roomInformation);

        public IEnumerable<RoomInformation> SearchRoomByRoomNumber(string keyword) => RoomInformationDAO.Instance.SearchRoomByRoomNumber(keyword);    

        public void UpdateRoomInformation(RoomInformation roomInformation) => RoomInformationDAO.Instance.Update(roomInformation);
    }
}
