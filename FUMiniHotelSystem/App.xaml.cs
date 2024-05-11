using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using Repositories.Repo;
using Repositories.IRepo;


namespace FUMiniHotelSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton(typeof(ICustomerRepository), typeof(CustomerRepository));
            services.AddSingleton(typeof(IRoomInformationRepository), typeof(RoomInformationRepository));
            services.AddSingleton(typeof(IBookingDetailRepository), typeof(BookingDetailRepository));
            services.AddSingleton(typeof(IBookingDetailRepository), typeof(BookingDetailRepository));
            services.AddSingleton(typeof(IBookingReservationRepository), typeof(BookingReservationRepository));

            services.AddSingleton<CustomerManagementWindow>();
            services.AddSingleton<RoomInformationManagementWindow>();
            services.AddSingleton<CreateRoomInformationWindow>();
            services.AddSingleton<UpdateRoomInformationWindow>();
            services.AddSingleton<ReportStatisticWindow>();
            services.AddSingleton<BookingReservationWindow>();
            services.AddSingleton<CreateBookingReservationWindow>();
            services.AddSingleton<LoginWindow>();
            services.AddSingleton<AdminMainWindow>();
            services.AddSingleton<CreateCustomerWindow>();
            services.AddSingleton<UpdateCustomerWindow>();
            services.AddSingleton<ManageProfileWindow>();
            services.AddSingleton<ViewBookingHistoryWindow>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var loginWindow = serviceProvider.GetService<LoginWindow>();
            loginWindow.Show();
        }
    }

}
