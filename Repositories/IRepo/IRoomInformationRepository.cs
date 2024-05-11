using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepo
{
    public interface IRoomInformationRepository
    {
        IEnumerable<RoomInformation> GetRoomInforamtions();
        IEnumerable<RoomInformation> SearchRoomByRoomNumber(string keyword);

        RoomInformation GetRoomInformationByID(int id);
        List<int> GetRoomValidList();
        bool CheckRoomNumberExist(string roomNumber);

        decimal? GetRoomPriceById(int id);
        void InsertRoomInformation(RoomInformation roomInformation);
        void UpdateRoomInformation(RoomInformation roomInformation);
        void DeleteRoomInformation(RoomInformation roomInformation);
        int GetRoomTypeId(string roomTypeName);
        List<String> GetRoomTypeNameList();
    }
}
