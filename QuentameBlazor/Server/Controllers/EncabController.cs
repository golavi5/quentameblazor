using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuentameBlazor.Repositories;
using QuentameBlazor.Models.Entities;
using QuentameBlazor.Dto;
using AutoMapper;
using System.Transactions;

namespace QuentameBlazor.Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class EncabController : ControllerBase
    {
        private readonly IEncabezadoRepository _encabRepository;
        private readonly IEncabezadoMovRepository _encabMovRepository;
        private readonly IMapper _mapper;
        
        public EncabController(IEncabezadoRepository encabRepository, IEncabezadoMovRepository encabMovRepository, IMapper mapper)
        {
            _encabRepository = encabRepository;
            _encabMovRepository = encabMovRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateEncabDto newencab)
        {
            if (newencab == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                int newdocnumb = 0;
                var lastencab = await _encabRepository.GetUltEncabezado(2);
                if (lastencab == null)
                {
                    newdocnumb = 1;
                }
                else
                {
                    newdocnumb = int.Parse(newencab.NumDocumento) + 1;
                }

                newencab.NumDocumento = newdocnumb.ToString();
                newencab.IdDocumento = 2;
                newencab.IdEmpresa = 1;

                Encabezados encab = new Encabezados();
                encab = _mapper.Map<Encabezados>(newencab);
                _encabRepository.CreateEncabezado(encab);
                
                if (newencab.EncabMovs != null && newencab.EncabMovs.Any())
                {
                    foreach (var mov in newencab.EncabMovs)
                    {
                        var newmov = new EncabezadosMov();
                        newmov = _mapper.Map<EncabezadosMov>(mov);
                         _encabMovRepository.CreateEncabezadoMov(newmov);
                    }
                    
                }

                scope.Complete();
            }

            return NoContent();
        }
    }
}