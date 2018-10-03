using System;
using DataService;
using System.Linq;
using NUnit.Framework;
using System.Threading.Tasks;
using DataService.Model.Requests;
using DataService.Model.Responses;
using DataServ;
using System;

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
<<<<<<< Updated upstream
            StationRequest request = Helper.GetStationSearchRequest(station);
            StationResponse result = await service.GetResponse<StationResponse, Station, StationRequest>(request);
            Assert.IsTrue(result.Results.Count > 0);
        }

        [TestCase("szenderre")]
        [TestCase("esztregomba")]
        public async System.Threading.Tasks.Task StationSearch_Should_Fail(string station)
        {
            var request = Helper.GetStationSearchRequest(station);
            var result = await service.GetResponse<StationResponse, Station, StationRequest>(request);//Service.PostAsync<StationResponse,Station, StationRequest>(request);
            Assert.IsFalse(result.Results.Count > 0);
        }

=======
            var request = Helper.GetStationSearchRequest(station);
            var result = await Service.PostAsync<StationResponse,Station, StationRequest>(request);
            Assert.IsTrue(result.Stations.Count > 0);
        }
        
>>>>>>> Stashed changes
        [TestCase("szentendre")]
        public async Task TimeTableSearch_Should_ReturnTablesAsync(string station)
        {
            DateTime date = DateTime.Now;
            StationRequest stationSearchReq = Helper.GetStationSearchRequest("szentendre");

            var stationSearchResponse = await Service.PostAsync<StationResponse, Station, StationRequest>(stationSearchReq);

            Station to = stationSearchResponse.Stations.First(x => x.LsId == 17413);
            Station from = stationSearchResponse.Stations.First(x => x.LsId == 17431);



            int h = 0;
            //TimeTableRequest request = new TimeTableRequest()
            //{
            //    FunctionName = "getRoutes",
            //    Parameters = new TimeTableParam
            //    {
            //        Date = $"{date.Year}-{date.Month}-{date.Day}",
            //        SearchType = "megallo",
            //        ExtraSettings = "block",
            //        Filtering = 0,
            //        IsLocal = "No",
            //        From = fromResp.Results.First().,
            //        FromCoordinateX =
            //    }
            //};
        }
    }
}
