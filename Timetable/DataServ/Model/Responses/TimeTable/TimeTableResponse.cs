using System.Collections.Generic;
using DataService.IModel.IResponse;

namespace DataService.Model.Responses
{
    public class TimeTableResponse : IResponse<TimeTable>
    {
        public string[] Status { get; set; }
        public List<TimeTable> Results { get; set; }
    }
}
