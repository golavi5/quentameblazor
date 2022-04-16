using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Repositories
{
    public class InvAgrupRepository : RepositoryBase<InventariosAgrup1>, IInvAgrupRepository
    {
        public InvAgrupRepository(AppDbContext dbContext) : base(dbContext)
        { 
        }

        public IEnumerable<InventariosAgrup1> GetAllInvAgrup()
        {
            return FindAll()
                .Where(i => i.EsActivo == 1)
                .OrderBy(i => i.NomAgrup1)
                .ToList();
        }

        public void CreateAgrup1(InventariosAgrup1 invagrup1)
        {
            Create(invagrup1);
        }
    }
}
