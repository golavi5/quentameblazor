using QuentameBlazor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QuentameBlazor.Server.Repository
{
    public interface IEmpresaRepository : IRepositoryBase<Empresas>
    {
        Empresas GetEmpresaById(int empresaid);
    }
}
