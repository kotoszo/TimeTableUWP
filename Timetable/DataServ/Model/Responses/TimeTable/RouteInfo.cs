using Newtonsoft.Json;

namespace DataServ.Model.Responses
{
    public class RouteInfo
    {
        [JsonProperty(PropertyName = "prebuy")]
        public bool IsPrebuyAvailable { get; set; }

        [JsonProperty(PropertyName = "alacsonypadlos")]
        public bool IsLowFloor { get; set; }

        [JsonProperty(PropertyName = "network")]
        public bool IsNetwork { get; set; }

        [JsonProperty(PropertyName = "nagysebessegu")]
        public bool IsHighSpeed { get; set; }

        [JsonProperty(PropertyName = "jelleg")]
        public string Nature { get; set; }

        [JsonProperty(PropertyName = "emeltszintu")]
        public bool IsHighFloor { get; set; }

        [JsonProperty(PropertyName = "vonalnev")]
        public string RouteName { get; set; }

        [JsonProperty(PropertyName = "wifi")]
        public bool IsWifi { get; set; }

        [JsonProperty(PropertyName = "internet")]
        public bool IsInternet { get; set; }

        [JsonProperty(PropertyName = "internetes_jegy")]
        public bool IsOnlineTicktet { get; set; }

        [JsonProperty(PropertyName = "terelout")]
        public bool Detour { get; set; }

        [JsonProperty(PropertyName = "vonalelnevezes")]
        public string RouteNaming { get; set; }

        [JsonProperty(PropertyName = "remark")]
        public string Remark { get; set; }

        [JsonProperty(PropertyName = "distance")]
        public double Distance { get; set; }

        [JsonProperty(PropertyName = "fare")]
        public short Fare { get; set; }

        [JsonProperty(PropertyName = "no_discountable_fare")]
        public bool IsDiscountable { get; set; }

        [JsonProperty(PropertyName = "additional_ticket_price")]
        public short AdditionalTicketPrice { get; set; }

        [JsonProperty(PropertyName = "seat_ticket_price")]
        public short SeatTicketPrice { get; set; }

        [JsonProperty(PropertyName = "train_cat")]
        public string TrainCat { get; set; }

        [JsonProperty(PropertyName = "fare_50_percent")]
        public short Fare50Percent { get; set; }

        [JsonProperty(PropertyName = "fare_90_percent")]
        public short Fare90Percent { get; set; }

        [JsonProperty(PropertyName = "dcLsId")]
        public int DcLsId { get; set; }

        [JsonProperty(PropertyName = "bube_accepted")]
        public bool IsBubeAccepted { get; set; }

        public override string ToString()
        {
            return $"Route:{RouteName}, Price:{Fare}Ft";
        }
    }
}