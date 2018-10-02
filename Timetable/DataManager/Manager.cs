using DataManager.Interface;
using DataService.Model.Responses;
using System;
using System.Collections.Generic;

namespace DataManager
{
    public class Manager
    {
        private IFactory factory;

        public Manager(IFactory factory)
        {
            this.factory = factory;
        }

        public T GetRequest<T>(string stationName) where T: DataService.IModel.IRequests.IRequest
        {
            return default(T);//return factory.GetReq<T>();
        }

        public List<Station> GetStation(string stationName)
        {
            return null;
        }

        public TimeTable GetTable(Station from, Station to)
        {
            return null;
        }
    }
}