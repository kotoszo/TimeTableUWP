using System;
using DataService.Model.Requests;

namespace DataServiceTest
{
    static class Helper
    {
        internal static StationRequest GetStationSearchRequest(string station)
        {
<<<<<<< Updated upstream
            return new StationRequest(
                station,
                DateTime.Now, 
                "getStationOrAddrByText",
                new string[] { "stations" },
                120, 
                new short[] { 1, 2, 3 }, 
                "hu"
            );
=======
            DateTime date = DateTime.Now;
            StationRequest request = new StationRequest()
            {
                FunctionName = "getStationOrAddrByText",
                Parameters = new StationSearchParam()
                {
                    InputText = station,
                    SearchIn = new string[] { "stations" },
                    Date = $"{date.Year}-{date.Month}-{date.Day}",
                    MaxResults = 120,
                    Networks = new int[] { 1, 2, 3 },
                    CurrentLang = "hu"
                }
            };
            return request;
>>>>>>> Stashed changes
        }
    }
}
