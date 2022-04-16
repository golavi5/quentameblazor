using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using QuentameBlazor.Server.Parameters;
using System.Threading.Tasks;

namespace QuentameBlazor.Server.Repository
{
    public class EncabezadoRepository : RepositoryBase<Encabezados>, IEncabezadoRepository
    {
        public EncabezadoRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<Encabezados> GetUltEncabezado(int tipoencab)
        {
            return await FindByCondition(e => e.IdDocumento.Equals(tipoencab))
                .OrderByDescending(e => e.NumDocumento)
                .FirstOrDefaultAsync();
        }

        public async Task<Encabezados> GetEncabezadosByIdEncab(int idencab)
        {
            return await FindByCondition(e => e.IdEncab.Equals(idencab))
                .Include(e => e.Clientes)
                .Include(e => e.Documentos)
                .Include(e => e.Formaspago)
                .Include(e => e.Usuarios)
                .FirstOrDefaultAsync();
        }

        public async Task<PagedList<Encabezados>> GetEncabezadosPaged(EncabezadosParameters encabezadoParameters)
        {
            var encab = await FindByCondition(e => e.EsAnulado == 0)
                .Include(e => e.Clientes)
                .Include(e => e.Documentos)
                .Include(e => e.Formaspago)
                .Include(e => e.Usuarios)
                .OrderByDescending(e => e.Fecha)
                .ToListAsync();

            return PagedList<Encabezados>.ToPagedList(encab,
                encabezadoParameters.PageNumber,
                encabezadoParameters.PageSize);
        }
        public async Task<PagedList<Encabezados>> GetEncabezadosPagedFilter(EncabezadosParameters encabezadoParameters, Expression<Func<Encabezados, bool>> expression)
        {
            var encab = await FindByCondition(expression)
                .Include(e => e.Clientes)
                .Include(e => e.Documentos)
                .Include(e => e.Formaspago)
                .Include(e => e.Usuarios)
                .OrderByDescending(e => e.Fecha)
                .ToListAsync();

            return PagedList<Encabezados>.ToPagedList(encab,
                encabezadoParameters.PageNumber,
                encabezadoParameters.PageSize);
        }
        public async Task<IEnumerable<Encabezados>> GetAllEncabByDate(DateTime fechainicio, DateTime fechafin, int tipoencab)
        {
            return await FindByCondition(e => e.Fecha.Date >= fechainicio.Date && e.Fecha.Date <= fechafin.Date)
                .Include(e => e.Clientes)
                .Include(e => e.Documentos)
                .Include(e => e.Formaspago)
                .Include(e => e.Usuarios)
                .Where(e => e.IdDocumento.Equals(tipoencab))
                .OrderByDescending(e => e.Fecha)
                .ToListAsync();
        }

        public async Task<IEnumerable<Encabezados>> GetEncabByIdTercero(DateTime fechainicio, DateTime fechafin, int idtercero)
        {
            return await FindByCondition(e => e.Fecha.Date >= fechainicio.Date && e.Fecha.Date <= fechafin.Date && e.IdCliente == idtercero)
                .Include(e => e.Clientes)
                .Include(e => e.Documentos)
                .Include(e => e.Formaspago)
                .Include(e => e.Usuarios)
                .Where(e => e.IdFormaPago.Equals(2))
                .OrderByDescending(e => e.Fecha)
                .ToListAsync();
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
