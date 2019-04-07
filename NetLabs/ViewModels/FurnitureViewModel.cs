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
    public class FurnitureViewModel : DataViewModel<Furniture>
    {
        private GenericService<Room> roomService;
        public FurnitureViewModel(GenericService<Furniture> furnitureService, GenericService<Room> roomService) 
        {
            service = furnitureService;
            this.roomService = roomService;
            WorkingItem = new Furniture();
        }
        public ObservableCollection<Room> Rooms { get { return roomService.Get().ToObservableCollection(); } }
        public override void Edit()
        {
            SelectedItem.Name = WorkingItem.Name;
            SelectedItem.Price = WorkingItem.Price;
            SelectedItem.Room = WorkingItem.Room;
            service.Update(SelectedItem);
            NotifyPropertyChanged("Items");
        }

        public override void Update()
        {
            NotifyPropertyChanged("Rooms");
        }
    }
}
