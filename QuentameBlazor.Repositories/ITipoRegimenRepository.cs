using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Repositories
{
    public interface ITipoRegimenRepository : IRepositoryBase<ClientesTiporeg>
    {
        IEnumerable<ClientesTiporeg> GetAllTipoRegimen();
    }
}
