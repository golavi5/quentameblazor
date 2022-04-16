using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Repositories
{
    class DptoRepository : RepositoryBase<Departamentos>, IDptoRepository
    {
        public DptoRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<Departamentos> GetAllDpto()
        {
            return FindAll()
                .OrderBy(t => t.NomDpto)
                .ToList();
        }

        public Departamentos GetDptoById(int IdDpto)
        {
            return FindByCondition(t => t.IdDpto.Equals(IdDpto))
                .FirstOrDefault();
        }

        public IEnumerable<Departamentos> GetDptosByPais(int idpais)
        {
            return FindByCondition(d => d.IdPais.Equals(idpais))
                .OrderBy(d => d.NomDpto)
                .ToList();
        }
    }
}
