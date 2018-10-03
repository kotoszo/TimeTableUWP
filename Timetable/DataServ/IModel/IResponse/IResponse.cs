using System.Collections.Generic;

namespace DataService.IModel.IResponse
{
    public interface IResponse<TResult> where TResult : IResult
    {
        string[] Status { get; set; }

        List<TResult> Results { get; set; }
    }
}
