using DataService.IModel.IRequests;

namespace DataService.Model.Requests
{
    public class StationSearchRequest : IRequest
    {
        public string FunctionName { get ; set; }
        public IParam Parameters { get; set; }
    }
}
