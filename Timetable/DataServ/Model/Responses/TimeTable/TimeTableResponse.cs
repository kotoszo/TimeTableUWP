using System.Collections.Generic;
using DataService.Interface.Response;

namespace DataService.Model.Responses
{
    public class TimeTableResponse : IResponse<TimeTable>
    {
        public string[] Status { get; set; }
<<<<<<< Updated upstream
        public List<TimeTable> Results { get; set; }
=======
        public List<TimeTableResult> Stations { get; set; }
>>>>>>> Stashed changes
    }
}
