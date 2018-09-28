using System;
using Newtonsoft.Json;
using DataService.IModel.IRequests;

namespace DataService.Model.Requests
{
    [Serializable]
    public class TimeTableParam : IParam
    {
        [JsonProperty(PropertyName = "datum")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "erk_stype")]
        public string SearchType { get; set; }

        [JsonProperty(PropertyName = "ext_settings")]
        public string ExtraSettings { get; set; }

        [JsonProperty(PropertyName = "filtering")]
        public int Filtering { get; set; }

        [JsonProperty(PropertyName = "helyi")]
        public bool IsLocal { get; set; }

        [JsonProperty(PropertyName = "honnan")]
        public string From { get; set; }

        [JsonProperty(PropertyName = "honnan_eovx")]
        public double FromCoordinateX { get; set; }

        [JsonProperty(PropertyName = "honnan_eovy")]
        public double FromCoordinateY { get; set; }

        [JsonProperty(PropertyName = "honnan_ls_id")]
        public int FromStationId { get; set; }

        [JsonProperty(PropertyName = "honnan_settlement_id")]
        public int FromCityId { get; set; }

        [JsonProperty(PropertyName = "honnan_site_code")]
        public int FromSiteCode { get; set; }

        [JsonProperty(PropertyName = "honnan_zoom")]
        public int FromZoom { get; set; }

        [JsonProperty(PropertyName = "hour")]
        public int Hour { get; set; }

        [JsonProperty(PropertyName = "hova")]
        public string To { get; set; }

        [JsonProperty(PropertyName = "hova_eovx")]
        public double ToCoordinateX { get; set; }

        [JsonProperty(PropertyName = "hova_eovy")]
        public double ToCoordinateY { get; set; }

        [JsonProperty(PropertyName = "hova_ls_id")]
        public int ToStationId { get; set; }

        [JsonProperty(PropertyName = "hova_settlement_id")]
        public int ToCityId { get; set; }

        [JsonProperty(PropertyName = "hova_site_code")]
        public int ToSiteCode { get; set; }

        [JsonProperty(PropertyName = "hova_zoom")]
        public int ToZoom { get; set; }

        [JsonProperty(PropertyName = "ind_stype")]
        public string SearchType2 { get; set; }

        [JsonProperty(PropertyName = "keresztul_stype")]
        public string ThroughSearchType { get; set; }

        [JsonProperty(PropertyName = "maxatszallas")]
        public short MaxTransferChange { get; set; }

        [JsonProperty(PropertyName = "maxvar")]
        public short MaxVar { get; set; }

        [JsonProperty(PropertyName = "maxwalk")]
        public short MaxMeterToWalk { get; set; }

        [JsonProperty(PropertyName = "min")]
        public short Minute { get; set; }

        [JsonProperty(PropertyName = "napszak")]
        public short PartOfTheDay { get; set; }

        [JsonProperty(PropertyName = "naptipus")]
        public short DayType { get; set; }

        [JsonProperty(PropertyName = "odavissza")]
        public bool WithReturn { get; set; }

        [JsonProperty(PropertyName = "preferencia")]
        public bool Preference { get; set; }

        [JsonProperty(PropertyName = "rendezes")]
        public bool IsSorted { get; set; }

        [JsonProperty(PropertyName = "submitted")]
        public bool Submitted { get; set; }

        [JsonProperty(PropertyName = "talalatok")]
        public int FindCont { get; set; }

        [JsonProperty(PropertyName = "target")]
        public bool Target { get; set; }

        [JsonProperty(PropertyName = "utirany")]
        public string Track { get; set; }

        [JsonProperty(PropertyName = "var")]
        public bool Var { get; set; }
    }
}
