using BusinessObjects;
using Repositories.IRepo;
using Repositories.Repo;
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
    /// Interaction logic for UpdateRoomInformationWindow.xaml
    /// </summary>
    public partial class UpdateRoomInformationWindow : Window
    {
        IRoomInformationRepository roomInformationRepository;
        public RoomInformation _roomInformation { get; set; }
        public UpdateRoomInformationWindow(IRoomInformationRepository _roomInformationRepository, RoomInformation roomInformation)
        {
            InitializeComponent();
            roomInformationRepository = _roomInformationRepository;
            _roomInformation = roomInformation;
            LoadRoomTypeNameList();
        }
        public void LoadRoomTypeNameList()
        {
            RoomNumbertxt.Text = _roomInformation.RoomNumber;
            RoomDetailDescriptiontxt.Text = _roomInformation.RoomDetailDescription;
            RoomMaxCapacitytxt.Text = _roomInformation.RoomMaxCapacity.ToString();
            RoomTypetxt.ItemsSource = roomInformationRepository.GetRoomTypeNameList();
            RoomTypetxt.Text = _roomInformation.RoomType.RoomTypeName;

            RoomPricePerDaytxt.Text = _roomInformation.RoomPricePerDay.ToString();
        }

        private void UpdateRoomInformation_Click(object sender, RoutedEventArgs e)
        {
            int checkInt;
            decimal checkDecimal;

            if (RoomNumbertxt.Text==""||RoomTypetxt.Text==""||RoomDetailDescriptiontxt.Text==""||RoomPricePerDaytxt.Text=="")
            {
                MessageBox.Show("Please input all neccessary information!");
            }
            else
            {
                if (!roomInformationRepository.CheckRoomNumberExist(RoomNumbertxt.Text))
                {
                    if (decimal.TryParse(RoomPricePerDaytxt.Text, out checkDecimal) && int.TryParse(RoomMaxCapacitytxt.Text, out checkInt))
                    {
                        var roomInformation = new RoomInformation
                        {
                            RoomId = _roomInformation.RoomId,
                            RoomNumber = RoomNumbertxt.Text,
                            RoomDetailDescription = RoomDetailDescriptiontxt.Text,
                            RoomMaxCapacity = int.Parse(RoomMaxCapacitytxt.Text),
                            RoomPricePerDay = decimal.Parse(RoomPricePerDaytxt.Text),
                            RoomType = new RoomType { RoomTypeName = RoomTypetxt.Text },
                            RoomTypeId = roomInformationRepository.GetRoomTypeId(RoomTypetxt.Text)
                        };

                        try
                        {
                            roomInformationRepository.UpdateRoomInformation(roomInformation);
                            MessageBox.Show($"Room Number: {roomInformation.RoomNumber} Update successfully ", "Updated room");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Update room");
                        }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please input Capacity/Price correctly!");
                    }
                }
                else
                {
                    MessageBox.Show("This room number has been exist!");
                }

                
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
