﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace MVVM_1_Demo
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        OrderViewModel OrderViewModel;
        public MainPage()
        {
            this.InitializeComponent();

            OrderViewModel = new OrderViewModel();
            LayoutRoot.DataContext = OrderViewModel;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            System.Threading.Tasks.Task.Delay(5000);
            OrderViewModel.AddData();
        }
    }
}
