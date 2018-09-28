using Newtonsoft.Json;

namespace DataService.IModel.IRequests
{
    public interface IRequest
    {
        [JsonProperty(PropertyName = "func")]
        string FunctionName { get; set; }

        [JsonProperty(PropertyName = "params")]
        IParam Parameters {get;set;}
    }
}
