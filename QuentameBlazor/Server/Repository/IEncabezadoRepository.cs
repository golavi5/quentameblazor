using QuentameBlazor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using QuentameBlazor.Server.Parameters;
using System.Threading.Tasks;

namespace QuentameBlazor.Server.Repository
{
    public interface IEncabezadoRepository : IRepositoryBase<Encabezados>
    {
        Task<Encabezados> GetUltEncabezado(int tipoencab);
        Task<Encabezados> GetEncabezadosByIdEncab(int idencab);
        Task<PagedList<Encabezados>> GetEncabezadosPaged(EncabezadosParameters encabezadoParameters);
        Task<PagedList<Encabezados>> GetEncabezadosPagedFilter(EncabezadosParameters encabezadoParameters, Expression<Func<Encabezados, bool>> expression);
        Task<IEnumerable<Encabezados>> GetAllEncabByDate(DateTime fechainicio, DateTime fechafin, int tipoencab);
        Task<IEnumerable<Encabezados>> GetEncabByIdTercero(DateTime fechainicio, DateTime fechafin, int idtercero);

        void CreateEncabezado(Encabezados encabezados);
        void UpdateEncabezado(Encabezados encabezados);
        void DeleteEncabezado(Encabezados encabezados);
        
    }
}
