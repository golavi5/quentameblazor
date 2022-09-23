using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using QuentameBlazor.Dto;
using Newtonsoft.Json;
using System.Net.Http.Json;
using QuentameBlazor.Client.Features;
using QuentameBlazor.Models.Parameters;
using Microsoft.AspNetCore.WebUtilities;

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
            //return await _httpClient.GetFromJsonAsync<IEnumerable<InvAgrupDto>>("api/invagrup");
            var response = await _httpClient.GetAsync("api/invagrup");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            return JsonConvert.DeserializeObject<IEnumerable<InvAgrupDto>>(content);
        }
    }
}