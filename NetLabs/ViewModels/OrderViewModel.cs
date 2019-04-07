using HotelClasses;
using ModelStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLabs.ViewModels
{
    public class OrderViewModel : DataViewModel<Order>
    {
        public OrderViewModel(Store store)
        {
            service = new GenericService<Order>(store);
            WorkingItem = new Order();

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
