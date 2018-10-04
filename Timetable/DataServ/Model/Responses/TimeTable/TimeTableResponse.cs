using DataServ.Interface;

namespace DataServ.Model
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