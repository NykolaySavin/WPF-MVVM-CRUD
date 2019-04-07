using ModelStore;
using NetLabs.Helpers;
using NetLabs.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace NetLabs.ViewModels
{
    public class MainViewModel :NotifyViewModel
    {
        private FurniturePage furniturePage;
        private OrderPage orderPage;
        private ClientPage clientPage;
        private ServicePage servicePage;
        private RoomPage roomPage;
        public MainViewModel(FurniturePage furniturePage,OrderPage orderPage,ClientPage clientPage,ServicePage servicePage,RoomPage roomPage)
        {
            this.furniturePage = furniturePage;
            this.orderPage =orderPage;
            this.roomPage = roomPage;
            this.clientPage =clientPage;
            this.servicePage = servicePage;
            SetFurniturePage = new DelegateCommand((o) => { control = furniturePage; form = furniturePage.ViewModel; NotifyPropertyChanged("CurrentPage"); NotifyPropertyChanged("Form"); furniturePage.ViewModel.Update(); });
            SetOrderPage = new DelegateCommand((o) => { control = orderPage; form = orderPage.ViewModel; NotifyPropertyChanged("CurrentPage"); NotifyPropertyChanged("Form"); orderPage.ViewModel.Update(); });
            SetRoomPage = new DelegateCommand((o) => { control = roomPage; form = roomPage.ViewModel; NotifyPropertyChanged("CurrentPage"); NotifyPropertyChanged("Form"); roomPage.ViewModel.Update(); });
            SetServicePage = new DelegateCommand((o) => { control = servicePage; form = servicePage.ViewModel; NotifyPropertyChanged("CurrentPage"); NotifyPropertyChanged("Form"); servicePage.ViewModel.Update(); });
            SetClientPage = new DelegateCommand((o) => { control = clientPage; form = clientPage.ViewModel; NotifyPropertyChanged("CurrentPage"); NotifyPropertyChanged("Form"); clientPage.ViewModel.Update(); });
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
        private FormViewModel form;
        public FormViewModel Form
        {
            get { return form; }
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
