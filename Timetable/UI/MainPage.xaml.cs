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
using Microsoft.Toolkit.Uwp.Notifications;
using UI.Alarmer;
using Microsoft.QueryStringDotNET;
using Windows.UI.Notifications;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Reader reader;
        private NotificationHandler notifHandler;
        public MainPage()
        {
            this.InitializeComponent();
            reader = new Reader();
            notifHandler = new NotificationHandler();
        }
        private void ToSzteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!Header.Text.Equals("Állomás felé"))
            {
                resultView.Items.Clear();
                Header.Text = "Állomás felé";
                ShowBuses(Directions.BusToAllomas);
            }
        }

        private void ToHomeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!Header.Text.Equals("Sportpálya felé"))
            {
                resultView.Items.Clear();
                Header.Text = "Sportpálya felé";
                ShowBuses(Directions.BusToSportpalya);
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
            foreach (Bus bus in list)
            {
                ListViewItem viewItem = new ListViewItem
                {
                    Content = bus,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    DataContext = bus
                };
                if (bus.IsSet) { viewItem.Background = new SolidColorBrush(Windows.UI.Colors.LightGray); }
                viewItem.Tapped += ViewItem_Tapped;
                resultView.Items.Add(viewItem);
            }
        }
       
        private void ViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var listItem = sender as ListViewItem;
            Bus bus = listItem.DataContext as Bus;
            if (!bus.IsSet)
            {
                notifHandler.SetNotification(bus, listItem);
            }
            else
            {
                notifHandler.RemoveNotification(bus, listItem);
            }
        }
    }
}
