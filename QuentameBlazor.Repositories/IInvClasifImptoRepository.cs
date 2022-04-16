using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Repositories
{
    public interface IInvClasifImptoRepository : IRepositoryBase<InventariosClasifimpto>
    {
        IEnumerable<InventariosClasifimpto> GetAllInvClasifImpto();
    }
}
