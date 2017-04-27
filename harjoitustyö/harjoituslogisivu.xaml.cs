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
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace harjoitustyö
{
    /// <summary>
    /// *Ella Viitasuo Olio-ohjelmointi kurssi
    /// Sivu jossa harjoitukset luetaan valitusta tiedostosta
    /// Mahdollisia fiksauksia tiedostoon lukemiseen lisättävä myöhemmin
    /// >> ei messageboxiin vaan textblock
    /// </summary>
    public sealed partial class harjoituslogisivu : Page

    {
        public harjoituslogisivu()
        {
            this.InitializeComponent();

        }

        private async void ShowMessageBox(string message)
        {
            var messageDialog = new MessageDialog(message);
            messageDialog.Commands.Add(new UICommand("Ok"));
            messageDialog.DefaultCommandIndex = 0;
            await messageDialog.ShowAsync();
        }

        private async void Lue_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //FilePicker
                FileOpenPicker picker = new FileOpenPicker();
                // valitse valmis tiedosto 
                picker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
                picker.ViewMode = PickerViewMode.List;
                picker.FileTypeFilter.Add(".txt");

                StorageFile result = await picker.PickSingleFileAsync();

                if (result != null)
                {
                    try
                    {
                        // lue valittu tiedosto
                        ShowMessageBox(await FileIO.ReadTextAsync(result));


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
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }


        }
        private void b5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }



}
