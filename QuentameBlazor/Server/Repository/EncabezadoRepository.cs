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
    public class EncabezadoRepository : RepositoryBase<Encabezados>, IEncabezadoRepository
    {
        public EncabezadoRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public Encabezados GetUltEncabezado(int tipoencab)
        {
            return FindByCondition(e => e.IdDocumento.Equals(tipoencab))
                .OrderByDescending(e => e.NumDocumento)
                .FirstOrDefault();
        }

        public Encabezados GetEncabezadosByIdEncab(int idencab)
        {
            return FindByCondition(e => e.IdEncab.Equals(idencab))
                .Include(e => e.Clientes)
                .Include(e => e.Documentos)
                .Include(e => e.Formaspago)
                .Include(e => e.Usuarios)
                .FirstOrDefault();
        }

        public PagedList<Encabezados> GetEncabezadosPaged(EncabezadosParameters encabezadoParameters)
        {
            var ventas = FindByCondition(e => e.EsAnulado == 0)
                .Include(e => e.Clientes)
                .Include(e => e.Documentos)
                .Include(e => e.Formaspago)
                .Include(e => e.Usuarios)
                .OrderByDescending(e => e.Fecha);

            return PagedList<Encabezados>.ToPagedList(ventas,
                encabezadoParameters.PageNumber,
                encabezadoParameters.PageSize);
        }
        public PagedList<Encabezados> GetEncabezadosPagedFilter(EncabezadosParameters encabezadoParameters, Expression<Func<Encabezados, bool>> expression)
        {
            var ventas = FindByCondition(expression)
                .Include(e => e.Clientes)
                .Include(e => e.Documentos)
                .Include(e => e.Formaspago)
                .Include(e => e.Usuarios)
                .OrderByDescending(e => e.Fecha);

            return PagedList<Encabezados>.ToPagedList(ventas,
                encabezadoParameters.PageNumber,
                encabezadoParameters.PageSize);
        }
        public IEnumerable<Encabezados> GetAllEncabByDate(DateTime fechainicio, DateTime fechafin, int tipoencab)
        {
            return FindByCondition(e => e.Fecha.Date >= fechainicio.Date && e.Fecha.Date <= fechafin.Date)
                .Include(e => e.Clientes)
                .Include(e => e.Documentos)
                .Include(e => e.Formaspago)
                .Include(e => e.Usuarios)
                .Where(e => e.IdDocumento.Equals(tipoencab))
                .OrderByDescending(e => e.Fecha)
                .ToList();
        }

        public IEnumerable<Encabezados> GetEncabByIdTercero(DateTime fechainicio, DateTime fechafin, int idtercero)
        {
            return FindByCondition(e => e.Fecha.Date >= fechainicio.Date && e.Fecha.Date <= fechafin.Date && e.IdCliente == idtercero)
                .Include(e => e.Clientes)
                .Include(e => e.Documentos)
                .Include(e => e.Formaspago)
                .Include(e => e.Usuarios)
                .Where(e => e.IdFormaPago.Equals(2))
                .OrderByDescending(e => e.Fecha)
                .ToList();
        }


        public void CreateEncabezado(Encabezados encabezados)
        {
            Create(encabezados);
        }
        public void UpdateEncabezado(Encabezados encabezados)
        {
            Update(encabezados);
        }
        public void DeleteEncabezado(Encabezados encabezados)
        {
            Delete(encabezados);
        }
        

    }
}
