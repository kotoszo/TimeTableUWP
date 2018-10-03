using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using DataService.Interface.Response;

namespace DataService.Model.Responses
{
    [Serializable]
    public class StationResponse : IResponse<Station>
    {
        [JsonProperty(PropertyName = "status")]
        public string[] Status { get; set; }

        [JsonProperty(PropertyName = "results")]

        public List<Station> Results { get; set; }

        public override string ToString()
        {
            return $"{string.Join(";", Status)}";
        }
    }
}