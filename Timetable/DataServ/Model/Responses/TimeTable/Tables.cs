using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace DataServ.Model.Responses
{
    [Serializable]
    public class Tables
    {
        [JsonExtensionData]
        public Dictionary<string, JToken> Dict { get; set; }

        public List<Table> GetTable { get; set; }
    }
}