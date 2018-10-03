using System;
using DataService.Model.Requests;

namespace DataServiceTest
{
    static class Helper
    {
        internal static StationRequest GetStationSearchRequest(string station)
        {
            return new StationRequest(
                station,
                DateTime.Now, 
                "getStationOrAddrByText",
                new string[] { "stations" },
                120, 
                new short[] { 1, 2, 3 }, 
                "hu"
            );
        }
    }
}
