using HotelClasses;
using ModelStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NetLabs.ViewModels
{
    public abstract class FormViewModel<T> :NotifyViewModel where T : Base
    {
        protected IService<T> service;
        protected T workingItem;
        protected T selectedItem;
        public FormViewModel()
        {
        }
        public abstract void Add();
        public abstract void Edit();
        public abstract void Delete();
        public T WorkingItem { get { return workingItem; } set { workingItem = value; NotifyPropertyChanged("WorkingItem"); } }
        public T SelectedItem { get { return selectedItem; } set { selectedItem = value; NotifyPropertyChanged("SelectedItem"); } }
    }
}
