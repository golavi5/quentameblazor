using QuentameBlazor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QuentameBlazor.Repositories
{
    public interface IInvKardexRepository : IRepositoryBase<InventariosKardex>
    {
        IEnumerable<InventariosKardex> GetAllKardex(DateTime fechainicio, DateTime fechafin);
        IEnumerable<InventariosKardex> GetKardexByIdInv(int idinv, DateTime fechainicio, DateTime fechafin);
        void CreateInvKardex(InventariosKardex inventariosKardex);
        void CreateRangeInvKardex(List<InventariosKardex> listainvkardex);

    }
}
