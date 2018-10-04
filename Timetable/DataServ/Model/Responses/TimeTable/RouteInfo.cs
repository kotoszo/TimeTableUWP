using Newtonsoft.Json;

namespace DataServ.Model.Responses.TimeTable
{
    public class RouteInfo
    {
        [JsonProperty(PropertyName = "prebuy")]
        public bool prebuy { get; set; }

        [JsonProperty(PropertyName = "alacsonypadlos")]
        public bool alacsonypadlos { get; set; }

        [JsonProperty(PropertyName = "network")]
        public bool network { get; set; }

        [JsonProperty(PropertyName = "nagysebessegu")]
        public bool nagysebessegu { get; set; }

        [JsonProperty(PropertyName = "jelleg")]
        public string jelleg { get; set; }

        [JsonProperty(PropertyName = "emeltszintu")]
        public bool emeltszintu { get; set; }

        [JsonProperty(PropertyName = "vonalnev")]
        public string vonalnev { get; set; }

        [JsonProperty(PropertyName = "wifi")]
        public bool wifi { get; set; }

        [JsonProperty(PropertyName = "internet")]
        public bool internet { get; set; }

        [JsonProperty(PropertyName = "internetes_jegy")]
        public bool internetes_jegy { get; set; }

        [JsonProperty(PropertyName = "terelout")]
        public bool terelout { get; set; }

        [JsonProperty(PropertyName = "vonalelnevezes")]
        public string vonalelnevezes { get; set; }

        [JsonProperty(PropertyName = "remark")]
        public string remark { get; set; }

        [JsonProperty(PropertyName = "distance")]
        public double distance { get; set; }

        [JsonProperty(PropertyName = "fare")]
        public short fare { get; set; }

        [JsonProperty(PropertyName = "no_discountable_fare")]
        public bool no_discountable_fare { get; set; }

        [JsonProperty(PropertyName = "additional_ticket_price")]
        public short additional_ticket_price { get; set; }

        [JsonProperty(PropertyName = "seat_ticket_price")]
        public short seat_ticket_price { get; set; }

        [JsonProperty(PropertyName = "train_cat")]
        public string train_cat { get; set; }

        [JsonProperty(PropertyName = "fare_50_percent")]
        public short fare_50_percent { get; set; }

        [JsonProperty(PropertyName = "fare_90_percent")]
        public short fare_90_percent { get; set; }

        [JsonProperty(PropertyName = "dcLsId")]
        public int dcLsId { get; set; }

        [JsonProperty(PropertyName = "bube_accepted")]
        public bool bube_accepted { get; set; }

        public override string ToString()
        {
            return $"Route:{vonalnev}, Price:{fare}Ft";
        }
    }
}
