namespace DataService.Interface.Response
{
    /// <summary>
    /// Signs that the class is a Response
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IResponse<TResult> where TResult : IResult
    {

    }
}