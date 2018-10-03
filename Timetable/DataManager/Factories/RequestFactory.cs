using DataManager.Interface;
using DataService.Model.Requests;
using DataService.Model.Responses;
using System;

namespace DataManager.Factories
{
    public class RequestFactory : IRequestFactory
    {
        public StationRequest GetStationRequest()
        {
            throw new NotImplementedException();
        }

        public TimeTableRequest GetTimeTableRequest()
        {
            throw new NotImplementedException();
        }

        public StationRequest StationRequest(string stationName)
        {
            throw new NotImplementedException();
        }

        public TimeTableRequest TimeTableRequest(Station from, Station to, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}