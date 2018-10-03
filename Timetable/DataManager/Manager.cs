using System;
using DataServ;
using DataServ.IModel.IRequests;
using DataServ.IModel.IResponse;
using System.Collections.Generic;
using DataService.Model.Requests;
using DataService.Model.Responses;

namespace DataManager
{
    public class Manager
    {
        private IService service;

        public Manager(IService service)
        {
            this.service = service;
        }

        public List<Station> GetStations(string stationName, DateTime date)
        {
            StationParam param = new StationParam(stationName, date);
            
            StationRequest request = (StationRequest)service.GetRequest<StationRequest>("getStationOrAddrByText", param);
            System.Threading.Tasks.Task<StationResponse> response = service.GetResponse<StationResponse, Station, StationRequest>(request);

            return response.Result.Results;
        }

        public List<TimeTable> GetTimeTables(Station from, Station to, DateTime date)
        {
            TimeTableParam param = new TimeTableParam(from, to, date);

            var request = (TimeTableRequest)service.GetRequest<TimeTableRequest>("getRoutes", param);
            var response = service.GetResponse<TimeTableResponse, TimeTable, TimeTableRequest>(request);

            return response.Result.Results;
        }
        
        #region exampleFromGergo

        public ResponseBase<Station> GetStation(RequestBase<string> stationRequest)
        {
            return HandleRequest(stationRequest, (s) =>
            {
                return new Station
                {

                };
            });
        }

        public ResponseBase<TResponse> HandleRequest<TRequest,TResponse>(RequestBase<TRequest> request, Func<TRequest, TResponse> method)
        {
            if (string.IsNullOrEmpty(request.Token))
            {
                throw new AccessViolationException();
            }

            var response = new ResponseBase<TResponse>();
            response.ResponseData = method(request.RequestData);

            return response;
        }
        #endregion
        
    }
}