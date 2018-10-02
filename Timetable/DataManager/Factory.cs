using System;
using DataManager.Interface;
using DataService.IModel.IRequests;
using DataService.IModel.IResponse;
using DataService.Model.Requests;
using DataService.Model.Responses;

namespace DataManager
{
    public class Factory : IFactory
    {
        public IRequest GetReq<T>() where T : IRequest
        {
            if (typeof(T) == typeof(StationRequest))
                return GetStationRequest();
            else if (typeof(T) == typeof(TimeTableRequest))
                return GetTimeTableRequest();

            return null;
        }

        public IResponse<IResult> GetRes<T>() where T : IResponse<IResult>
        {
            if (typeof(T) == typeof(StationResponse))
                return null;// GetStationResponse<T>();
            else if (typeof(T) == typeof(TimeTableResponse))
                return GetTimeTableResponse<T>();

            return null;
        }

        private IResponse<IResult> GetTimeTableResponse<T>() where T : IResponse<IResult>
        {
            throw new NotImplementedException();
        }

        private StationResponse GetStationResponse<TResponse, TResult>() where TResponse : IResponse<IResult> where TResult:IResult
        {
            throw new NotImplementedException();
        }

        public StationRequest GetStationRequest()
        {
            throw new System.NotImplementedException();
        }

        public TimeTableRequest GetTimeTableRequest()
        {
            throw new System.NotImplementedException();
        }

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
