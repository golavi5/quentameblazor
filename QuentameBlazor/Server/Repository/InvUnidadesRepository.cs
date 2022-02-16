using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Server.Repository
{
    public class InvUnidadesRepository : RepositoryBase<InventariosUnidades>, IInvUnidadesRepository
    {
        public InvUnidadesRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<InventariosUnidades> GetAllInvUnidades()
        {
            return FindAll()
                .OrderBy(i => i.NomUnidad)
                .ToList();
        }
    }
}
