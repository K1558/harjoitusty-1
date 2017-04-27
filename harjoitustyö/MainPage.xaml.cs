using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace harjoitustyö
{
    /// <summary>
    /// *Ella Viitasuo Olio-ohjelmointi kurssi*
    /// Pääsivu jolla navigoidaan muille sivuille
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();


        }

        //Navigointi harjoitussivulle
        private void harjoitus_Click(object sender, RoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(harjoitussivu));
        }

        //Navigointi logisivulle
        private void logi_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(harjoituslogisivu));
        }

      
    }



}

