using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Repositories
{
    class PaisRepository : RepositoryBase<Paises>, IPaisRepository
    {
        public PaisRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<Paises> GetAllPais()
        {
            return FindAll()
                .OrderBy(t => t.IdPais)
                .ToList();
        }

        public Paises GetPaisById(int IdPais)
        {
            return FindByCondition(t => t.IdPais.Equals(IdPais))
                .FirstOrDefault();
        }
    }
}
