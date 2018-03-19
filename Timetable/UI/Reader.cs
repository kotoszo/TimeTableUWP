using System;
using UI.Models;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Windows.ApplicationModel;
using Windows.UI.Notifications;
using System.Collections.Generic;

namespace UI
{
    enum Directions { BusToSportpalya, BusToAllomas, HevFromMargit, HevToMargit }
    class Reader
    {
        Dictionary<Directions, string> XmlFiles;
        private Dictionary<Directions, List<Bus>> loadedBuses;
        internal Reader()
        {
            loadedBuses = new Dictionary<Directions, List<Bus>>();
            XmlFiles = new Dictionary<Directions, string>()
            {
                { Directions.BusToSportpalya, "BusToSportpalya.xml" },
                { Directions.BusToAllomas, "BusToAllomas.xml" },
                { Directions.HevFromMargit, "HevFromMargit.xml" },
                { Directions.HevToMargit, "HevToMargit.xml" }
            };
        }
        internal List<Bus> GetBuses(Directions direction)
        {
            int currentTime = GetTime();
            if (!loadedBuses.ContainsKey(direction))
            {
                IEnumerable<Bus> buses = AllTheBuses(direction);
                List<Bus> resultList = new List<Bus>();
                foreach (Bus bus in buses)
                {
                    if(currentTime < bus.MilitaryTIme)
                    {
                        if (IsNotificationSet(bus.Departing)) { bus.IsSet = true; }
                        resultList.Add(bus);
                    }
                }
                loadedBuses.Add(direction, resultList);
            }
            else
            {
                UpdatePossibleBuses(direction, currentTime);
            }
            return loadedBuses[direction];
        }
        private IEnumerable<Bus> AllTheBuses(Directions direction)
        {
            return Xml(XmlFiles[direction]);
        }
        private IEnumerable<Bus> Xml(string fileName)
        {
            string correctPath = "Datas\\" + fileName;
            string XMLPath = Path.Combine(Package.Current.InstalledLocation.Path, correctPath);
            XDocument loadedData = XDocument.Load(XMLPath);
            var data = from query in loadedData.Descendants("bus")
                select new Bus
                {
                    Arriving = (string)query.Attribute("arriving"),
                    Departing = (string)query.Attribute("departing"),
                    TravellingTime = (string)query.Attribute("total"),
                };
            return data;
        }
        private int GetTime()
        {
            int hour = DateTime.Now.Hour*100;
            int minute = DateTime.Now.Minute;
            return hour + minute;
        }
        private void UpdatePossibleBuses(Directions direction, int currentTime)
        {
            bool isCurrent = false;
            int index = 0;
            while (!isCurrent)
            {
                if (currentTime >= loadedBuses[direction][index].MilitaryTIme)
                {
                    loadedBuses[direction].RemoveAt(index);
                }
                else
                {
                    isCurrent = true;
                }
            }
        }
        private bool IsNotificationSet(string departing)
        {
            var notifications = ToastNotificationManager.CreateToastNotifier().GetScheduledToastNotifications();
            foreach (var notif in notifications)
            {
                if (notif.Id.Equals(departing)) { return true; }
            }
            return false;
        }
    }
}
