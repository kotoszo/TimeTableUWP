using DataManager.Interface;
using DataService.Model.Requests;
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
    }
}