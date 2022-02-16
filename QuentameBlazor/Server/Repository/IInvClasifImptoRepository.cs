using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface IInvClasifImptoRepository : IRepositoryBase<InventariosClasifimpto>
    {
        IEnumerable<InventariosClasifimpto> GetAllInvClasifImpto();
    }
}
