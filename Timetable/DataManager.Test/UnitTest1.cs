using DataService.Model.Responses;
using NUnit.Framework;
using System;

namespace DataManager.Test
{
    [TestFixture]
    public class UnitTest1
    {
        Manager manager;
        
        [OneTimeSetUp]
        public void Setup()
        {
            manager = new Manager(new DataService.Service());
        }

        [TestCase("Szentendre")]
        public void TestMethod1(string station)
        {
            var stations = manager.GetStations(station, DateTime.Now);

            Assert.IsTrue(stations.Count > 0);
        }

        [TestCase("Szentendre")]
        public void testmethod2(string station)
        {
            DateTime date = DateTime.Now;
            var stations = manager.GetStations(station, date);

            Station fromStation = stations[1];
            Station ToStation = stations[2];

            var timetables = manager.GetTimeTables(fromStation, ToStation, date);
        }
    }
}
