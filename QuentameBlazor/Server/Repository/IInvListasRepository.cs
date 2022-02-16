using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface IInvListasRepository : IRepositoryBase<InventariosListas>
    {
        IEnumerable<InventariosListas> GetAllInvListas();
    }
}
