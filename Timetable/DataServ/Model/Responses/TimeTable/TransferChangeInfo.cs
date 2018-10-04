using Newtonsoft.Json;

namespace DataServ.Model.Responses.TimeTable
{
    public class TransferChangeInfo
    {
        [JsonProperty(PropertyName = "atszallasinfo")]
        public string TransferInfo { get; set; }

        [JsonProperty(PropertyName = "atszallohely")]
        public string LocationName { get; set; }

        [JsonProperty(PropertyName = "atszallaskorlatozas")]
        public string TransferChangeLimit { get; set; }

        public override string ToString()
        {
            return $"{TransferInfo} {LocationName} {TransferChangeLimit}";
        }
    }
}
