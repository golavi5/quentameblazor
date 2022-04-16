using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Repositories
{
    public class MonedasRepository : RepositoryBase<Monedas>, IMonedasRepository
    {
        public MonedasRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<Monedas> GetAllMonedas()
        {
            return FindAll()
                .OrderBy(m => m.MonedaId)
                .Where(m => m.MonedaActivo.Equals(1))
                .ToList();
        }
    }
}
