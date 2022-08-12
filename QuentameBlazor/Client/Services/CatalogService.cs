using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using QuentameBlazor.Dto;
using Newtonsoft.Json;

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
            var response = await _httpClient.GetAsync("api/catalogo");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            return JsonConvert.DeserializeObject<IEnumerable<ListaInvPreciosDto>>(content);

            //return await _httpClient.GetFromJsonAsync<IEnumerable<ListaInvPreciosDto>>("api/catalogo");
        }
    }
}