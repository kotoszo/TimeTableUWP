using System.Collections.Generic;

namespace DataService.IModel.IResponse
{
    public interface IResponse<T> where T:IResult
    {
        string[] Status { get; set; }

        List<T> Results { get; set; }
    }
}
