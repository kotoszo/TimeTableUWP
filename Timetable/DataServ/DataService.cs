using DataServ.Model;
using DataServ.Model.Responses;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataServ
{
    public class DataService
    {
        private IService service;

        public DataService(IService service)
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

        public TimeTable GetTimeTables(Station from, Station to, DateTime date)
        {
            TimeTableParam param = new TimeTableParam(from, to, date);

            var request = (TimeTableRequest)service.GetRequest<TimeTableRequest>("getRoutes", param);
            var response = service.GetResponse<TimeTableResponse, TimeTable, TimeTableRequest>(request);

            TimeTable timeTable = response.Result.Results;
            timeTable.Tables.GetTable = new List<Table>();

            foreach (KeyValuePair<string, JToken> item in timeTable.Tables.Dict)
            {
                timeTable.Tables.GetTable.Add(item.Value.ToObject<Table>());
                var current = timeTable.Tables.GetTable.Last();
                current.RouteInfo = current.JTokenDict["jaratinfok"]["0"].ToObject<RouteInfo>();
                current.GetTransferChangeInfo = current.JTokenDict["atszallasinfok"]["0"].ToObject<TransferChangeInfo>();
            }

            return timeTable;
        }
    }
}