using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using CefSharp;
using CefSharp.Wpf;

namespace Youtube.tv.win
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //Prepara o Cef sharp para inicializar
            var settings = new CefSettings();

            settings.CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Open Source Youtube TV\\Cache");
            settings.UserAgent = "Mozilla / 5.0(SMART - TV; Linux; Tizen 2.4.0) AppleWebkit / 538.1(KHTML, like Gecko) SamsungBrowser / 1.1 TV Safari/ 538.1";
            Cef.Initialize(settings);





        }
    }
}

