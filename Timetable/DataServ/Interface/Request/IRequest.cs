using Newtonsoft.Json;

namespace DataService.Interface.Request
{
    public interface IRequest
    {
        [JsonProperty(PropertyName = "func")]
        string FunctionName { get; set; }

        [JsonProperty(PropertyName = "params")]
        IParam Parameters { get; set; }

        void LoadObjects(IParam obj);
    }
}