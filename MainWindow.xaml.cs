﻿using System;
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
using CefSharp.Wpf;
using CefSharp;

namespace Youtube.tv.win
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ui_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Cef.Shutdown();
        }
        bool telacheia = false;
        private void ui_KeyDown(object sender, KeyEventArgs e)
        {
         
            if (e.Key == Key.F11)
            {

                if (telacheia == false)
                {
                    this.Topmost = true;
                    this.WindowState = WindowState.Maximized;
                    this.WindowStyle = WindowStyle.None;
                    telacheia = true;
                }
                else
                {

                    this.WindowState = WindowState.Normal;
                    this.WindowStyle = WindowStyle.ThreeDBorderWindow;
                    this.Topmost = false;
                    telacheia = false;

                }

            }          
           
                                                                                       
        }
    }
}
