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

    public class InvAgrupController : ControllerBase
    {
        private readonly IInvAgrupRepository _invAgrupRepository;
        private readonly IMapper _mapper;

        public InvAgrupController(IInvAgrupRepository invAgrupRepository, IMapper mapper)
        {
            _invAgrupRepository = invAgrupRepository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvAgrupDto>>> GetAllInvAgrups()
        {
            /* var invagrup = await _invAgrupRepository.GetAllInvAgrup();
            return Ok(invagrup); */
            
            try
            {
                var invagrup = await _invAgrupRepository.GetAllInvAgrup();
                return Ok(_mapper.Map<IEnumerable<InvAgrupDto>>(invagrup));
            }
            catch (Exception ex)
            {
                return StatusCode(500,"Internal Server Error: " + ex.Message);
            }
          
        }
    }
}