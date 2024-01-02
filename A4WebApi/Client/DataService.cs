using A4WebApi.Shared.Models;
using System.Net.Http.Json;

namespace A4WebApi.Client
{
    public class DataService
    {
        private readonly HttpClient _httpClient;

        public DataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task SubmitData(Doctor data)
        {
            await _httpClient.PostAsJsonAsync("api/v1/doctor/submitdata", data);
        }
    }
}
