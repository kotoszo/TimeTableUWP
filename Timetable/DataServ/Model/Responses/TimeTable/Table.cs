using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace DataServ.Model.Responses.TimeTable
{
    public class Table
    {
        [JsonProperty(PropertyName = "ind_prefix")]
        public string DeparturePrefix { get; set; }

        [JsonProperty(PropertyName = "indulasi_hely")]
        public string DeparturePlace { get; set; }

        [JsonProperty(PropertyName = "ind_kulterulet")]
        public short DeparturePeriphery { get; set; }

        [JsonProperty(PropertyName = "departureCity")]
        public string DepartureCity { get; set; }

        [JsonProperty(PropertyName = "departureStation")]
        public string DepartureStation { get; set; }

        [JsonProperty(PropertyName = "erk_prefix")]
        public string ArrivalPrefix { get; set; }

        [JsonProperty(PropertyName = "erkezesi_hely")]
        public string ArrivalPlace { get; set; }

        [JsonProperty(PropertyName = "erk_kulterulet")]
        public short ArrivalPeriphery { get; set; }

        [JsonProperty(PropertyName = "arrivalCity")]
        public string ArrivalCity { get; set; }

        [JsonProperty(PropertyName = "arrivalStation")]
        public string ArrivalStation { get; set; }

        [JsonProperty(PropertyName = "indulasi_ido")]
        public string DepartureDate { get; set; }

        [JsonProperty(PropertyName = "erkezesi_ido")]
        public string ArrivalDate { get; set; }

        [JsonProperty(PropertyName = "atszallasok_szama")]
        public short TransferChangeCount { get; set; }

        [JsonProperty(PropertyName = "osszido")]
        public string TotalTime { get; set; }

        [JsonProperty(PropertyName = "indulasi_hely_info")]
        public short DeparturePlaceInfo { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> JTokenDict { get; set; }

        public RouteInfo RouteInfo { get; set; }

        public TransferChangeInfo GetTransferChangeInfo { get; set; }

        [JsonProperty(PropertyName = "explanations")]
        public string[] Explanations { get; set; }
        [JsonProperty(PropertyName = "totalDistance")]
        public double TotalDistance { get; set; }
        [JsonProperty(PropertyName = "totalFare")]
        public short TotalFare { get; set; }
        [JsonProperty(PropertyName = "totalFare50")]
        public short TotalFare50 { get; set; }
        [JsonProperty(PropertyName = "totalFare90")]
        public short TotalFare90 { get; set; }
        [JsonProperty(PropertyName = "totalAdditionalTicketPrice")]
        public short TotalAdditionalTicketPrice { get; set; }
        [JsonProperty(PropertyName = "eTicketAvailable")]
        public bool IsETicketAvailable { get; set; }
        [JsonProperty(PropertyName = "ossztav")]
        public string Ossztav { get; set; }
        [JsonProperty(PropertyName = "talalat_kozlekedik")]
        public string talalat_kozlekedik { get; set; }

        public override string ToString()
        {
            return $"{DepartureDate}-{ArrivalDate} {DepartureStation}-{ArrivalStation}";
        }
    }
}
