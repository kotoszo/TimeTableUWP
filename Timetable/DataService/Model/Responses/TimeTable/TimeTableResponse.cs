using System.Collections.Generic;
using DataService.IModel.IResponse;

namespace DataService.Model.Responses
{
    public class TimeTableResponse : IResponse<TimeTableResult>
    {
        public string[] Status { get; set; }
        public List<TimeTableResult> Results { get; set; }
    }
}
