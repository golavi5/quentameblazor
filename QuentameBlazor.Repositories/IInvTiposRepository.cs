using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Repositories
{
    public interface IInvTiposRepository : IRepositoryBase<InventariosTipos>
    {
        IEnumerable<InventariosTipos> GetAllInvTipos();
    }
}
