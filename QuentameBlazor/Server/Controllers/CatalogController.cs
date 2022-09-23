using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuentameBlazor.Repositories;
using QuentameBlazor.Models.Entities;
using QuentameBlazor.Models.Parameters;
using QuentameBlazor.Dto;
using AutoMapper;
/* using Newtonsoft.Json; */
using System.Text.Json;

namespace QuentameBlazor.Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class CatalogController : ControllerBase
    {
        public readonly IInventarioRepository _invRepository;
        private readonly IMapper _mapper;

        public CatalogController(IInventarioRepository invRepository, IMapper mapper)
        {
            _invRepository = invRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts([FromQuery] ProductParameters productParameters)
        {
            try
            {
                var products = await _invRepository.GetSearchedProductsAsync(productParameters);
                var productlist = _mapper.Map<List<ListFilteredProductsDto>>(products);
                
                return Ok(productlist);
            }
            catch (Exception ex)
            {
                return StatusCode(500,"Internar Server Error: " + ex.Message);
            }
        }
    }

    
}