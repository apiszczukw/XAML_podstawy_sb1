using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;
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
using XAML_podstawy_sb1.Klasy;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace XAML_podstawy_sb1
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Uczestnicy uczestnicy = new Uczestnicy();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ZapiszBtn_Click(object sender, RoutedEventArgs e)
        {
            var przedmioty = new List<Przedmiot>
            {
                new Przedmiot() { Nazwa = "Analiza matematyczna", LiczbaGodzin = 15 },
                new Przedmiot() { Nazwa = "Programowanie", LiczbaGodzin = 30 }
            };

            Osoba osoba = new Osoba()
            {
                Imie = ImieTbx.Text,
                Nazwisko = NazwiskoTbx.Text,
                Przedmioty = przedmioty
            };

            var wiadomosc = new ContentDialog()
            {
                Title = osoba.ToString(),
                Content = "Twoje dane zostały tymczasowo zapisane\nMożesz kontynuować wpisywanie kolejnych osób, jeśli skończysz wciśnij Zapisz do XML",
                CloseButtonText = "Zamknij",
                PrimaryButtonText = "Ok"
            };

            await wiadomosc.ShowAsync();

            uczestnicy.listaOsob.Add(osoba);

            ImieTbx.Text = "";
            NazwiskoTbx.Text = "";

            ImieTbx.Focus(FocusState.Programmatic);
        }

        private void ZapiszDoXmlBtn_Click(object sender, RoutedEventArgs e)
        {
            var path = ApplicationData.Current.LocalFolder.Path;

            XmlHelper.SerializeToXml<Uczestnicy>(uczestnicy, path + "\\osoby.xml");
        }
    }
}
