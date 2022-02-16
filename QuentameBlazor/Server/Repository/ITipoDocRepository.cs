using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface ITipoDocRepository : IRepositoryBase<ClientesTipodoc>
    {
        IEnumerable<ClientesTipodoc> GetAllTipoDoc();
    }
}
