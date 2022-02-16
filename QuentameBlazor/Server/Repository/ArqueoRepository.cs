using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;


namespace QuentameBlazor.Server.Repository
{
    public class ArqueoRepository : RepositoryBase<ArqueoCajas>, IArqueoRepository
    {
        public ArqueoRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public void CreateArqueo(ArqueoCajas arqueocaja)
        {
            Create(arqueocaja);
        }
    }
}
