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

    public class CatalogoController : ControllerBase
    {
        private readonly IInvPreciosRepository _invPrecioRepository;
        private readonly IMapper _mapper;

        public CatalogoController(IInvPreciosRepository invPrecioRepository, IMapper mapper)
        {
            _invPrecioRepository = invPrecioRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ListaInvPreciosDto>> GetProductsWithPrices()
        {
            //create list for catalog with prices
            IEnumerable<ListaInvPreciosDto> ProductsList;
            var invprices =  await _invPrecioRepository.GetInvPreciosByConditionAsync(i => i.IdLista == 1);
            ProductsList = _mapper.Map<IEnumerable<ListaInvPreciosDto>>(invprices);
            return ProductsList;
        }

        [HttpGet("Paged")]
        public async Task<ActionResult> GetAllPagedProducts([FromQuery] ProductParameters productParameters)
        {
            try
            {
                var invprices = await _invPrecioRepository.GetPagedInvPrecios(productParameters);
                var productlist = _mapper.Map<List<ListaInvPreciosDto>>(invprices);

                Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(invprices.MetaData));
                
                return Ok(productlist);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500,"Internar Server Error: " + ex.Message);
            }
        }
    }

}