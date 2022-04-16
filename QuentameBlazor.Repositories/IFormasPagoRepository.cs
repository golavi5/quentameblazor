using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Repositories
{
    public interface IFormasPagoRepository : IRepositoryBase<Formaspago>
    {
        IEnumerable<Formaspago> GetAllFormasPago();
    }
}
