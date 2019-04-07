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
        public ClientViewModel(Store store)
        {
            service = new GenericService<Client>(store);
            WorkingItem = new Client();

        }

        public override void Add()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Edit()
        {
            throw new NotImplementedException();
        }
    }
}
