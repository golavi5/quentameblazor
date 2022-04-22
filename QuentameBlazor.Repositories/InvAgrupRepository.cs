using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuentameBlazor.Models.Parameters;

namespace QuentameBlazor.Repositories
{
    public class InvAgrupRepository : RepositoryBase<InventariosAgrup1>, IInvAgrupRepository
    {
        public InvAgrupRepository(AppDbContext dbContext) : base(dbContext)
        { 
        }

        public async Task<IEnumerable<InventariosAgrup1>> GetAllInvAgrup()
        {
            return await FindAll()
                .Where(i => i.EsActivo == 1)
                .OrderBy(i => i.NomAgrup1)
                .ToListAsync();
        }

        public void CreateAgrup1(InventariosAgrup1 invagrup1)
        {
            Create(invagrup1);
        }
    }
}
