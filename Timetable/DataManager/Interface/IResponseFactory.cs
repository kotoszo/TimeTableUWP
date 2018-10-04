using DataService.Model.Requests;
using DataService.Model.Responses;

namespace DataManager.Interface
{
    public interface IResponseFactory
    {
        StationResponse StationResponse(StationRequest request);

        TimeTableResponse TimeTableResponse(TimeTableRequest request);
    }
}