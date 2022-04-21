using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuentameBlazor.Dto;

namespace QuentameBlazor.Client.Services
{
    interface IInvAgrupService
    {
        Task<IEnumerable<InvAgrupDto>> GetInvAgrups();
    }
}