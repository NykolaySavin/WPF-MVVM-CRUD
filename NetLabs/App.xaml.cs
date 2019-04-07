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
            Store store = new Store();
            IUnityContainer container = new UnityContainer();

            container.RegisterType<FormViewModel<Furniture>, FurnitureViewModel>(new InjectionConstructor(store));
            container.RegisterType<FormViewModel<Order>, OrderViewModel>(new InjectionConstructor(store));
            container.RegisterType<FormViewModel<Service>, ServiceViewModel>(new InjectionConstructor(store));
            container.RegisterType<FormViewModel<Room>, RoomViewModel>(new InjectionConstructor(store));
            container.RegisterType<FormViewModel<Client>, ClientViewModel>(new InjectionConstructor(store));
            container.RegisterType<RoomPage>(new InjectionProperty("ViewModel", container.Resolve<FormViewModel<Room>>()));
            container.RegisterType<OrderPage>(new InjectionProperty("ViewModel", container.Resolve<FormViewModel<Order>>()));
            container.RegisterType<ClientPage>(new InjectionProperty("ViewModel", container.Resolve<FormViewModel<Client>>()));
            container.RegisterType<FurniturePage>(new InjectionProperty("ViewModel", container.Resolve<FormViewModel<Furniture>>()));
            container.RegisterType<ServicePage>(new InjectionProperty("ViewModel", container.Resolve<FormViewModel<Service>>()));
            container.RegisterType<MainViewModel>(new InjectionConstructor(new object[] {container.Resolve<FurniturePage>(), container.Resolve<OrderPage>(), container.Resolve<ClientPage>(), container.Resolve<ServicePage>(), container.Resolve<RoomPage>() }));
            container.RegisterType<MainWindow>(new InjectionProperty("ViewModel",container.Resolve<MainViewModel>()));
            MainWindow window = container.Resolve<MainWindow>();
            window.Show();
        }
        
       
    }
}
