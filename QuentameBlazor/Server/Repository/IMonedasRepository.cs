using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface IMonedasRepository : IRepositoryBase<Monedas>
    {
        IEnumerable<Monedas> GetAllMonedas();
    }
}
