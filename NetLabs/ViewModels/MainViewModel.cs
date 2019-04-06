using NetLabs.Helpers;
using NetLabs.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace NetLabs.ViewModels
{
    public class MainViewModel :  INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private FurniturePage furniturePage;
        private OrderPage orderPage;
        private ClientPage clientPage;
        private ServicePage servicePage;
        private RoomPage roomPage;
        public MainViewModel()
        {
            furniturePage = new FurniturePage();
            orderPage = new OrderPage();
            roomPage = new RoomPage();
            clientPage = new ClientPage();
            servicePage = new ServicePage();
            SetFurniturePage = new DelegateCommand((o) => { control = furniturePage; NotifyPropertyChanged("CurrentPage"); });
            SetOrderPage = new DelegateCommand((o) => { control = orderPage; NotifyPropertyChanged("CurrentPage"); });
            SetRoomPage = new DelegateCommand((o) => { control = roomPage; NotifyPropertyChanged("CurrentPage"); });
            SetServicePage = new DelegateCommand((o) => { control = servicePage; NotifyPropertyChanged("CurrentPage"); });
            SetClientPage = new DelegateCommand((o) => { control = clientPage; NotifyPropertyChanged("CurrentPage"); });
        }
        public ICommand SetFurniturePage
        {
            get;
        }
        public ICommand SetOrderPage
        {
            get;
        }
        public ICommand SetRoomPage
        {
            get;
        }
        public ICommand SetServicePage
        {
            get;
        }
        public ICommand SetClientPage
        {
            get;
        }
        private UserControl control;
        public UserControl CurrentPage
        {
            get { return control; }
        }
    }
}
