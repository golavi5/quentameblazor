using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface IInvAgrupRepository : IRepositoryBase<InventariosAgrup1>
    {
        IEnumerable<InventariosAgrup1> GetAllInvAgrup();
        void CreateAgrup1(InventariosAgrup1 invagrup1);
    }
}
