using System.Collections.Generic;

namespace DataService.Interface.Response
{
    public interface IResponse<TResult> where TResult : IResult
    {
        string[] Status { get; set; }

<<<<<<< Updated upstream:Timetable/DataServ/IModel/IResponse/IResponse.cs
        List<TResult> Results { get; set; }
=======
        List<T> Stations { get; set; }
>>>>>>> Stashed changes:Timetable/DataServ/Interface/Response/IResponse.cs
    }
}
