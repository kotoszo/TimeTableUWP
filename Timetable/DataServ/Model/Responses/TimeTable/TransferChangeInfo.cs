using Newtonsoft.Json;

namespace DataServ.Model.Responses.TimeTable
{
    public class TransferChangeInfo
    {
        [JsonProperty(PropertyName = "atszallasinfo")]
        public string atszallasinfo { get; set; }

        [JsonProperty(PropertyName = "atszallohely")]
        public string atszallohely { get; set; }

        [JsonProperty(PropertyName = "atszallaskorlatozas")]
        public string atszallaskorlatozas { get; set; }

        public override string ToString()
        {
            return $"{atszallasinfo} {atszallohely} {atszallaskorlatozas}";
        }
    }
}
