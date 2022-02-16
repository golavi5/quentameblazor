using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Server.Repository
{
    public class InvTiposRepository : RepositoryBase<InventariosTipos>, IInvTiposRepository
    {
        public InvTiposRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<InventariosTipos> GetAllInvTipos()
        {
            return FindAll()
                .Where(i => i.EsActivo.Equals(1))
                .OrderBy(i => i.NomTipoInven)
                .ToList();
        }
    }
}
