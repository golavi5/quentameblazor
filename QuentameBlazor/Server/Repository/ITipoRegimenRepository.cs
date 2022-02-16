using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface ITipoRegimenRepository : IRepositoryBase<ClientesTiporeg>
    {
        IEnumerable<ClientesTiporeg> GetAllTipoRegimen();
    }
}
