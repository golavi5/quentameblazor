using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using QuentameBlazor.Dto;

namespace QuentameBlazor.Client.Services
{
    public class EncabService : IEncabService
    {
        private readonly HttpClient _httpClient;

        public EncabService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task SaveEncab(EncabezadoDto encab)
        {
            await _httpClient.PostAsJsonAsync<EncabezadoDto>($"api/encab/", encab);
        }

        public async Task<int> GetLastEncab()
        {
            return await _httpClient.GetFromJsonAsync<int>($"api/encab/getlastencab/");
        }

    }
    
}