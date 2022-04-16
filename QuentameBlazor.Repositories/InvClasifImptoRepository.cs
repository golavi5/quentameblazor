using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Repositories
{
    public class InvClasifImptoRepository : RepositoryBase<InventariosClasifimpto>, IInvClasifImptoRepository
    {
        public InvClasifImptoRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<InventariosClasifimpto> GetAllInvClasifImpto()
        {
            return FindAll()
                .OrderBy(i => i.NomClasifImpto)
                .ToList();
        }
    }
}
