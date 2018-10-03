using DataService.BaseF;
using DataService.IModel.IRequests;
using DataService.Model.Responses;
using Newtonsoft.Json;
using System;

namespace DataService.Model.Requests
{
    [Serializable]
    public class TimeTableParam : IParam
    {
        public TimeTableParam() { }

        public TimeTableParam(Station from, Station to, DateTime date, 
            string erk_type = null, string ext_settings = null, short? filtering = null, 
            string helyi = null, string ind_stype = null, string keresztul_stype = null, 
            string maxatszallas = null, string maxvar = null, string maxwalk = null, 
            string min = null, short? napszak = null, short? naptipus = null, short? odavissza = null, 
            string preferencia = null, string rendezes = null, string submitted = null, 
            int? talalatok = null, short? target = null, string utirany = null, string var = null)
        {
            Date = $"{date.Year}-{date.Month}-{date.Day}";
            SearchType = erk_type ?? TimeTableRequestBase.erk_type;
            ExtraSettings = ext_settings ?? TimeTableRequestBase.ext_settings;
            Filtering = filtering ?? TimeTableRequestBase.filtering;
            IsLocal = helyi ?? TimeTableRequestBase.helyi;
            SearchType2 = ind_stype ?? TimeTableRequestBase.ind_stype;
            ThroughSearchType = keresztul_stype ?? TimeTableRequestBase.keresztul_stype;
            MaxTransferChange = maxatszallas ?? TimeTableRequestBase.maxatszallas;
            MaxVar = maxvar ?? TimeTableRequestBase.maxvar;
            MaxMeterToWalk = maxwalk ?? TimeTableRequestBase.maxwalk;
            Minute = min ?? TimeTableRequestBase.min;
            PartOfTheDay = napszak ?? TimeTableRequestBase.napszak;
            DayType = naptipus ?? TimeTableRequestBase.napszak;
            WithReturn = odavissza ?? TimeTableRequestBase.odavissza;
            Preference = preferencia ?? TimeTableRequestBase.preferencia;
            IsSorted = rendezes ?? TimeTableRequestBase.rendezes;
            Submitted = submitted ?? TimeTableRequestBase.submitted;
            FindCont = talalatok ?? TimeTableRequestBase.talalatok;
            Target = target ?? TimeTableRequestBase.target;
            Track = utirany ?? TimeTableRequestBase.utirany;
            Var = var ?? TimeTableRequestBase.var;

            FromStation(from);
            ToStation(to);
        }
        private void FromStation(Station station)
        {
            From = station.LsName;
            FromCoordinateX = station.CoordinateX;
            FromCoordinateY = station.CoordinateY;
            FromStationId = station.LsId;
            FromCityId = station.SettlementId;
            FromSiteCode = int.Parse(station.SiteCode);
            FromZoom = station.Zoom;
        }

        private void ToStation(Station station)
        {
            To = station.LsName;
            ToCoordinateX = station.CoordinateX;
            ToCoordinateY = station.CoordinateY;
            ToStationId = station.LsId;
            ToCityId = station.SettlementId;
            ToSiteCode = int.Parse(station.SiteCode);
            ToZoom = station.Zoom;
        }

        [JsonProperty(PropertyName = "datum")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "erk_stype")]
        public string SearchType { get; set; }

        [JsonProperty(PropertyName = "ext_settings")]
        public string ExtraSettings { get; set; }

        [JsonProperty(PropertyName = "filtering")]
        public int Filtering { get; set; }

        [JsonProperty(PropertyName = "helyi")]
        public string IsLocal { get; set; }

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
        public string MaxTransferChange { get; set; }

        [JsonProperty(PropertyName = "maxvar")]
        public string MaxVar { get; set; }

        [JsonProperty(PropertyName = "maxwalk")]
        public string MaxMeterToWalk { get; set; }

        [JsonProperty(PropertyName = "min")]
        public string Minute { get; set; }

        [JsonProperty(PropertyName = "napszak")]
        public short PartOfTheDay { get; set; }

        [JsonProperty(PropertyName = "naptipus")]
        public short DayType { get; set; }

        [JsonProperty(PropertyName = "odavissza")]
        public short WithReturn { get; set; }

        [JsonProperty(PropertyName = "preferencia")]
        public string Preference { get; set; }

        [JsonProperty(PropertyName = "rendezes")]
        public string IsSorted { get; set; }

        [JsonProperty(PropertyName = "submitted")]
        public string Submitted { get; set; }

        [JsonProperty(PropertyName = "talalatok")]
        public int FindCont { get; set; }

        [JsonProperty(PropertyName = "target")]
        public short Target { get; set; }

        [JsonProperty(PropertyName = "utirany")]
        public string Track { get; set; }

        [JsonProperty(PropertyName = "var")]
        public string Var { get; set; }
    }
}
