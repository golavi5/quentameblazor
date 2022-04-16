using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Repositories
{
    public interface IMonedasRepository : IRepositoryBase<Monedas>
    {
        IEnumerable<Monedas> GetAllMonedas();
    }
}
