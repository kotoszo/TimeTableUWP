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
<<<<<<< Updated upstream:Timetable/DataServ/Model/Responses/StationSearch/StationResponse.cs
        public List<Station> Results { get; set; }
=======
        public List<Station> Stations { get; set; }
>>>>>>> Stashed changes:Timetable/DataServ/Model/Responses/StationSearch/StationSearchResponse.cs

        public override string ToString()
        {
            return $"{string.Join(";", Status)}";
        }
    }
}