using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuentameBlazor.Repositories;
using QuentameBlazor.Models.Entities;
using QuentameBlazor.Dto;
using AutoMapper;

namespace QuentameBlazor.Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IInventarioRepository _invRepository;
        public readonly IMapper _mapper;

        public ProductController(IInventarioRepository invRepository, IMapper mapper)
        {
            _invRepository = invRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SearchProductDto>>> GetAllProducts()
        {
            try
            {
                var prods = await _invRepository.GetProductsByConditionAsync(i => i.EsActivo == 1);
                return Ok(prods);
            }
            catch (Exception ex)
            {
                 return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
            
        }
    }
}