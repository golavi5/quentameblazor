using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Server.Repository
{
    public class TipoRegimenRepository : RepositoryBase<ClientesTiporeg>, ITipoRegimenRepository
    {
        public TipoRegimenRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<ClientesTiporeg> GetAllTipoRegimen()
        {
            return FindAll()
                   .OrderBy(t => t.NomTipoReg)
                   .ToList();
        }
    }
}
