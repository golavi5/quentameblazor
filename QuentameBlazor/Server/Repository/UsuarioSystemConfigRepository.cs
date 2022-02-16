using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace QuentameBlazor.Server.Repository
{
    public class UsuarioSystemConfigRepository : RepositoryBase<UsuarioSystemConfig>, IUsuarioSystemConfigRepository
    {
        public UsuarioSystemConfigRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public UsuarioSystemConfig GetUsuarioSystemConfigByIdUsuario(int idusuario)
        {
            return FindByCondition(u => u.IdUsuario.Equals(idusuario))
                .FirstOrDefault();
        }
    }
}
