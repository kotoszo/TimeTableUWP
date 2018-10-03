using System;
using DataServ;
using DataService;
using NUnit.Framework;
using System.Threading.Tasks;
using DataService.Model.Requests;
using DataService.Model.Responses;

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

        [TestCase("szentendre", "hu", 120, new short[]{1,2,3}, new string[] { "stations"})]
        public void StationRequest_Should_Succeed(string stationName, string currentLang, short maxResults, short[] networks, string[] searchIn)
        {
            DateTime date = DateTime.Now;
            StationParam param = new StationParam()
            {
                InputText = stationName,
                Date = $"{date.Year}-{date.Month}-{date.Day}",
                CurrentLang = currentLang,
                MaxResults = maxResults,
                Networks = networks,
                SearchIn = searchIn
            };
            var request = service.GetRequest<StationRequest>("getStationOrAddrByText", param);
            Assert.IsNotNull(request);
        }

        [TestCase("szentendre")]
        [TestCase("esztergom")]
        public async Task StationSearch_Should_ReturnStations(string station)
        {
            StationRequest request = Helper.GetStationSearchRequest(station);
            StationResponse result = await service.GetResponse<StationResponse, Station, StationRequest>(request);

            Assert.IsTrue(result.Results.Count > 0);
        }

        [TestCase("szenderre")]
        [TestCase("esztregomba")]
        public async System.Threading.Tasks.Task StationSearch_Should_Fail(string station)
        {
            var request = Helper.GetStationSearchRequest(station);
            var result = await service.GetResponse<StationResponse, Station, StationRequest>(request);
            
            Assert.IsFalse(result.Results.Count > 0);
        }
    }
}
