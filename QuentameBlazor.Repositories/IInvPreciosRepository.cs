using QuentameBlazor.Models.Entities;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Threading.Tasks;

namespace QuentameBlazor.Repositories
{
    public interface IInvPreciosRepository : IRepositoryBase<InventariosPrecios>
    {
        IEnumerable<InventariosPrecios> GetAllPrecios();
        Task<IEnumerable<InventariosPrecios>> GetInvPreciosByConditionAsync(Expression<Func<InventariosPrecios, bool>> expression);
        InventariosPrecios GetPrecioByCondition(Expression<Func<InventariosPrecios, bool>> expression);
        InventariosPrecios GetInvPrecioByIds(int idlista, int idinv);
        IEnumerable<InventariosPrecios> GetPreciosByIdInv(int idinv);
        void CreateRangeInventarioPrecios(List<InventariosPrecios> inventariosPrecios);
        void UpdateRangeInventarioPrecios(List<InventariosPrecios> inventariosPrecios);
    }
}
