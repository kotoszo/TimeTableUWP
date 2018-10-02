using DataService;
using NUnit.Framework;
using DataService.Model.Requests;
using DataService.Model.Responses;
using DataServ;

namespace DataServiceTest
{
    [TestFixture]
    public class UnitTest1
    {
        IService service;

        [OneTimeSetUp]
        public void setup()
        {
            service = new Service();
        }
        
        [TestCase("szentendre")]
        [TestCase("esztergom")]
        public async System.Threading.Tasks.Task StationSearch_Should_ReturnStations(string station)
        {
            var request = Helper.GetStationSearchRequest(station);
            StationResponse result = await service.GetData<StationResponse, Station, StationRequest>(request);//Service.PostAsync<StationResponse,Station, StationRequest>(request);
            Assert.IsTrue(result.Results.Count > 0);
        }

        [TestCase("szenderre")]
        [TestCase("esztregomba")]
        public async System.Threading.Tasks.Task StationSearch_Should_Fail(string station)
        {
            var request = Helper.GetStationSearchRequest(station);
            var result = await service.GetData<StationResponse, Station, StationRequest>(request);//Service.PostAsync<StationResponse,Station, StationRequest>(request);
            Assert.IsFalse(result.Results.Count > 0);
        }

        [TestCase("szentendre")]
        public void TimeTableSearch_Should_ReturnTables(string station)
        {

        }
    }
}
