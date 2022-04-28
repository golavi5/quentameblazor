using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuentameBlazor.Dto;
using System.Net.Http;
using System.Net.Http.Json;

namespace QuentameBlazor.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<IEnumerable<SearchProductDto>> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<SearchProductDto>>("api/product");
        }        
    }
}