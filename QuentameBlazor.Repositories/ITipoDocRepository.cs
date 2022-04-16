using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Repositories
{
    public interface ITipoDocRepository : IRepositoryBase<ClientesTipodoc>
    {
        IEnumerable<ClientesTipodoc> GetAllTipoDoc();
    }
}
