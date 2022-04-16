using QuentameBlazor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using QuentameBlazor.Models.Parameters;

namespace QuentameBlazor.Repositories
{
    public interface IInventarioRepository : IRepositoryBase<Inventarios>
    {
        Inventarios GetInventarioByCodInv(string codinv);
        Inventarios GetInventarioByCodBarras(string codbarras);
        Inventarios GetInventarioByCodigo(string codigo);
        IEnumerable<Inventarios> GetInventarioByNombre(string nombre);
        int GetLastIdProd();
        Task<IEnumerable<Inventarios>> GetAllProducts();
        Inventarios GetInventarioByIdWithDetails(int id);
        Inventarios GetInventarioById(int id);
        IEnumerable<Inventarios> GetProductsByCondition(Expression<Func<Inventarios, bool>> expression);
        Task<IEnumerable<Inventarios>> GetProductsByConditionAsync(Expression<Func<Inventarios, bool>> expression);
        PagedList<Inventarios> GetInventariosPaged(InventarioParameters inventarioParameters);
        PagedList<Inventarios> GetInventariosPagedFilter(InventarioParameters inventarioParameters, Expression<Func<Inventarios, bool>> expression);
        void CreateIventario(Inventarios inventarios);
        void UpdateInventario(Inventarios inventarios);
        void UpdateRangeInventarios(List<Inventarios> inventarios);
        void DeleteInventario(Inventarios inventarios);
    }
}
