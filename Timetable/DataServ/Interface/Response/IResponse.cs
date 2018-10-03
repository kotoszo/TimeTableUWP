using System.Collections.Generic;

namespace DataService.Interface.Response
{
    public interface IResponse<TResult> where TResult : IResult
    {
        string[] Status { get; set; }
        
        List<TResult> Results { get; set; }
    }
}
