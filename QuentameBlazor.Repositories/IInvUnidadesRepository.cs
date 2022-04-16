using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Repositories
{
    public interface IInvUnidadesRepository : IRepositoryBase<InventariosUnidades>
    {
        IEnumerable<InventariosUnidades> GetAllInvUnidades();
    }
}
