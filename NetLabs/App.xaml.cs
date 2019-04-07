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

            container.RegisterType< FurnitureViewModel>(new InjectionConstructor(store));
            container.RegisterType< OrderViewModel>(new InjectionConstructor(store));
            container.RegisterType<ServiceViewModel>(new InjectionConstructor(store));
            container.RegisterType<RoomViewModel>(new InjectionConstructor(store));
            container.RegisterType<ClientViewModel>(new InjectionConstructor(store));
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
