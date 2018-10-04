using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace DataServ.Model.Responses.TimeTable
{
    public class Table
    {
        [JsonProperty(PropertyName = "ind_prefix")]
        public string ind_prefix { get; set; }
        [JsonProperty(PropertyName = "indulasi_hely")]
        public string indulasi_hely { get; set; }
        [JsonProperty(PropertyName = "ind_kulterulet")]
        public short ind_kulterulet { get; set; }
        [JsonProperty(PropertyName = "departureCity")]
        public string departureCity { get; set; }
        [JsonProperty(PropertyName = "departureStation")]
        public string departureStation { get; set; }
        [JsonProperty(PropertyName = "erk_prefix")]
        public string erk_prefix { get; set; }
        [JsonProperty(PropertyName = "erkezesi_hely")]
        public string erkezesi_hely { get; set; }
        [JsonProperty(PropertyName = "erk_kulterulet")]
        public short erk_kulterulet { get; set; }
        [JsonProperty(PropertyName = "arrivalCity")]
        public string arrivalCity { get; set; }
        [JsonProperty(PropertyName = "arrivalStation")]
        public string arrivalStation { get; set; }
        [JsonProperty(PropertyName = "indulasi_ido")]
        public string indulasi_ido { get; set; }
        [JsonProperty(PropertyName = "erkezesi_ido")]
        public string erkezesi_ido { get; set; }
        [JsonProperty(PropertyName = "atszallasok_szama")]
        public short atszallasok_szama { get; set; }
        [JsonProperty(PropertyName = "osszido")]
        public string osszido { get; set; }
        [JsonProperty(PropertyName = "indulasi_hely_info")]
        public short indulasi_hely_info { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> Dict { get; set; }

        public RouteInfo RouteInfo { get; set; }
        public TransferChangeInfo GetTransferChangeInfo { get; set; }

        [JsonProperty(PropertyName = "explanations")]
        public string[] explanations { get; set; }
        [JsonProperty(PropertyName = "totalDistance")]
        public double totalDistance { get; set; }
        [JsonProperty(PropertyName = "totalFare")]
        public short totalFare { get; set; }
        [JsonProperty(PropertyName = "totalFare50")]
        public short totalFare50 { get; set; }
        [JsonProperty(PropertyName = "totalFare90")]
        public short totalFare90 { get; set; }
        [JsonProperty(PropertyName = "totalAdditionalTicketPrice")]
        public short totalAdditionalTicketPrice { get; set; }
        [JsonProperty(PropertyName = "eTicketAvailable")]
        public bool eTicketAvailable { get; set; }
        [JsonProperty(PropertyName = "ossztav")]
        public string ossztav { get; set; }
        [JsonProperty(PropertyName = "talalat_kozlekedik")]
        public string talalat_kozlekedik { get; set; }

        public override string ToString()
        {
            return $"{indulasi_ido}-{erkezesi_ido} {departureStation}-{arrivalStation}";
        }
    }
}
