using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface IInvTiposRepository : IRepositoryBase<InventariosTipos>
    {
        IEnumerable<InventariosTipos> GetAllInvTipos();
    }
}
