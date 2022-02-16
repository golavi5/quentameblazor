using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface ICiudadRepository : IRepositoryBase<Ciudades>
    {
        IEnumerable<Ciudades> GetAllCiudades();
        IEnumerable<Ciudades> GetCiudadesByDpto(int IdDpto);
        Ciudades GetCiudadById(int IdCiudad);
    }
}
