using HotelClasses;
using ModelStore;
using NetLabs.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLabs.ViewModels
{
    public class FurnitureViewModel : FormViewModel<Furniture>
    {
        public FurnitureViewModel(Store store) 
        {
            service = new GenericService<Furniture>(store);
            WorkingItem = new Furniture();
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
        public ObservableCollection<Furniture> Items { get { return service.Get().ToObservableCollection(); } }
    }
}
