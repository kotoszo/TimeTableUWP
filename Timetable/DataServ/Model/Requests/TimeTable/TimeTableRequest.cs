using DataService.Interface.Request;

namespace DataService.Model.Requests
{
    public class TimeTableRequest : IRequest
    {
        public IParam Parameters { get; set; }
        public string FunctionName { get; set; }

        public void LoadObjects(IParam obj)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FunctionName}";
        }
    }
}