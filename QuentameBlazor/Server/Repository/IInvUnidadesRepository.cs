using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface IInvUnidadesRepository : IRepositoryBase<InventariosUnidades>
    {
        IEnumerable<InventariosUnidades> GetAllInvUnidades();
    }
}
