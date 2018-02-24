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
using System.Xml;
using Windows.Storage;
using System.Xml.Linq;
using Windows.Globalization.DateTimeFormatting;
using Windows.Globalization;
using UI.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Reader reader;
        public MainPage()
        {
            this.InitializeComponent();
            reader = new Reader();
        }

        private void ToSzteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!resultView.Header.Equals("Állomás felé"))
            {
                resultView.Items.Clear();
                resultView.Header = "Állomás felé";
                ShowBuses(Directions.ToAllomas);
            }
        }

        private void ToHomeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!resultView.Header.Equals("Sportpálya felé"))
            {
                resultView.Items.Clear();
                resultView.Header = "Sportpálya felé";
                ShowBuses(Directions.ToSportpalya);
            }
        }

        private void fromBatyi_Click(object sender, RoutedEventArgs e)
        {
            /*if (!resultView.Header.Equals("Hév"))
            {
                resultView.Items.Clear();
                resultView.Header = "Hév";
                LoadBuses(null);
            }*/
        }

        private void ShowBuses(Directions direction)
        {
            List<Bus> list = reader.GetBuses(direction);
            foreach (var item in list)
            {
                ListViewItem viewItem = new ListViewItem
                {
                    Content = string.Format("Indulás: {0} Érkezés: {1}\nMenetidő: {2}\n", item.Departing, item.Arriving, item.TotalTime),
                    HorizontalAlignment = HorizontalAlignment.Center
                };
                resultView.Items.Add(viewItem);
            }
        }
    }
}
