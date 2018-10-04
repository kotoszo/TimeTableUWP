using DataService.Model.Requests;
using System;

namespace DataServiceTest
{
    internal static class Helper
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