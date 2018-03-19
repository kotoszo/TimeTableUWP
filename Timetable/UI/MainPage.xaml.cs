using UI.Models;
using UI.Alarmer;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Controls;
using System.Collections.Generic;

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
                NotificationHandler.SetNotification(bus, listItem);
            }
            else
            {
                NotificationHandler.RemoveNotification(bus, listItem);
            }
        }
    }
}
