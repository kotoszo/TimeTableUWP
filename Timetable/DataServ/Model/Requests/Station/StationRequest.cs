using DataService.IModel.IRequests;

namespace DataService.Model.Requests
{
    public class StationRequest : IRequest
    {
        public IParam Parameters { get; set; }
        public string FunctionName { get; set; }

        public override string ToString()
        {
            return $"{FunctionName}";
        }
    }
}
