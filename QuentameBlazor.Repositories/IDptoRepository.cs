using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Repositories
{
    public interface IDptoRepository : IRepositoryBase<Departamentos>
    {
        IEnumerable<Departamentos> GetAllDpto();
        Departamentos GetDptoById(int IdDpto);
        IEnumerable<Departamentos> GetDptosByPais(int idpais);
    }
}
