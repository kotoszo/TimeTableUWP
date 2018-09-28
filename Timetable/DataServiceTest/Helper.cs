using System;
using DataService.Model.Requests;

namespace DataServiceTest
{
    static class Helper
    {
        internal static StationSearchRequest GetStationSearchRequest(string station)
        {
            DateTime date = DateTime.Now;
            StationSearchRequest request = new StationSearchRequest()
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
        }
    }
}
