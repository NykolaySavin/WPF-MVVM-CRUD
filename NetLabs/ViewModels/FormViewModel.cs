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
    public abstract class DataViewModel<T> :FormViewModel where T : Base
    {
        protected IService<T> service;
        protected T workingItem;
        protected T selectedItem;
        public DataViewModel()
        {
        }
        public override void Add()
        {
            service.Create(WorkingItem);
            NotifyPropertyChanged("Items");
        }

        public override void Delete()
        {
            service.Remove(SelectedItem);
            NotifyPropertyChanged("Items");
        }
        public ObservableCollection<T> Items { get { return service.Get().ToObservableCollection(); } }
        public T WorkingItem { get { return workingItem; } set { workingItem = value; NotifyPropertyChanged("WorkingItem"); } }
        public T SelectedItem { get { return selectedItem; } set { selectedItem = value; NotifyPropertyChanged("SelectedItem"); } }
    }
    public abstract class FormViewModel : NotifyViewModel, IForm
    {
        public FormViewModel()
        {
            addCommand = new DelegateCommand((o) => { Add(); Update(); });
            editCommand = new DelegateCommand((o) => { Edit(); Update(); });
            deleteCommand = new DelegateCommand((o) => { Delete();Update(); });
        }
        private ICommand addCommand;
        private ICommand editCommand;
        private ICommand deleteCommand;
        public ICommand AddCommand { get => addCommand; }
        public ICommand EditCommand { get => editCommand; }
        public ICommand DeleteCommand { get => deleteCommand; }

        public abstract void Add();

        public abstract void Delete();

        public abstract void Edit();
    }
}
