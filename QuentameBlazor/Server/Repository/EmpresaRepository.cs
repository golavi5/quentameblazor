using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace QuentameBlazor.Server.Repository
{
    public class EmpresaRepository : RepositoryBase<Empresas>, IEmpresaRepository
    {
        public EmpresaRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public Empresas GetEmpresaById(int userid)
        {
            return FindByCondition(e => e.IdEmpresa.Equals(userid))
                .Include(e => e.Ciudad)
                .Include(e => e.Dep)
                .Include(e => e.TipoRegimen)
                .FirstOrDefault();
        }
    }
}
