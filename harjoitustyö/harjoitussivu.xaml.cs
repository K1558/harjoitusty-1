﻿using System;
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
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Protection.PlayReady;
using System.Threading.Tasks;
using System.Text;
using Windows.Storage.Pickers;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace harjoitustyö
{
    /// <summary>
    /// *Ella Viitasuo Olio-ohjelmointi kurssi*
    /// Sivu jossa harjoitus lisätään 
    /// FilePickerin avulla tiedostoon tallentaminen
    /// </summary>
    public sealed partial class harjoitussivu : Page
    {
        private Harjoitus harjoitus;
        public harjoitussivu()
        {
            this.InitializeComponent();


        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider fiilis = sender as Slider;
            // int prosentit;
            if (fiilis != null)
            {
                //prosentit = fiilis.Value;
            }
        }

        private void fiilis_ContextCanceled(UIElement sender, RoutedEventArgs args)
        {

        }




        private async void ShowMessageBox(string message)
        {
            var messageDialog = new MessageDialog(message);
            messageDialog.Commands.Add(new UICommand("Ok"));
            messageDialog.DefaultCommandIndex = 0;
            await messageDialog.ShowAsync();
        }




        private async void Valmis_Click(object sender, RoutedEventArgs e)
        {
            //FilePicker
            FileOpenPicker picker = new FileOpenPicker();
            //Valitse tiedosto
            picker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            picker.ViewMode = PickerViewMode.List;
            picker.FileTypeFilter.Add(".txt");

           
            StorageFile result = await picker.PickSingleFileAsync();

            if (result != null)
            {
                try
                {
                    // lisaa tekstia
                    await FileIO.AppendTextAsync(result, Data.Text);
                    // onnistunut tallennus
                    ShowMessageBox("Tallennus onnistui!");
                }
                catch (Exception ex)
                {
                    // error message
                    ShowMessageBox(ex.Message);
                }
            }
            else
                ShowMessageBox("Joitain meni vikaan...");
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Tallenna_Click(object sender, RoutedEventArgs e)
        {

            try
            {


                Harjoitus harjoitus = new Harjoitus();

                string paiva = kalenteri.Date.ToString();


                paiva = kalenteri.Date.ToString();
                harjoitus.Paiva = paiva;
                harjoitus.Laji = laji.Text;
                harjoitus.MaxSyke = max.Text;
                harjoitus.AvgSyke = avg.Text;
                harjoitus.Kalorit = kalorit.Text;
                harjoitus.Kommentit = kommentit.Text;
                harjoitus.Fiilis = slidervalue.Text;

                string line = harjoitus.Paiva + " Laji: " + harjoitus.Laji + " MaxSyke: " + harjoitus.MaxSyke + " KeskiSyke: " + harjoitus.AvgSyke + " Kalorit: " + harjoitus.Kalorit + " Kommentit: " + harjoitus.Kommentit + " : " + harjoitus.Fiilis + Environment.NewLine;
                Data.Text = line;
                Data.Text = line;


            }
            catch (Exception ex)
            {
                ShowMessageBox(ex.Message);
            }


        }

    }
}

