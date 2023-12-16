using System.Text.Json;
using WgApi.Helpers;
using WgApi.Models.ApiContracts;

namespace WgApi.Services
{
    public class BaseService
    {
        private readonly HttpClient _httpClient;
        private readonly string _accessToken;
        private readonly string _applicationId;
        private readonly string _baseUrl;
        public BaseService(string applicationId, string accessToken, string baseUrl)
        {
            _applicationId = applicationId;
            _accessToken = accessToken;
            _baseUrl = baseUrl;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl),
                Timeout = TimeSpan.FromSeconds(30)
            };
        }

        public async Task<Response<TResponse>> GetResponseAsync<TResponse>(string url)
        {
            var finalUrl = url.AddParamIfNotExist("application_id", _applicationId).AddParamIfNotExist("access_token", _accessToken);
            var responseMessage = await _httpClient.GetAsync(finalUrl);            
            var content = await responseMessage.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Response<TResponse>>(content);
        }
    }
}
