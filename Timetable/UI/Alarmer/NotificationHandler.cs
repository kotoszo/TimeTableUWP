using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Models;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace UI.Alarmer
{
    public class NotificationHandler
    {
        public void SetNotification(Bus bus, ListViewItem listItem)
        {
            listItem.Background = new SolidColorBrush(Windows.UI.Colors.LightGray);
            bus.IsSet = true;
            int alarmHour = bus.MilitaryTIme / 100;
            int alarmMinute = (bus.MilitaryTIme % 100) - 15;
            if(alarmMinute < 0)
            {
                alarmHour -= 1;
                alarmMinute += 60;
            }
            DateTime alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, alarmHour, alarmMinute, 0);
            ToastContent testToastContent = new ToastContent()
            {
                Visual = ToastMaker.GetVisual(bus),
            };

            // Create the scheduled notification
            var scheduledNotif = new ScheduledToastNotification(testToastContent.GetXml(), alarmTime)
            {
                Id = bus.Departing
            };
            ToastNotificationManager.CreateToastNotifier().AddToSchedule(scheduledNotif);
        }

        public void RemoveNotification(Bus bus, ListViewItem listItem)
        {
            bus.IsSet = false;
            listItem.Background = new SolidColorBrush(Windows.UI.Colors.White);
            var notifications = ToastNotificationManager.CreateToastNotifier().GetScheduledToastNotifications();
            foreach (var notif in notifications)
            {
                if (notif.Id.Equals(bus.Departing))
                {
                    ToastNotificationManager.CreateToastNotifier().RemoveFromSchedule(notif);
                }
            }
        }
    }
}
