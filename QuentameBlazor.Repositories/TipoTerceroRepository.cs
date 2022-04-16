using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Repositories
{
    public class TipoTerceroRepository : RepositoryBase<ClientesAgrup1>, ITipoTerceroRepository
    {
        public TipoTerceroRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<ClientesAgrup1> GetAllTipoTerceros()
        {
            return FindAll()
                .OrderBy(t => t.NomAgrup1)
                .ToList();
        }

        public ClientesAgrup1 GetTipoterceroById(int idtipotercero)
        {
            return FindByCondition(t => t.IdAgrup1.Equals(idtipotercero))
                .FirstOrDefault();
        }
    }
}
