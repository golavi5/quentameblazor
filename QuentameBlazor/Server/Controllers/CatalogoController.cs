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
    }

}