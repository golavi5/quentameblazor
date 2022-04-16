using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuentameBlazor.Repositories;
using QuentameBlazor.Models.Entities;
using QuentameBlazor.Server.Dto;
using AutoMapper;

namespace QuentameBlazor.Server
{
    [Route("api/[controller]")]
    [ApiController]

    public class CatalogoController : ControllerBase
    {
        private readonly IInventarioRepository _inventarioRepository;
        private readonly IMapper _mapper;

        public CatalogoController(IInventarioRepository inventarioRepository, IMapper mapper)
        {
            _inventarioRepository = inventarioRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Inventarios>> GetProducts()
        {
            return await _inventarioRepository.GetAllProducts();
        }
    }

}