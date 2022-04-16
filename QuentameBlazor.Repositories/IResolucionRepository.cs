using QuentameBlazor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Repositories
{
    public interface IResolucionRepository : IRepositoryBase<EmpresasResoluciones>
    {
        EmpresasResoluciones GetResolucionByIdEmpresa(int empresaid);
    }
}
