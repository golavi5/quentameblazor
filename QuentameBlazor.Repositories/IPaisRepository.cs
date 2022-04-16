using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Repositories
{
    public interface IPaisRepository : IRepositoryBase<Paises>
    {
        IEnumerable<Paises> GetAllPais();
        Paises GetPaisById(int IdPais);
    }
}
