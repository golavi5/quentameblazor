using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Repositories
{
    public interface IInvListasRepository : IRepositoryBase<InventariosListas>
    {
        IEnumerable<InventariosListas> GetAllInvListas();
    }
}
