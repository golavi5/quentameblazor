using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
//using System.Text.Json;
using System.Threading.Tasks;
using QuentameBlazor.Dto;
using Newtonsoft.Json;
using QuentameBlazor.Client.Features;
using QuentameBlazor.Models.Parameters;
using Microsoft.AspNetCore.WebUtilities;
using QuentameBlazor.Models.Entities;
using AutoMapper;

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

        public async Task<PagingResponse<ListaInvPreciosDto>> GetInvPaged(ProductParameters productParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = productParameters.PageNumber.ToString()
            };

            var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString("api/catalogo/paged", queryStringParam));
            
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var paginResponse = new PagingResponse<ListaInvPreciosDto>
            {
                Items = JsonConvert.DeserializeObject<List<ListaInvPreciosDto>>(content),
                MetaData = JsonConvert.DeserializeObject<MetaData>(response.Headers.GetValues("X-Pagination").First())
            };

            return paginResponse;
        }
    }
}