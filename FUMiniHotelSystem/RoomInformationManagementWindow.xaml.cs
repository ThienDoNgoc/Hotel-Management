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
    /// Interaction logic for RoomInformationManagementWindow.xaml
    /// </summary>
    public partial class RoomInformationManagementWindow : Window
    {
        IRoomInformationRepository roomInformationRepository;
        public RoomInformationManagementWindow(IRoomInformationRepository repository)
        {
            InitializeComponent();
            roomInformationRepository = repository;
            LoadRoomInformationList();
        }

        private RoomInformation GetRoomInformationObject()
        {
            RoomInformation roomInformation = new RoomInformation();
            try
            {
                roomInformation = new RoomInformation
                {
                    RoomId = int.Parse(RoomIdtxt.Text),
                    RoomNumber = RoomNumbertxt.Text,
                    RoomDetailDescription = RoomDetailDescriptiontxt.Text,
                    RoomMaxCapacity = int.Parse(RoomMaxCapacitytxt.Text),
                    RoomPricePerDay = decimal.Parse(RoomPricePerDaytxt.Text),
                    RoomType = new RoomType { RoomTypeName = RoomTypetxt.Text },
                    RoomTypeId = roomInformationRepository.GetRoomTypeId(RoomTypetxt.Text)

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Room");
            }
            return roomInformation;
        }

        public void LoadRoomInformationList()
        {
            lvRoomInformation.ItemsSource = roomInformationRepository.GetRoomInforamtions();
        }

        private void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            if (RoomNumbertxt.Text!="")
            {
                RoomInformation roomInformation = GetRoomInformationObject(); // Assuming GetRoomInformation() returns a RoomInformation object

                UpdateRoomInformationWindow updateWindow = new UpdateRoomInformationWindow(roomInformationRepository, roomInformation);

                updateWindow.Closed += (s, eventarg) =>
                {
                    LoadRoomInformationList();
                };
                updateWindow.Show();
            }
            else
            {
                MessageBox.Show("Please choose room before action!");
            }

            

        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            if (RoomIdtxt.Text!="")
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        RoomInformation roomInformation = GetRoomInformationObject();
                        roomInformationRepository.DeleteRoomInformation(roomInformation);
                        LoadRoomInformationList();
                        MessageBox.Show($"Room Number: {roomInformation.RoomNumber} delete successfully ", "Deleted room");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Delete room");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose room to delete!");
            }
            
        }

        private void Insertbtn_Click(object sender, RoutedEventArgs e)
        {
            CreateRoomInformationWindow createWindow = new CreateRoomInformationWindow(roomInformationRepository);
            createWindow.Closed += (s, eventarg) =>
            {
                LoadRoomInformationList();
            };
            createWindow.Show();
            
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (keyWordtxt.Text=="")
            {
                LoadRoomInformationList();
            }
            else
            {
                lvRoomInformation.ItemsSource = roomInformationRepository.SearchRoomByRoomNumber(keyWordtxt.Text);
            }
        }
    }
}
