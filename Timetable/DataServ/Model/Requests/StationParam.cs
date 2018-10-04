using DataServ.BaseF;
using DataServ.Interface;
using Newtonsoft.Json;
using System;

namespace DataServ.Model
{
    [Serializable]
    public class StationParam : IParam
    {
        public StationParam()
        {
        }

        public StationParam(string stationName, DateTime date, string currentLang = null, short maxResults = 0, short[] networks = null, string[] searchIn = null)
        {
            InputText = stationName;
            Date = $"{date.Year}-{date.Month}-{date.Day}";
            CurrentLang = currentLang ?? StationRequestBase.CurrentLang;
            MaxResults = maxResults > 0 ? maxResults : StationRequestBase.MaxResults;
            Networks = networks ?? StationRequestBase.Networks;
            SearchIn = searchIn ?? StationRequestBase.SearchIn;
        }

        [JsonProperty(PropertyName = "inputText")]
        public string InputText { get; set; }

        [JsonProperty(PropertyName = "searchIn")]
        public string[] SearchIn { get; set; }

        [JsonProperty(PropertyName = "searchDate")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "maxResults")]
        public int MaxResults { get; set; }

        [JsonProperty(PropertyName = "networks")]
        public short[] Networks { get; set; }

        [JsonProperty(PropertyName = "currentLang")]
        public string CurrentLang { get; set; }
    }
}