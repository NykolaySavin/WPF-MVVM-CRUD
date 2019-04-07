using HotelClasses;
using ModelStore;
using NetLabs.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetLabs.ViewModels
{
    public class OrderViewModel : DataViewModel<Order>
    {
        private GenericService<Room> roomService;
        private GenericService<Client> clientService;
        private GenericService<Service> serviceService;
        public override void Update()
        {
            NotifyPropertyChanged("Rooms");
            
            NotifyPropertyChanged("Clients");
            NotifyPropertyChanged("Service");
            NotifyPropertyChanged("Services");
            NotifyPropertyChanged("WorkingItem");
            NotifyPropertyChanged("SelectedItem");
            NotifyPropertyChanged("Items");
        }
        public OrderViewModel(GenericService<Order> orderService, GenericService<Room> roomService, GenericService<Client> clientService, GenericService<Service> serviceService)
        {
            service = orderService;
            this.roomService = roomService;
            this.clientService = clientService;
            this.serviceService = serviceService;
            WorkingItem = new Order();
            finishOrderCommand = new DelegateCommand((o) =>{ if (SelectedItem == null ) return; SelectedItem.FinishOrder(); service.Update(SelectedItem);SelectedItem.Room.State = RoomState.Free;roomService.Update(SelectedItem.Room); NotifyPropertyChanged("Items");Update(); });
            useServiceCommand = new DelegateCommand((o) => { if (SelectedItem == null || SelectedItem.EndDate == null || Service==null) return; SelectedItem.UseService(Service); service.Update(SelectedItem);  NotifyPropertyChanged("Items"); });
        }
        public ObservableCollection<Room> Rooms { get { return roomService.Get((room)=>room.State==RoomState.Free).ToObservableCollection(); } }
        public ObservableCollection<Service> Services { get { return serviceService.Get().ToObservableCollection(); } }
        public Service Service { get; set; }
        public ObservableCollection<Client> Clients { get { return clientService.Get().ToObservableCollection(); } }
        public override void Add()
        {
            base.Add();
            WorkingItem.Room.State = RoomState.Occupied;
            roomService.Update(WorkingItem.Room);
            
            Update();
        }
        public override void Edit()
        {
        }
        private ICommand useServiceCommand;
        private ICommand finishOrderCommand;
        public ICommand FinishOrderCommand { get => finishOrderCommand; }
        public ICommand UseServiceCommand { get => useServiceCommand; }
    }
}
