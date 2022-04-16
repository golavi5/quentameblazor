using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using QuentameBlazor.Models.Parameters;

namespace QuentameBlazor.Repositories
{
    public class TercerosRepository : RepositoryBase<Clientes>, ITercerosRepository
    {
        public TercerosRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public int GetAllTercerosCount()
        {
            return FindAll()
                .Where(t => t.EsActivo.Equals(1) && (t.IdAgrup1.Equals(2) || t.IdAgrup1.Equals(3) || t.IdAgrup1.Equals(4)))
                .ToList()
                .Count();
        }

        public int GetTercerosCountByCondition(Expression<Func<Clientes, bool>> expression)
        {
            return FindByCondition(expression)
                .Where(t => t.EsActivo.Equals(1) && (t.IdAgrup1.Equals(2) || t.IdAgrup1.Equals(3) || t.IdAgrup1.Equals(4)))
                .ToList()
                .Count();
        }

        public IEnumerable<Clientes> GetAllTerceros()
        {
            return FindAll()
                .Where(t => t.EsActivo.Equals(1))
                .OrderBy(t => t.Nombre1)
                .ToList();
        }

        public IEnumerable<Clientes> GetTercerosWithDetails()
        {
            var clientes = AppDbContext.Clientes
                .Include(tercero => tercero.ClientesAgrup1)
                .Include(tercero => tercero.Ciudad)
                .Include(tercero => tercero.Dpto)
                .Include(tercero => tercero.Lista)
                .Include(tercero => tercero.TipoRegimen)
                .Include(tercero => tercero.TipoDoc)
                .ToList();
            return clientes;
        }


        public PagedList<Clientes> GetTercerosPaged(TerceroParameters terceroParameters)
        {

            var clientes = FindByCondition(c => c.EsActivo == 1)
                .Include(c => c.ClientesAgrup1)
                .Include(c => c.Ciudad)
                .Include(c => c.Dpto)
                .Include(c => c.Lista)
                .Include(c => c.TipoRegimen)
                .Include(c => c.TipoDoc)
                .OrderBy(c => c.Nombre1);

            return PagedList<Clientes>.ToPagedList(clientes,
                terceroParameters.PageNumber,
                terceroParameters.PageSize);
        }

        public PagedList<Clientes> GetTercerosPagedFilter(TerceroParameters terceroParameters, Expression<Func<Clientes, bool>> expression)
        {
            var clientes = FindByCondition(expression)
                .Include(c => c.ClientesAgrup1)
                .Include(c => c.Ciudad)
                .Include(c => c.Dpto)
                .Include(c => c.Lista)
                .Include(c => c.TipoRegimen)
                .Include(c => c.TipoDoc)
                .Where(c => c.EsActivo == 1)
                .OrderBy(c => c.Nombre1);

            return PagedList<Clientes>.ToPagedList(clientes,
                terceroParameters.PageNumber,
                terceroParameters.PageSize);
        }

        public Clientes GetTerceroById(int IdTercero)
        {
            return FindByCondition(tercero => tercero.IdCliente.Equals(IdTercero))
                .Include(c => c.ClientesAgrup1)
                .Include(c => c.Ciudad)
                .Include(c => c.Dpto)
                .Include(c => c.Lista)
                .Include(c => c.TipoRegimen)
                .Include(c => c.TipoDoc)
                .FirstOrDefault();
        }

        public Clientes GetTerceroByDoc(string documento)
        {
            return FindByCondition(tercero => tercero.NumDoc.Equals(documento))
                .FirstOrDefault();
        }

        public IEnumerable<Clientes> GetTercerosByCondition(Expression<Func<Clientes, bool>> expression)
        {
            return FindByCondition(expression)
                .Where(c => c.EsActivo.Equals(1))
                .Include(c => c.ClientesAgrup1)
                .Include(c => c.Ciudad)
                .Include(c => c.Dpto)
                .Include(c => c.Lista)
                .Include(c => c.TipoRegimen)
                .Include(c => c.TipoDoc)
                .OrderBy(i => i.Nombre1)
                .ToList();
        }

        public void CreateTercero(Clientes tercero)
        {
            Create(tercero);
        }

        public void UpdateTercero(Clientes tercero)
        {
            Update(tercero);
        }

        public void DeleteTercero(Clientes tercero)
        {
            Delete(tercero);
        }
    }
}
