using DataService;
using NUnit.Framework;
using DataService.Model.Requests;
using DataService.Model.Responses;

namespace DataServiceTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("szentendre")]
        [TestCase("esztergom")]
        public async System.Threading.Tasks.Task StationSearch_Should_ReturnStations(string station)
        {
            var request = Helper.GetStationSearchRequest(station);
            var result = await Service.PostAsync<StationSearchResponse,StationSearchResult, StationSearchRequest>(request);
            Assert.IsTrue(result.Results.Count > 0);
        }

        [TestCase("szentendre")]
        public void TimeTableSearch_Should_ReturnTables(string station)
        {

        }
    }
}
