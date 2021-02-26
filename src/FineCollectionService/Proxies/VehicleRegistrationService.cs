using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FineCollectionService.Models;

namespace FineCollectionService.Proxies
{
    public class VehicleRegistrationService
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private JsonSerializerOptions _serializerOptions;

        public VehicleRegistrationService()
        {
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<VehicleInfo> GetVehicleInfo(string licenseNumber)
        {
            HttpResponseMessage response =
                await _httpClient.GetAsync($"http://localhost:5002/vehicleinfo/{licenseNumber}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var vehicleInfo = JsonSerializer.Deserialize<VehicleInfo>(responseBody, _serializerOptions);
            return vehicleInfo;
        }       
    }
}