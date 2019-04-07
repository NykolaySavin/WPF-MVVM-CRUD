using HotelClasses;
using ModelStore;
using NetLabs.ViewModels;
using NetLabs.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using Unity.Injection;

namespace NetLabs
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ModelStore.Store store = new ModelStore.Store();
            IUnityContainer container = new UnityContainer();
            GenericService<Order> orderService = new GenericService<Order>(store);
            GenericService<Furniture> furnitureService = new GenericService<Furniture>(store);
            GenericService<Client> clientService = new GenericService<Client>(store);
            GenericService<Service> serviceService = new GenericService<Service>(store);
            GenericService<Room> roomService = new GenericService<Room>(store);
            container.RegisterType< FurnitureViewModel>(new InjectionConstructor(new object[] {furnitureService,roomService }));
            container.RegisterType< OrderViewModel>(new InjectionConstructor(new object[] {orderService,roomService,clientService,serviceService }));
            container.RegisterType<ServiceViewModel>(new InjectionConstructor(new object[] { serviceService }));
            container.RegisterType<RoomViewModel>(new InjectionConstructor(new object[] { roomService }));
            container.RegisterType<ClientViewModel>(new InjectionConstructor(new object[] { clientService }));
            container.RegisterType<RoomPage>(new InjectionProperty("ViewModel", container.Resolve<RoomViewModel>()));
            container.RegisterType<OrderPage>(new InjectionProperty("ViewModel", container.Resolve<OrderViewModel>()));
            container.RegisterType<ClientPage>(new InjectionProperty("ViewModel", container.Resolve<ClientViewModel>()));
            container.RegisterType<FurniturePage>(new InjectionProperty("ViewModel", container.Resolve<FurnitureViewModel>()));
            container.RegisterType<ServicePage>(new InjectionProperty("ViewModel", container.Resolve<ServiceViewModel>()));
            container.RegisterType<MainViewModel>(new InjectionConstructor(new object[] {container.Resolve<FurniturePage>(), container.Resolve<OrderPage>(), container.Resolve<ClientPage>(), container.Resolve<ServicePage>(), container.Resolve<RoomPage>() }));
            container.RegisterType<MainWindow>(new InjectionProperty("ViewModel",container.Resolve<MainViewModel>()));
            MainWindow window = container.Resolve<MainWindow>();
            window.Show();
        }
        
       
    }
}
