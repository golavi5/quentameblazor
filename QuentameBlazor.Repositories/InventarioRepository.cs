using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuentameBlazor.Models.Parameters;

namespace QuentameBlazor.Repositories
{
    public class InventarioRepository : RepositoryBase<Inventarios>, IInventarioRepository
    {
        public InventarioRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public Inventarios GetInventarioByCodInv(string codinv)
        {
            return FindByCondition(i => i.CodInventario.Equals(codinv))
                .Include(i => i.InventariosAgrup1)
                .Include(i => i.InventariosClasifimpto)
                .Include(i => i.InventariosTipos)
                .Include(i => i.InventariosUnidades)
                .FirstOrDefault();
        }

        public Inventarios GetInventarioByCodBarras(string codbarras)
        {
            return FindByCondition(i => i.CodigoBarras.Equals(codbarras))
                .Include(i => i.InventariosAgrup1)
                .Include(i => i.InventariosClasifimpto)
                .Include(i => i.InventariosTipos)
                .Include(i => i.InventariosUnidades)
                .FirstOrDefault();
        }

        public Inventarios GetInventarioByCodigo(string codigo)
        {
            return FindByCondition(i => i.CodigoBarras.Equals(codigo) || i.CodInventario.Equals(codigo))
                .Include(i => i.InventariosAgrup1)
                .Include(i => i.InventariosClasifimpto)
                .Include(i => i.InventariosTipos)
                .Include(i => i.InventariosUnidades)
                .FirstOrDefault();
        }

        public IEnumerable<Inventarios> GetInventarioByNombre(string nombre)
        {
            return FindByCondition(i => i.NomInventario.Contains(nombre))
                .OrderBy(i => i.NomInventario)
                .ToList();
        }

        public int GetLastIdProd()
        {
            return FindByCondition(i => i.EsActivo.Equals(1))
                .Max(i => i.IdInventario);
        }

        public Inventarios GetInventarioByIdWithDetails(int id)
        {
            return FindByCondition(i => i.IdInventario.Equals(id))
                .Include(i => i.InventariosAgrup1)
                .Include(i => i.InventariosClasifimpto)
                .Include(i => i.InventariosTipos)
                .Include(i => i.InventariosUnidades)
                .FirstOrDefault();
        }

        public Inventarios GetInventarioById(int id)
        {
            return FindByCondition(i => i.IdInventario.Equals(id))
                .FirstOrDefault();
        }

        public IEnumerable<Inventarios> GetAllProducts()
        {
            return FindAll()
                .Where(i => i.EsActivo == 1)
                .OrderBy(i => i.NomInventario)
                .ToList();
        }

        public IEnumerable<Inventarios> GetProductsByCondition(Expression<Func<Inventarios, bool>> expression)
        {
            return FindByCondition(expression)
                .Where(i => i.EsActivo.Equals(1))
                .Include(i => i.InventariosAgrup1)
                .Include(i => i.InventariosClasifimpto)
                .Include(i => i.InventariosTipos)
                .Include(i => i.InventariosUnidades)
                .OrderBy(i => i.NomInventario);
        }

        public async Task<IEnumerable<Inventarios>> GetProductsByConditionAsync(Expression<Func<Inventarios, bool>> expression)
        {
            return await FindByCondition(expression)
                    .Include(i => i.InventariosAgrup1)
                    .Include(i => i.InventariosClasifimpto)
                    .Include(i => i.InventariosTipos)
                    .Include(i => i.InventariosUnidades)
                    .OrderBy(t => t.NomInventario)
                    .ToListAsync();
        }

        public PagedList<Inventarios> GetInventariosPaged(InventarioParameters inventarioParameters)
        {
            var inventario = FindByCondition(i => i.EsActivo == 1)
                .Include(i => i.InventariosAgrup1)
                .Include(i => i.InventariosClasifimpto)
                .Include(i => i.InventariosTipos)
                .Include(i => i.InventariosUnidades)
                .Take(500)
                .OrderBy(i => i.NomInventario);

            return PagedList<Inventarios>.ToPagedList(inventario,
                inventarioParameters.PageNumber,
                inventarioParameters.PageSize);
        }

        public PagedList<Inventarios> GetInventariosPagedFilter(InventarioParameters inventarioParameters, Expression<Func<Inventarios, bool>> expression)
        {
            var inventario = FindByCondition(expression)
                .Include(i => i.InventariosAgrup1)
                .Include(i => i.InventariosClasifimpto)
                .Include(i => i.InventariosTipos)
                .Include(i => i.InventariosUnidades)
                .Where(i => i.EsActivo == 1)
                .Take(500)
                .OrderBy(i => i.NomInventario);

            return PagedList<Inventarios>.ToPagedList(inventario,
                inventarioParameters.PageNumber,
                inventarioParameters.PageSize);
        }

        public void CreateIventario(Inventarios inventarios)
        {
            Create(inventarios);
        }
        public void UpdateInventario(Inventarios inventarios)
        {
            Update(inventarios);
        }
        public void UpdateRangeInventarios(List<Inventarios> inventarios)
        {
            UpdateRange(inventarios);
        }
        public void DeleteInventario(Inventarios inventarios)
        {
            Delete(inventarios);
        }
    }
}
