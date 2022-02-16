using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuentameBlazor.Server.Repository
{
    class CiudadRepository : RepositoryBase<Ciudades>, ICiudadRepository
    {
        public CiudadRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<Ciudades> GetAllCiudades()
        {
            return FindAll()
                .OrderBy(t => t.NomCiudad)
                .ToList();
        }


        public IEnumerable<Ciudades> GetCiudadesByDpto(int IdDpto)
        {
            return FindByCondition(c => c.IdDpto.Equals(IdDpto))
                .OrderBy(c => c.NomCiudad)
                .ToList();
        }

        public Ciudades GetCiudadById(int IdCiudad)
        {
            return FindByCondition(c => c.IdCiudad.Equals(IdCiudad))
                .FirstOrDefault();
        }
    }
}
