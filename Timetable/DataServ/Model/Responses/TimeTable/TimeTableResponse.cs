using DataService.Interface.Response;
using System.Collections.Generic;

namespace DataService.Model.Responses
{
    public class TimeTableResponse : IResponse<TimeTable>
    {
        public string Status { get; set; }

        public TimeTable Results { get; set; }

        public override string ToString()
        {
            return $"{Status}";
        }
    }
}