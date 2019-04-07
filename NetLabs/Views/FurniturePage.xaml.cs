using HotelClasses;
using NetLabs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Unity;

namespace NetLabs.Views
{
    /// <summary>
    /// Логика взаимодействия для FurniturePage.xaml
    /// </summary>
    public partial class FurniturePage : UserControl
    {
        public FurniturePage()
        {
            InitializeComponent();
        }
        [Dependency]
        public FurnitureViewModel ViewModel
        {
            set { this.DataContext = value; }
            get { return this.DataContext as FurnitureViewModel; }
        }
    }
}
