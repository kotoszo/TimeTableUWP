using System;
using Newtonsoft.Json;
using DataService.IModel.IRequests;

namespace DataService.Model.Requests
{
    [Serializable]
    public class StationSearchParam : IParam
    {
        [JsonProperty(PropertyName = "inputText")]
        public string InputText { get; set; }

        [JsonProperty(PropertyName = "searchIn")]
        public string[] SearchIn { get; set; }

        [JsonProperty(PropertyName = "searchDate")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "maxResults")]
        public int MaxResults { get; set; }

        [JsonProperty(PropertyName = "networks")]
        public int[] Networks { get; set; }

        [JsonProperty(PropertyName = "currentLang")]
        public string CurrentLang { get; set; }
        
        //{
        //"func": "getStationOrAddrByText",
        //"params": {
        //    "inputText": "szentendre",
        //    "searchIn": 

        //    ["stations"],
        //    "searchDate": "2018-09-28",
        //    "maxResults": 30,
        //    "networks": [1,
        //    2,
        //    3],
        //    "currentLang": "hu"
        //}
    }
}