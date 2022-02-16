using QuentameBlazor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using QuentameBlazor.Server.Parameters;

namespace QuentameBlazor.Server.Repository
{
    public interface IEncabezadoRepository : IRepositoryBase<Encabezados>
    {
        Encabezados GetUltEncabezado(int tipoencab);
        Encabezados GetEncabezadosByIdEncab(int idencab);
        PagedList<Encabezados> GetEncabezadosPaged(EncabezadosParameters encabezadoParameters);
        PagedList<Encabezados> GetEncabezadosPagedFilter(EncabezadosParameters encabezadoParameters, Expression<Func<Encabezados, bool>> expression);
        IEnumerable<Encabezados> GetAllEncabByDate(DateTime fechainicio, DateTime fechafin, int tipoencab);
        IEnumerable<Encabezados> GetEncabByIdTercero(DateTime fechainicio, DateTime fechafin, int idtercero);

        void CreateEncabezado(Encabezados encabezados);
        void UpdateEncabezado(Encabezados encabezados);
        void DeleteEncabezado(Encabezados encabezados);
        
    }
}
