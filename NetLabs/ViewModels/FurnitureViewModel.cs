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
        public FurnitureViewModel(Store store) 
        {
            service = new GenericService<Furniture>(store);
            WorkingItem = new Furniture();
        }
       
        public ObservableCollection<Furniture> Items { get { return service.Get().ToObservableCollection(); } }

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
