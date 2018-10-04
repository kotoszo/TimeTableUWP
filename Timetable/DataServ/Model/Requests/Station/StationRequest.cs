using DataService.Interface.Request;
using System;

namespace DataService.Model.Requests
{
    public class StationRequest : IRequest
    {
        public StationRequest()
        {
        }

        public StationRequest(string station, DateTime date, string funcName, string[] searchIn, short maxResults, short[] networks, string currentLang)
        {
            FunctionName = funcName;
            Parameters = new StationParam
            {
                Date = $"{date.Year}-{date.Month}-{date.Day}",
                InputText = station,
                CurrentLang = currentLang,
                MaxResults = maxResults,
                Networks = networks,
                SearchIn = searchIn
            };
        }

        public IParam Parameters { get; set; }

        public string FunctionName { get; set; }

        public void LoadObjects(IParam param)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FunctionName}";
        }
    }
}