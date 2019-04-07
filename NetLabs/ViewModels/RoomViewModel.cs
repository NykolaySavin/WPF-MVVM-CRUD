using HotelClasses;
using ModelStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLabs.ViewModels
{
    public class RoomViewModel : DataViewModel<Room>
    {
        public RoomViewModel(GenericService<Room> roomService)
        {
            service = roomService;
            WorkingItem = new Room();

        }
        public override void Update()
        {

        }
        public override void Edit()
        {
            SelectedItem.Number = WorkingItem.Number;
            service.Update(SelectedItem);
            NotifyPropertyChanged("Items");
        }
    }
}
