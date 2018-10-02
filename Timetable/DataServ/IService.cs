using System.Collections.Generic;
using DataService.IModel.IResponse;
using DataService.IModel.IRequests;
using System.Threading.Tasks;

namespace DataServ
{
    public interface IService
    {
        Task<TResponse> GetData<TResponse, TResult, TRequest>(TRequest requestToSend)
            where TResponse:IResponse<TResult> where TRequest:IRequest where TResult:IResult;
    }
}
