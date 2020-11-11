﻿using Microsoft.Practices.Unity;
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
using System.Windows.Shapes;
using WPFSample.App.ViewModels;

namespace WPFSample.App.Views
{
    /// <summary>
    /// Interaction logic for ProductFormWindow.xaml
    /// </summary>
    public partial class ProductFormWindow : Window
    {
        [Dependency]
        public ProductFormWindowViewModel ViewModel
        {
            set { DataContext = value; }
        }

        public ProductFormWindow()
        {
            InitializeComponent();
        }
    }
}