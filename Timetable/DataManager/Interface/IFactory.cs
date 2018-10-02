using DataService.IModel.IRequests;
using DataService.IModel.IResponse;

namespace DataManager.Interface
{
    public interface IFactory : IRequestFactory, IResponseFactory
    {
        IRequest GetReq<T>() where T : IRequest;

        IResponse<IResult> GetRes<T>() where T : IResponse<IResult>;
    }
}
