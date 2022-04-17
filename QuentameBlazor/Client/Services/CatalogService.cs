using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using QuentameBlazor.Dto;

namespace QuentameBlazor.Client.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly HttpClient _httpClient;

        public CatalogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<ListaInvPreciosDto>> GetInvWithPrices()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ListaInvPreciosDto>>("api/catalogo");
        }
    }
}