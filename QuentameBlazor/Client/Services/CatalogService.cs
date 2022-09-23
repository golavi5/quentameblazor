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

        
    }
}