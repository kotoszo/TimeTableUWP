using DataService.IModel.IRequests;
using DataService.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Interface
{
    public interface IRequestFactory 
    {
        StationRequest GetStationRequest();

        TimeTableRequest GetTimeTableRequest();
    }
}