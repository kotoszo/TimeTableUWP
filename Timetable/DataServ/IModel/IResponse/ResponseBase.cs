namespace DataServ.IModel.IResponse
{
    public class ResponseBase<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T ResponseData { get; set; }
    }
}