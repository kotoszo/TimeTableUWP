using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using DataService.IModel.IResponse;

namespace DataService.Model.Responses
{
    [Serializable]
    public class StationSearchResponse : IResponse<StationSearchResult>
    {
        [JsonProperty(PropertyName = "status")]
        public string[] Status { get; set; }

        [JsonProperty(PropertyName = "results")]
        public List<StationSearchResult> Results { get; set; }

        public override string ToString()
        {
            return $"{string.Join(";", Status)}";
        }
    }
}