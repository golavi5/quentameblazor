using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace QuentameBlazor.Repositories
{
    public class UserRepository : RepositoryBase<Usuarios>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public Usuarios GetUsuarioById(int userid)
        {
            return FindByCondition(u => u.IdUsuario.Equals(userid))
                .FirstOrDefault();
        }
    }
}
