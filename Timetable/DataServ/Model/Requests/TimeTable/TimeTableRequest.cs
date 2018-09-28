using DataService.IModel.IRequests;

namespace DataService.Model.Requests
{
    public class TimeTableRequest : IRequest
    {
        public string FunctionName { get; set; }
        public IParam Parameters { get; set; }

        public override string ToString()
        {
            return $"{FunctionName}";
        }
    }
}
