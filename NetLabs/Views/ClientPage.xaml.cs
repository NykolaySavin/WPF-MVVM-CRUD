﻿using HotelClasses;
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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : UserControl
    {
        public ClientPage()
        {
            InitializeComponent();
        }
        [Dependency]
        public ClientViewModel ViewModel
        {
            set { this.DataContext = value; }
            get { return this.DataContext as ClientViewModel; }
        }
    }
}
