using DataManager.Interface;
using DataService.Model.Requests;
using DataService.Model.Responses;
using System;

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

        public StationResponse StationResponse(StationRequest request)
        {
            throw new NotImplementedException();
        }

        public TimeTableResponse TimeTableResponse(TimeTableRequest request)
        {
            throw new NotImplementedException();
        }
    }
}