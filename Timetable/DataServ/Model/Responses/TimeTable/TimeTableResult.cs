using DataServ.Model.Responses.TimeTable;
using DataService.Interface.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DataService.Model.Responses
{
    public class TimeTable : IResult
    {
        [JsonProperty(PropertyName = "napkiiras")]
        public string DayWrittenFormat { get; set; }

        public DateTime DateGot { get; set; }

        [JsonProperty(PropertyName = "daytype_got")]
        public short DayType { get; set; }

        [JsonProperty(PropertyName = "apache_hostname")]
        public string ApacheHostName { get; set; }

        [JsonProperty(PropertyName = "talalatok")]
        public Tables Tables { get; set; }

        public override string ToString()
        {
            return $"{DateGot} {ApacheHostName}";
        }
    }
}