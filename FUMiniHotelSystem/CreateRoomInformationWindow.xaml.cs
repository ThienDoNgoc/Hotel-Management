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
    /// Interaction logic for CreateRoomInformationWindow.xaml
    /// </summary>
    public partial class CreateRoomInformationWindow : Window
    {
        IRoomInformationRepository roomInformationRepository;
        public CreateRoomInformationWindow(IRoomInformationRepository repository)
        {
            InitializeComponent();
            roomInformationRepository = repository;
            LoadRoomTypeNameList();
        }

        public void LoadRoomTypeNameList()
        {
            RoomTypetxt.ItemsSource = roomInformationRepository.GetRoomTypeNameList();
        }

        private void AddRoomInformation_Click(object sender, RoutedEventArgs e)
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
                            RoomNumber = RoomNumbertxt.Text,
                            RoomDetailDescription = RoomDetailDescriptiontxt.Text,
                            RoomMaxCapacity = int.Parse(RoomMaxCapacitytxt.Text),
                            RoomPricePerDay = decimal.Parse(RoomPricePerDaytxt.Text),
                            RoomTypeId = roomInformationRepository.GetRoomTypeId(RoomTypetxt.Text)
                        };

                        try
                        {
                            roomInformationRepository.InsertRoomInformation(roomInformation);
                            MessageBox.Show($"Room Number: {roomInformation.RoomNumber} Insert successfully ", "Inserted room");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Insert room");
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
                    MessageBox.Show("This room has been exist!");
                }
                
                
            }                  
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
