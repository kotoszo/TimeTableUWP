namespace DataServ.IModel.IRequests
{
    public class RequestBase<T>
    {
        public string Token { get; set; }
        public T RequestData { get; set; }
    }
}