using DataService.Model.Responses;

namespace DataManager.Interface
{
    public interface IResponseFactory
    {
        StationResponse GetStationResponse();

        TimeTableResponse GetTimeTableResponse();
    }
}
