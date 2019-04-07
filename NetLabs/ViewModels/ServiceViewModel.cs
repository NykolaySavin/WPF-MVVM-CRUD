using HotelClasses;
using ModelStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLabs.ViewModels
{
    public class ServiceViewModel : DataViewModel<Service>
    {
        public ServiceViewModel(GenericService<Service> serviceService)
        {
            service = serviceService;
            WorkingItem = new Service();

        }
        public override void Update()
        {

        }
        public override void Edit()
        {
            SelectedItem.Name = WorkingItem.Name;
            SelectedItem.Price = WorkingItem.Price;
            service.Update(SelectedItem);
            NotifyPropertyChanged("Items");
        }
    }
}
