using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuentameBlazor.Server.Parameters;

namespace QuentameBlazor.Server.Repository
{
    public class InvPreciosRepository : RepositoryBase<InventariosPrecios>, IInvPreciosRepository
    {
        public InvPreciosRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<InventariosPrecios> GetAllPrecios()
        {
            return FindAll()
                .OrderBy(i => i.IdLista)
                .ToList();
        }

        public async Task<IEnumerable<InventariosPrecios>> GetInvPreciosByConditionAsync(Expression<Func<InventariosPrecios, bool>> expression)
        {
            return await FindByCondition(expression)
                .Where(i => i.IdLista.Equals(1))
                .Include(i => i.Inventarios)
                .Include(i => i.Inventarios.InventariosAgrup1)
                .Include(i => i.Inventarios.InventariosClasifimpto)
                .Include(i => i.Inventarios.InventariosUnidades)
                .Include(i => i.InventariosListas)
                .Include(i => i.Inventarios.InventariosTipos)
                .ToListAsync();
        }

        //public IEnumerable<InventariosPrecios> GetPreciosByDistinctId(int id)
        //{
        //    var listapreciosbyid = FindByCondition(i => i.IdInventario.Equals(id))
        //        .GroupBy(i => i.IdInventario)
        //        .Select(group => new
        //        {
        //            IdInventario = group.Key,
        //            Precio1 = group.Where(c => c.IdLista == 1).Max(),
        //            Precio2 = group.Where(c => c.IdLista == 2).Max(),
        //            Precio3 = group.Where(c => c.IdLista == 3).Max(),
        //            Precio4 = group.Where(c => c.IdLista == 4).Max()
        //        })
        //        .ToList();

        //    return (IEnumerable<InventariosPrecios>)listapreciosbyid;
        //}

        public InventariosPrecios GetPrecioByCondition(Expression<Func<InventariosPrecios, bool>> expression)
        {
            return FindByCondition(expression)
                .Include(i => i.Inventarios)
                .Include(i => i.Inventarios.InventariosAgrup1)
                .Include(i => i.Inventarios.InventariosClasifimpto)
                .Include(i => i.Inventarios.InventariosUnidades)
                .Include(i => i.InventariosListas)
                .Include(i => i.Inventarios.InventariosTipos)
                .FirstOrDefault();
        }

        public InventariosPrecios GetInvPrecioByIds(int idlista, int idinv)
        {
            return FindByCondition(i => i.IdLista == idlista && i.IdInventario == idinv)
                .FirstOrDefault();
        }

        public IEnumerable<InventariosPrecios> GetPreciosByIdInv(int idinv)
        {
            return FindByCondition(i => i.IdInventario.Equals(idinv))
                .Include(i => i.Inventarios)
                .Include(i => i.InventariosListas)
                .OrderBy(i => i.IdLista)
                .ToList();
        }

        public void CreateRangeInventarioPrecios(List<InventariosPrecios> inventariosPrecios)
        {
            CreateRange(inventariosPrecios);
        }

        public void UpdateRangeInventarioPrecios(List<InventariosPrecios> inventariosPrecios)
        {
            UpdateRange(inventariosPrecios);
        }
    }
}
