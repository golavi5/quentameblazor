using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface ITipoTerceroRepository : IRepositoryBase<ClientesAgrup1>
    {
        IEnumerable<ClientesAgrup1> GetAllTipoTerceros();

        ClientesAgrup1 GetTipoterceroById(int IdTipoTercero);
    }
}
