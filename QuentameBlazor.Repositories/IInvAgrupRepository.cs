using QuentameBlazor.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuentameBlazor.Repositories
{
    public interface IInvAgrupRepository : IRepositoryBase<InventariosAgrup1>
    {
        Task<IEnumerable<InventariosAgrup1>> GetAllInvAgrup();
        void CreateAgrup1(InventariosAgrup1 invagrup1);
    }
}
