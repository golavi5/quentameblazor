using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuentameBlazor.Dto;
using QuentameBlazor.Models.Entities;
using QuentameBlazor.Client.Features;
using QuentameBlazor.Models.Parameters;

namespace QuentameBlazor.Client.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<ListaInvPreciosDto>> GetInvWithPrices();
        Task<PagingResponse<ListaInvPreciosDto>> GetInvPaged(ProductParameters productParameters);
    }    
}