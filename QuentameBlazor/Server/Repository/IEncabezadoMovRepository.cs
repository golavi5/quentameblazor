using QuentameBlazor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QuentameBlazor.Server.Repository
{
    public interface IEncabezadoMovRepository : IRepositoryBase<EncabezadosMov>
    {
        IEnumerable<EncabezadosMov> GetAllMov();
        IEnumerable<EncabezadosMov> GetMovsByIdEncab(int idencab);
        void CreateEncabezadoMov(EncabezadosMov encabezadomov);
        void CreateRangeEncabezadosMov(List<EncabezadosMov> encabezadosmov);
        void UpdateEncabezadoMov(EncabezadosMov encabezadomov);
        void DeleteEncabezadoMov(EncabezadosMov encabezadomov);
    }
}
