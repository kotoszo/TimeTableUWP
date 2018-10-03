﻿using System;
using Newtonsoft.Json;
using DataService.Interface.Response;

namespace DataService.Model.Responses
{
    [Serializable]
    public class Station : IResult
    {
        [JsonProperty(PropertyName = "settlement_name")]
        public string SettlementName { get; set; }

        [JsonProperty(PropertyName = "lsname")]
        public string LsName { get; set; }

        [JsonProperty(PropertyName = "ls_id")]
        public int LsId { get; set; }

        [JsonProperty(PropertyName = "site_code")]
        public string SiteCode { get; set; }

        [JsonProperty(PropertyName = "settlement_id")]
        public int SettlementId { get; set; }

        [JsonProperty(PropertyName = "eovx")]
        public double CoordinateX { get; set; }

        [JsonProperty(PropertyName = "eovy")]
        public double CoordinateY { get; set; }

        [JsonProperty(PropertyName = "zoom")]
        public int Zoom { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "geomEov")]
        public GeoPoint GeoEov { get; set; }

        [JsonProperty(PropertyName = "geomWgs")]
        public GeoPoint GeoWgs { get; set; }

        [JsonProperty(PropertyName = "date_got")]
        public DateTime DateGot { get; set; }

        public override string ToString()
        {
            return $"{LsName}";
        }
    }
}
