using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuentameBlazor.Dto;
using System.Net.Http;
using System.Net.Http.Json;

namespace QuentameBlazor.Client.Services
{
    public class InvAgrupService : IInvAgrupService
    {
        private readonly HttpClient _httpClient;

        public InvAgrupService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<InvAgrupDto>> GetInvAgrups()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<InvAgrupDto>>("api/invagrup");
        }
    }
}