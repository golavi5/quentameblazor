using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using QuentameBlazor.Server.Parameters;

namespace QuentameBlazor.Server.Repository
{
    public class ResolucionRepository : RepositoryBase<EmpresasResoluciones>, IResolucionRepository
    {
        public ResolucionRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public EmpresasResoluciones GetResolucionByIdEmpresa(int empresaid)
        {
            return FindByCondition(e => e.IdEmpresa.Equals(empresaid))
                .Include(e => e.Empresas)
                .FirstOrDefault();
        }
    }
}
