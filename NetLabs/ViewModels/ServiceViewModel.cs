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
        public ServiceViewModel(Store store)
        {
            service = new GenericService<Service>(store);
            WorkingItem = new Service();

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
