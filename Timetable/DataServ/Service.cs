using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using DataService.IModel.IResponse;
using DataService.IModel.IRequests;

namespace DataService
{
    public static class Service
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string uri = @"https://menetrendek.hu/menetrend/interface/index.php";
        private static readonly JsonSerializerSettings setting = new JsonSerializerSettings { DateFormatHandling = DateFormatHandling.MicrosoftDateFormat };

        public static async Task<TResponse> PostAsync<TResponse, TResult, TRequest>(TRequest requestToSend)
            where TResponse:IResponse<TResult> where TRequest:IRequest where TResult:IResult
        {
            string requestBody = JsonConvert.SerializeObject(requestToSend, setting);
            var httpContent = new StringContent(requestBody, Encoding.UTF8, "application/json");
            TResponse response = default(TResponse);
            //default(IResponse);
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = await httpClient.PostAsync(uri, httpContent);
                
                if (httpResponse.Content != null)
                {
                    string responseContent = await httpResponse.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<TResponse>(responseContent);
                }
            }
            return response;
        }
    }
}
