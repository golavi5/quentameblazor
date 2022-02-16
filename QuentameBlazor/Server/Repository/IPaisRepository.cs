using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface IPaisRepository : IRepositoryBase<Paises>
    {
        IEnumerable<Paises> GetAllPais();
        Paises GetPaisById(int IdPais);
    }
}
