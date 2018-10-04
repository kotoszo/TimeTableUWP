using DataServ.Interface;

namespace DataServ.Model
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