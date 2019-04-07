using HotelClasses;
using ModelStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetLabs.ViewModels
{
    public class ClientViewModel : DataViewModel<Client>
    {
        public override void Update()
        {
            
        }
        public ClientViewModel(GenericService<Client> clientService)
        {
            service = clientService;
            WorkingItem = new Client();

        }
        public override void Edit()
        {
            SelectedItem.Name = WorkingItem.Name;
            SelectedItem.Email = WorkingItem.Email;
            SelectedItem.Phone = WorkingItem.Phone;
            SelectedItem.Surname = WorkingItem.Surname;
            service.Update(SelectedItem);
            NotifyPropertyChanged("Items");
        }
    }
}
