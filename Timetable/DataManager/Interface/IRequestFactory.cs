using DataService.Model.Requests;
using DataService.Model.Responses;
using System;

namespace DataManager.Interface
{
    public interface IRequestFactory
    {
        StationRequest StationRequest(string stationName);

        TimeTableRequest TimeTableRequest(Station from, Station to, DateTime date);
    }
}