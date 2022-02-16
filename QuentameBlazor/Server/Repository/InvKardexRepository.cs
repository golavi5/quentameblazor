using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using QuentameBlazor.Server.Parameters;

namespace QuentameBlazor.Server.Repository
{
    public class InvKardexRepository : RepositoryBase<InventariosKardex>, IInvKardexRepository
    {
        public InvKardexRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<InventariosKardex> GetAllKardex(DateTime fechainicio, DateTime fechafin)
        {
            return FindByCondition(i => i.KardexFecha >= fechainicio && i.KardexFecha <= fechafin)
                .Include(i => i.Encabezados)
                .Include(i => i.Inventarios)
                .OrderByDescending(i => i.KardexFecha)
                .ToList();
        }

        public IEnumerable<InventariosKardex> GetKardexByIdInv(int idinv, DateTime fechainicio, DateTime fechafin)
        {
            return FindByCondition(i => i.IdInventario.Equals(idinv) && i.KardexFecha >= fechainicio && i.KardexFecha <= fechafin)
                .Include(i => i.Encabezados)
                .Include(i => i.Inventarios)
                .OrderByDescending(i => i.KardexFecha)
                .ToList();
        }

        public void CreateInvKardex(InventariosKardex inventariosKardex)
        {
            Create(inventariosKardex);
        }
        public void CreateRangeInvKardex(List<InventariosKardex> listainvkardex)
        {
            CreateRange(listainvkardex);
        }
    }
}
