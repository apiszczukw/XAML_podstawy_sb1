using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XAML_podstawy_sb1.Klasy;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace XAML_podstawy_sb1
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ZapiszBtn_Click(object sender, RoutedEventArgs e)
        {
            Osoba osoba = new Osoba()
            {
                Imie = ImieTbx.Text,
                Nazwisko = NazwiskoTbx.Text
            };

            var wiadomosc = new ContentDialog()
            {
                Title = "Powitanie",
                Content = osoba.ToString(),
                CloseButtonText = "Zamknij",
                PrimaryButtonText = "Ok"
            };

            await wiadomosc.ShowAsync();

            ImieTbx.Text = "";
            NazwiskoTbx.Text = "";
        }
    }
}
