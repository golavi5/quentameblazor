using QuentameBlazor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using QuentameBlazor.Models.Parameters;

namespace QuentameBlazor.Repositories
{
    public interface ITercerosRepository : IRepositoryBase<Clientes>
    {
        int GetAllTercerosCount();
        int GetTercerosCountByCondition(Expression<Func<Clientes, bool>> expression);
        IEnumerable<Clientes> GetAllTerceros();
        IEnumerable<Clientes> GetTercerosWithDetails();
        PagedList<Clientes> GetTercerosPaged(TerceroParameters terceroParameters);
        PagedList<Clientes> GetTercerosPagedFilter(TerceroParameters terceroParameters, Expression<Func<Clientes, bool>> expression);
        Clientes GetTerceroById(int TerId);
        Clientes GetTerceroByDoc(string documento);
        IEnumerable<Clientes> GetTercerosByCondition(Expression<Func<Clientes, bool>> expression);
        void CreateTercero(Clientes tercero);
        void UpdateTercero(Clientes tercero);
        void DeleteTercero(Clientes tercero);
    }
}
