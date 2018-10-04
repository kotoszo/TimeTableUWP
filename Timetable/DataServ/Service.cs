using DataServ.Interface;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataServ
{
    public class Service : IService
    {
        private readonly HttpClient client = new HttpClient();
        private readonly string uri = @"https://menetrendek.hu/menetrend/interface/index.php";
        private readonly JsonSerializerSettings setting = new JsonSerializerSettings { DateFormatHandling = DateFormatHandling.MicrosoftDateFormat };

        public IRequest GetRequest<TRequest>(string funcName, IParam param) where TRequest : IRequest, new()
        {
            TRequest request = new TRequest
            {
                FunctionName = funcName,
                Parameters = param
            };
            return request;
        }

        public async Task<TResponse> GetResponse<TResponse, TResult, TRequest>(TRequest requestToSend)
            where TResponse : IResponse<TResult> where TRequest : IRequest where TResult : IResult
        {
            using (HttpClient httpClient = new HttpClient())
            {
                StringContent httpContent = GetContent(requestToSend);
                HttpResponseMessage httpResponse = await httpClient.PostAsync(uri, httpContent);

                if (httpResponse.Content != null)
                {
                    string responseContent = await httpResponse.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<TResponse>(responseContent);
                }
            }
            throw new HttpRequestException("Failed to get data from the server!");
        }

        private StringContent GetContent<TRequest>(TRequest requestToSend)
        {
            string requestBody = JsonConvert.SerializeObject(requestToSend, setting);
            return new StringContent(requestBody, Encoding.UTF8, "application/json");
        }
    }
}