using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Server.Repository
{
    public class FormasPagoRepository : RepositoryBase<Formaspago>, IFormasPagoRepository
    {
        public FormasPagoRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<Formaspago> GetAllFormasPago()
        {
            return FindAll()
                   .OrderBy(f => f.NomFormaPago)
                   .Where(f => f.EsActivo.Equals(1))
                   .ToList();
        }
    }
}
