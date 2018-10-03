using System.Threading.Tasks;
using DataService.Interface.Response;
using DataService.Interface.Request;

namespace DataServ
{
    public interface IService
    {
        Task<TResponse> GetResponse<TResponse, TResult, TRequest>(TRequest requestToSend)
            where TResponse:IResponse<TResult> where TRequest:IRequest where TResult:IResult;

        IRequest GetRequest<TRequest>(string funcName, IParam param) where TRequest:IRequest,new();
    }
}
