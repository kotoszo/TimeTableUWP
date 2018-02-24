using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using UI.Models;
using Windows.ApplicationModel;
using Windows.Data.Json;
using Windows.Globalization;
using Windows.Globalization.DateTimeFormatting;
using Windows.Storage;

namespace UI
{
    enum Directions { ToSportpalya, ToAllomas, ToMargit }
    class Reader
    {
        Dictionary<Directions, string> XmlFiles;
        internal Reader()
        {
            XmlFiles = new Dictionary<Directions, string>()
            {
                { Directions.ToSportpalya, "XmlToSportpalya.xml" },
                { Directions.ToAllomas, "XmlToAllomas.xml" },
                { Directions.ToMargit, "XmlFromMargit.xml" }
            };
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
                    TotalTime= (string)query.Attribute("total"),
                };
            return data;
        }
        
        internal List<Bus> GetBuses(Directions direction)
        {
            IEnumerable<Bus> list = AllTheBuses(direction);
            int result = GetTime();
            List<Bus> resultList = new List<Bus>();
            foreach (var item in list)
            {
                if(result < item.Value)
                {
                    resultList.Add(item);
                }
            }
            return resultList;
        }
        private IEnumerable<Bus> AllTheBuses(Directions direction)
        {
            return Xml(XmlFiles[direction]);
        }
        private int GetTime()
        {
            DateTimeFormatter timeFormatter = new DateTimeFormatter("hour minute", new[] { "HU" });
            string correctTime = timeFormatter.Format(DateTime.Now);
            string stringTime = "";
            foreach (var item in correctTime)
            {
                if (int.TryParse(item.ToString(), out int rea))
                    stringTime += item;
            }
            int.TryParse(stringTime, out int result);
            return result;
        }
    }
}
