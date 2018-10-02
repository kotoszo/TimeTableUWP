using System;
using DataManager.Interface;
using DataService.Model.Responses;

namespace DataManager.Factories
{
    public class ResponseFactory : IResponseFactory
    {
        public StationResponse GetStationResponse()
        {
            throw new NotImplementedException();
        }

        public TimeTableResponse GetTimeTableResponse()
        {
            throw new NotImplementedException();
        }
    }
}
