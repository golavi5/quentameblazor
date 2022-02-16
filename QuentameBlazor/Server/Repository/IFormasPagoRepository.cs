using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface IFormasPagoRepository : IRepositoryBase<Formaspago>
    {
        IEnumerable<Formaspago> GetAllFormasPago();
    }
}
