using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Repositories
{
    public class TipoDocRepository : RepositoryBase<ClientesTipodoc>, ITipoDocRepository
    {
        public TipoDocRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<ClientesTipodoc> GetAllTipoDoc()
        {
            return FindAll()
                .Where(t => t.EsActivo == 1)
                .OrderBy(t => t.NombreTipoDoc)
                .ToList();
        }
    }
}
