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

    public class ClientController : ControllerBase
    {
        private readonly ITercerosRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientController(ITercerosRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientesDto>>> GetAllClients()
        {
            try
            {
                var clients = await _clientRepository.GetTercerosByCondition(c => c.EsActivo==1 && c.IdAgrup1 == 1);
                return Ok(_mapper.Map<IEnumerable<ClientesDto>>(clients));
            }
            catch (Exception ex)
            {
                return StatusCode(500,"Internar Server Error: " + ex.Message);
            }
            
        }
    }
}