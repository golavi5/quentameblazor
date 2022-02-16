using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Server.Repository
{
    public class InvListasRepository : RepositoryBase<InventariosListas>, IInvListasRepository
    {
        public InvListasRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<InventariosListas> GetAllInvListas()
        {
            return FindAll()
                .OrderBy(i => i.NomLista)
                .ToList();
        }
    }
}
